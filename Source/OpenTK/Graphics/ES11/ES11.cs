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
    #pragma warning disable 3019
    #pragma warning disable 1591
    #pragma warning disable 1572
    #pragma warning disable 1573
    #pragma warning disable 626

    partial class GL
    {
        static GL()
        {
            EntryPointNames = new string[]
            {
                "glAccumxOES",
                "glActiveTexture",
                "glAlphaFunc",
                "glAlphaFuncx",
                "glAlphaFuncxOES",
                "glBindBuffer",
                "glBindFramebufferOES",
                "glBindRenderbufferOES",
                "glBindTexture",
                "glBindVertexArrayOES",
                "glBitmapxOES",
                "glBlendColorxOES",
                "glBlendEquationEXT",
                "glBlendEquationOES",
                "glBlendEquationSeparateOES",
                "glBlendFunc",
                "glBlendFuncSeparateOES",
                "glBufferData",
                "glBufferSubData",
                "glCheckFramebufferStatusOES",
                "glClear",
                "glClearAccumxOES",
                "glClearColor",
                "glClearColorx",
                "glClearColorxOES",
                "glClearDepthf",
                "glClearDepthfOES",
                "glClearDepthx",
                "glClearDepthxOES",
                "glClearStencil",
                "glClientActiveTexture",
                "glClientWaitSyncAPPLE",
                "glClipPlanef",
                "glClipPlanefIMG",
                "glClipPlanefOES",
                "glClipPlanex",
                "glClipPlanexIMG",
                "glClipPlanexOES",
                "glColor3xOES",
                "glColor3xvOES",
                "glColor4f",
                "glColor4ub",
                "glColor4x",
                "glColor4xOES",
                "glColor4xvOES",
                "glColorMask",
                "glColorPointer",
                "glCompressedTexImage2D",
                "glCompressedTexSubImage2D",
                "glConvolutionParameterxOES",
                "glConvolutionParameterxvOES",
                "glCopyTexImage2D",
                "glCopyTexSubImage2D",
                "glCopyTextureLevelsAPPLE",
                "glCullFace",
                "glCurrentPaletteMatrixOES",
                "glDeleteBuffers",
                "glDeleteFencesNV",
                "glDeleteFramebuffersOES",
                "glDeleteRenderbuffersOES",
                "glDeleteSyncAPPLE",
                "glDeleteTextures",
                "glDeleteVertexArraysOES",
                "glDepthFunc",
                "glDepthMask",
                "glDepthRangef",
                "glDepthRangefOES",
                "glDepthRangex",
                "glDepthRangexOES",
                "glDisable",
                "glDisableClientState",
                "glDisableDriverControlQCOM",
                "glDiscardFramebufferEXT",
                "glDrawArrays",
                "glDrawElements",
                "glDrawTexfOES",
                "glDrawTexfvOES",
                "glDrawTexiOES",
                "glDrawTexivOES",
                "glDrawTexsOES",
                "glDrawTexsvOES",
                "glDrawTexxOES",
                "glDrawTexxvOES",
                "glEGLImageTargetRenderbufferStorageOES",
                "glEGLImageTargetTexture2DOES",
                "glEnable",
                "glEnableClientState",
                "glEnableDriverControlQCOM",
                "glEndTilingQCOM",
                "glEvalCoord1xOES",
                "glEvalCoord1xvOES",
                "glEvalCoord2xOES",
                "glEvalCoord2xvOES",
                "glExtGetBufferPointervQCOM",
                "glExtGetBuffersQCOM",
                "glExtGetFramebuffersQCOM",
                "glExtGetProgramBinarySourceQCOM",
                "glExtGetProgramsQCOM",
                "glExtGetRenderbuffersQCOM",
                "glExtGetShadersQCOM",
                "glExtGetTexLevelParameterivQCOM",
                "glExtGetTexSubImageQCOM",
                "glExtGetTexturesQCOM",
                "glExtIsProgramBinaryQCOM",
                "glExtTexObjectStateOverrideiQCOM",
                "glFeedbackBufferxOES",
                "glFenceSyncAPPLE",
                "glFinish",
                "glFinishFenceNV",
                "glFlush",
                "glFlushMappedBufferRangeEXT",
                "glFogf",
                "glFogfv",
                "glFogx",
                "glFogxOES",
                "glFogxv",
                "glFogxvOES",
                "glFramebufferRenderbufferOES",
                "glFramebufferTexture2DMultisampleEXT",
                "glFramebufferTexture2DMultisampleIMG",
                "glFramebufferTexture2DOES",
                "glFrontFace",
                "glFrustumf",
                "glFrustumfOES",
                "glFrustumx",
                "glFrustumxOES",
                "glGenBuffers",
                "glGenerateMipmapOES",
                "glGenFencesNV",
                "glGenFramebuffersOES",
                "glGenRenderbuffersOES",
                "glGenTextures",
                "glGenVertexArraysOES",
                "glGetBooleanv",
                "glGetBufferParameteriv",
                "glGetBufferPointervOES",
                "glGetClipPlanef",
                "glGetClipPlanefOES",
                "glGetClipPlanex",
                "glGetClipPlanexOES",
                "glGetConvolutionParameterxvOES",
                "glGetDriverControlsQCOM",
                "glGetDriverControlStringQCOM",
                "glGetError",
                "glGetFenceivNV",
                "glGetFixedv",
                "glGetFixedvOES",
                "glGetFloatv",
                "glGetFramebufferAttachmentParameterivOES",
                "glGetGraphicsResetStatusEXT",
                "glGetHistogramParameterxvOES",
                "glGetInteger64vAPPLE",
                "glGetIntegerv",
                "glGetLightfv",
                "glGetLightxOES",
                "glGetLightxv",
                "glGetLightxvOES",
                "glGetMapxvOES",
                "glGetMaterialfv",
                "glGetMaterialxOES",
                "glGetMaterialxv",
                "glGetMaterialxvOES",
                "glGetnUniformfvEXT",
                "glGetnUniformivEXT",
                "glGetPixelMapxv",
                "glGetPointerv",
                "glGetRenderbufferParameterivOES",
                "glGetString",
                "glGetSyncivAPPLE",
                "glGetTexEnvfv",
                "glGetTexEnviv",
                "glGetTexEnvxv",
                "glGetTexEnvxvOES",
                "glGetTexGenfvOES",
                "glGetTexGenivOES",
                "glGetTexGenxvOES",
                "glGetTexLevelParameterxvOES",
                "glGetTexParameterfv",
                "glGetTexParameteriv",
                "glGetTexParameterxv",
                "glGetTexParameterxvOES",
                "glHint",
                "glIndexxOES",
                "glIndexxvOES",
                "glIsBuffer",
                "glIsEnabled",
                "glIsFenceNV",
                "glIsFramebufferOES",
                "glIsRenderbufferOES",
                "glIsSyncAPPLE",
                "glIsTexture",
                "glIsVertexArrayOES",
                "glLightf",
                "glLightfv",
                "glLightModelf",
                "glLightModelfv",
                "glLightModelx",
                "glLightModelxOES",
                "glLightModelxv",
                "glLightModelxvOES",
                "glLightx",
                "glLightxOES",
                "glLightxv",
                "glLightxvOES",
                "glLineWidth",
                "glLineWidthx",
                "glLineWidthxOES",
                "glLoadIdentity",
                "glLoadMatrixf",
                "glLoadMatrixx",
                "glLoadMatrixxOES",
                "glLoadPaletteFromModelViewMatrixOES",
                "glLoadTransposeMatrixxOES",
                "glLogicOp",
                "glMap1xOES",
                "glMap2xOES",
                "glMapBufferOES",
                "glMapBufferRangeEXT",
                "glMapGrid1xOES",
                "glMapGrid2xOES",
                "glMaterialf",
                "glMaterialfv",
                "glMaterialx",
                "glMaterialxOES",
                "glMaterialxv",
                "glMaterialxvOES",
                "glMatrixIndexPointerOES",
                "glMatrixMode",
                "glMultiDrawArraysEXT",
                "glMultiDrawElementsEXT",
                "glMultiTexCoord1bOES",
                "glMultiTexCoord1bvOES",
                "glMultiTexCoord1xOES",
                "glMultiTexCoord1xvOES",
                "glMultiTexCoord2bOES",
                "glMultiTexCoord2bvOES",
                "glMultiTexCoord2xOES",
                "glMultiTexCoord2xvOES",
                "glMultiTexCoord3bOES",
                "glMultiTexCoord3bvOES",
                "glMultiTexCoord3xOES",
                "glMultiTexCoord3xvOES",
                "glMultiTexCoord4bOES",
                "glMultiTexCoord4bvOES",
                "glMultiTexCoord4f",
                "glMultiTexCoord4x",
                "glMultiTexCoord4xOES",
                "glMultiTexCoord4xvOES",
                "glMultMatrixf",
                "glMultMatrixx",
                "glMultMatrixxOES",
                "glMultTransposeMatrixxOES",
                "glNormal3f",
                "glNormal3x",
                "glNormal3xOES",
                "glNormal3xvOES",
                "glNormalPointer",
                "glOrthof",
                "glOrthofOES",
                "glOrthox",
                "glOrthoxOES",
                "glPassThroughxOES",
                "glPixelMapx",
                "glPixelStorei",
                "glPixelStorex",
                "glPixelTransferxOES",
                "glPixelZoomxOES",
                "glPointParameterf",
                "glPointParameterfv",
                "glPointParameterx",
                "glPointParameterxOES",
                "glPointParameterxv",
                "glPointParameterxvOES",
                "glPointSize",
                "glPointSizePointerOES",
                "glPointSizex",
                "glPointSizexOES",
                "glPolygonOffset",
                "glPolygonOffsetx",
                "glPolygonOffsetxOES",
                "glPopMatrix",
                "glPrioritizeTexturesxOES",
                "glPushMatrix",
                "glQueryMatrixxOES",
                "glRasterPos2xOES",
                "glRasterPos2xvOES",
                "glRasterPos3xOES",
                "glRasterPos3xvOES",
                "glRasterPos4xOES",
                "glRasterPos4xvOES",
                "glReadnPixelsEXT",
                "glReadPixels",
                "glRectxOES",
                "glRectxvOES",
                "glRenderbufferStorageMultisampleAPPLE",
                "glRenderbufferStorageMultisampleEXT",
                "glRenderbufferStorageMultisampleIMG",
                "glRenderbufferStorageOES",
                "glResolveMultisampleFramebufferAPPLE",
                "glRotatef",
                "glRotatex",
                "glRotatexOES",
                "glSampleCoverage",
                "glSampleCoverageOES",
                "glSampleCoveragex",
                "glSampleCoveragexOES",
                "glScalef",
                "glScalex",
                "glScalexOES",
                "glScissor",
                "glSetFenceNV",
                "glShadeModel",
                "glStartTilingQCOM",
                "glStencilFunc",
                "glStencilMask",
                "glStencilOp",
                "glTestFenceNV",
                "glTexCoord1bOES",
                "glTexCoord1bvOES",
                "glTexCoord1xOES",
                "glTexCoord1xvOES",
                "glTexCoord2bOES",
                "glTexCoord2bvOES",
                "glTexCoord2xOES",
                "glTexCoord2xvOES",
                "glTexCoord3bOES",
                "glTexCoord3bvOES",
                "glTexCoord3xOES",
                "glTexCoord3xvOES",
                "glTexCoord4bOES",
                "glTexCoord4bvOES",
                "glTexCoord4xOES",
                "glTexCoord4xvOES",
                "glTexCoordPointer",
                "glTexEnvf",
                "glTexEnvfv",
                "glTexEnvi",
                "glTexEnviv",
                "glTexEnvx",
                "glTexEnvxOES",
                "glTexEnvxv",
                "glTexEnvxvOES",
                "glTexGenfOES",
                "glTexGenfvOES",
                "glTexGeniOES",
                "glTexGenivOES",
                "glTexGenxOES",
                "glTexGenxvOES",
                "glTexImage2D",
                "glTexParameterf",
                "glTexParameterfv",
                "glTexParameteri",
                "glTexParameteriv",
                "glTexParameterx",
                "glTexParameterxOES",
                "glTexParameterxv",
                "glTexParameterxvOES",
                "glTexStorage1DEXT",
                "glTexStorage2DEXT",
                "glTexStorage3DEXT",
                "glTexSubImage2D",
                "glTextureStorage1DEXT",
                "glTextureStorage2DEXT",
                "glTextureStorage3DEXT",
                "glTranslatef",
                "glTranslatex",
                "glTranslatexOES",
                "glUnmapBufferOES",
                "glVertex2bOES",
                "glVertex2bvOES",
                "glVertex2xOES",
                "glVertex2xvOES",
                "glVertex3bOES",
                "glVertex3bvOES",
                "glVertex3xOES",
                "glVertex3xvOES",
                "glVertex4bOES",
                "glVertex4bvOES",
                "glVertex4xOES",
                "glVertex4xvOES",
                "glVertexPointer",
                "glViewport",
                "glWaitSyncAPPLE",
                "glWeightPointerOES",
            };
            EntryPoints = new IntPtr[EntryPointNames.Length];
        }

        public static partial class Apple
        {
            /// <summary>[requires: APPLE_sync]
            /// Block and wait for a sync object to become signaled
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// The sync object whose status to wait on.
            /// </para>
            /// </param>
            /// <param name="flags">
            /// <para>
            /// A bitfield controlling the command flushing behavior. flags may be GL_SYNC_FLUSH_COMMANDS_BIT.
            /// </para>
            /// </param>
            /// <param name="timeout">
            /// <para>
            /// The timeout, specified in nanoseconds, for which the implementation should wait for sync to become signaled.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glClientWaitSyncAPPLE")]
            [CLSCompliant(false)]
            public static OpenTK.Graphics.ES11.All ClientWaitSync(IntPtr sync, Int32 flags, Int64 timeout) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]
            /// Block and wait for a sync object to become signaled
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// The sync object whose status to wait on.
            /// </para>
            /// </param>
            /// <param name="flags">
            /// <para>
            /// A bitfield controlling the command flushing behavior. flags may be GL_SYNC_FLUSH_COMMANDS_BIT.
            /// </para>
            /// </param>
            /// <param name="timeout">
            /// <para>
            /// The timeout, specified in nanoseconds, for which the implementation should wait for sync to become signaled.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glClientWaitSyncAPPLE")]
            [CLSCompliant(false)]
            public static OpenTK.Graphics.ES11.All ClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_copy_texture_levels]</summary>
            [AutoGenerated(Category = "APPLE_copy_texture_levels", Version = "", EntryPoint = "glCopyTextureLevelsAPPLE")]
            [CLSCompliant(false)]
            public static void CopyTextureLevel(Int32 destinationTexture, Int32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_copy_texture_levels]</summary>
            [AutoGenerated(Category = "APPLE_copy_texture_levels", Version = "", EntryPoint = "glCopyTextureLevelsAPPLE")]
            [CLSCompliant(false)]
            public static void CopyTextureLevel(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]
            /// Delete a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// The sync object to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glDeleteSyncAPPLE")]
            public static void DeleteSync(IntPtr sync) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]
            /// Create a new sync object and insert it into the GL command stream
            /// </summary>
            /// <param name="condition">
            /// <para>
            /// Specifies the condition that must be met to set the sync object's state to signaled. condition must be GL_SYNC_GPU_COMMANDS_COMPLETE.
            /// </para>
            /// </param>
            /// <param name="flags">
            /// <para>
            /// Specifies a bitwise combination of flags controlling the behavior of the sync object. No flags are presently defined for this operation and flags must be zero. flags is a placeholder for anticipated future extensions of fence sync object capabilities.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glFenceSyncAPPLE")]
            [CLSCompliant(false)]
            public static IntPtr FenceSync(OpenTK.Graphics.ES11.All condition, Int32 flags) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]
            /// Create a new sync object and insert it into the GL command stream
            /// </summary>
            /// <param name="condition">
            /// <para>
            /// Specifies the condition that must be met to set the sync object's state to signaled. condition must be GL_SYNC_GPU_COMMANDS_COMPLETE.
            /// </para>
            /// </param>
            /// <param name="flags">
            /// <para>
            /// Specifies a bitwise combination of flags controlling the behavior of the sync object. No flags are presently defined for this operation and flags must be zero. flags is a placeholder for anticipated future extensions of fence sync object capabilities.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glFenceSyncAPPLE")]
            [CLSCompliant(false)]
            public static IntPtr FenceSync(OpenTK.Graphics.ES11.All condition, UInt32 flags) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]</summary>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetInteger64vAPPLE")]
            [CLSCompliant(false)]
            public static Int64 GetInteger64(OpenTK.Graphics.ES11.All pname) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]</summary>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetInteger64vAPPLE")]
            [CLSCompliant(false)]
            public static void GetInteger64(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int64[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]</summary>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetInteger64vAPPLE")]
            [CLSCompliant(false)]
            public static void GetInteger64(OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int64 @params) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]</summary>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetInteger64vAPPLE")]
            [CLSCompliant(false)]
            public static unsafe void GetInteger64(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int64* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]
            /// Query the properties of a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies the sync object whose properties to query.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter whose value to retrieve from the sync object specified in sync.
            /// </para>
            /// </param>
            /// <param name="bufSize">
            /// <para>
            /// Specifies the size of the buffer whose address is given in values.
            /// </para>
            /// </param>
            /// <param name="length">
            /// <para>
            /// Specifies the address of an variable to receive the number of integers placed in values.
            /// </para>
            /// </param>
            /// <param name="values">
            /// <para>
            /// Specifies the address of an array to receive the values of the queried parameter.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetSyncivAPPLE")]
            [CLSCompliant(false)]
            public static void GetSync(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] values) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]
            /// Query the properties of a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies the sync object whose properties to query.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter whose value to retrieve from the sync object specified in sync.
            /// </para>
            /// </param>
            /// <param name="bufSize">
            /// <para>
            /// Specifies the size of the buffer whose address is given in values.
            /// </para>
            /// </param>
            /// <param name="length">
            /// <para>
            /// Specifies the address of an variable to receive the number of integers placed in values.
            /// </para>
            /// </param>
            /// <param name="values">
            /// <para>
            /// Specifies the address of an array to receive the values of the queried parameter.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetSyncivAPPLE")]
            [CLSCompliant(false)]
            public static void GetSync(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out Int32 values) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]
            /// Query the properties of a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies the sync object whose properties to query.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter whose value to retrieve from the sync object specified in sync.
            /// </para>
            /// </param>
            /// <param name="bufSize">
            /// <para>
            /// Specifies the size of the buffer whose address is given in values.
            /// </para>
            /// </param>
            /// <param name="length">
            /// <para>
            /// Specifies the address of an variable to receive the number of integers placed in values.
            /// </para>
            /// </param>
            /// <param name="values">
            /// <para>
            /// Specifies the address of an array to receive the values of the queried parameter.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetSyncivAPPLE")]
            [CLSCompliant(false)]
            public static unsafe void GetSync(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]
            /// Determine if a name corresponds to a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies a value that may be the name of a sync object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glIsSyncAPPLE")]
            public static bool IsSync(IntPtr sync) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_framebuffer_multisample]
            /// Establish data storage, format, dimensions and sample count of a renderbuffer object's image
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="samples">
            /// <para>
            /// Specifies the number of samples to be used for the renderbuffer object's storage.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the internal format to use for the renderbuffer object's image.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            /// <param name="height">
            /// <para>
            /// Specifies the height of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_framebuffer_multisample", Version = "", EntryPoint = "glRenderbufferStorageMultisampleAPPLE")]
            public static void RenderbufferStorageMultisample(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_framebuffer_multisample]</summary>
            [AutoGenerated(Category = "APPLE_framebuffer_multisample", Version = "", EntryPoint = "glResolveMultisampleFramebufferAPPLE")]
            public static void ResolveMultisampleFramebuffer() { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]
            /// Instruct the GL server to block until the specified sync object becomes signaled
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies the sync object whose status to wait on.
            /// </para>
            /// </param>
            /// <param name="flags">
            /// <para>
            /// A bitfield controlling the command flushing behavior. flags may be zero.
            /// </para>
            /// </param>
            /// <param name="timeout">
            /// <para>
            /// Specifies the timeout that the server should wait before continuing. timeout must be GL_TIMEOUT_IGNORED.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glWaitSyncAPPLE")]
            [CLSCompliant(false)]
            public static void WaitSync(IntPtr sync, Int32 flags, Int64 timeout) { throw new NotImplementedException(); }

            /// <summary>[requires: APPLE_sync]
            /// Instruct the GL server to block until the specified sync object becomes signaled
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies the sync object whose status to wait on.
            /// </para>
            /// </param>
            /// <param name="flags">
            /// <para>
            /// A bitfield controlling the command flushing behavior. flags may be zero.
            /// </para>
            /// </param>
            /// <param name="timeout">
            /// <para>
            /// Specifies the timeout that the server should wait before continuing. timeout must be GL_TIMEOUT_IGNORED.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glWaitSyncAPPLE")]
            [CLSCompliant(false)]
            public static void WaitSync(IntPtr sync, UInt32 flags, UInt64 timeout) { throw new NotImplementedException(); }

        }

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least 80. texture must be one of GL_TEXTUREi, where i ranges from zero to the value of GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS minus one. The initial value is GL_TEXTURE0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glActiveTexture")]
        public static void ActiveTexture(OpenTK.Graphics.ES11.All texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least 80. texture must be one of GL_TEXTUREi, where i ranges from zero to the value of GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS minus one. The initial value is GL_TEXTURE0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glActiveTexture")]
        public static void ActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the alpha test function
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the alpha comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_ALWAYS.
        /// </para>
        /// </param>
        /// <param name="ref">
        /// <para>
        /// Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range [0,1], where 0 represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glAlphaFunc")]
        public static void AlphaFunc(OpenTK.Graphics.ES11.All func, Single @ref) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the alpha test function
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the alpha comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_ALWAYS.
        /// </para>
        /// </param>
        /// <param name="ref">
        /// <para>
        /// Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range [0,1], where 0 represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glAlphaFunc")]
        public static void AlphaFunc(OpenTK.Graphics.ES11.AlphaFunction func, Single @ref) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glAlphaFuncx")]
        public static void AlphaFuncx(OpenTK.Graphics.ES11.All func, int @ref) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named buffer object
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target to which the buffer object is bound. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="buffer">
        /// <para>
        /// Specifies the name of a buffer object.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindBuffer")]
        [CLSCompliant(false)]
        public static void BindBuffer(OpenTK.Graphics.ES11.All target, Int32 buffer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named buffer object
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target to which the buffer object is bound. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="buffer">
        /// <para>
        /// Specifies the name of a buffer object.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindBuffer")]
        [CLSCompliant(false)]
        public static void BindBuffer(OpenTK.Graphics.ES11.All target, UInt32 buffer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target to which the texture is bound. Must be one of GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_BUFFER, GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY.
        /// </para>
        /// </param>
        /// <param name="texture">
        /// <para>
        /// Specifies the name of a texture.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindTexture")]
        [CLSCompliant(false)]
        public static void BindTexture(OpenTK.Graphics.ES11.All target, Int32 texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target to which the texture is bound. Must be one of GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_BUFFER, GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY.
        /// </para>
        /// </param>
        /// <param name="texture">
        /// <para>
        /// Specifies the name of a texture.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindTexture")]
        [CLSCompliant(false)]
        public static void BindTexture(OpenTK.Graphics.ES11.All target, UInt32 texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target to which the texture is bound. Must be one of GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_BUFFER, GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY.
        /// </para>
        /// </param>
        /// <param name="texture">
        /// <para>
        /// Specifies the name of a texture.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindTexture")]
        [CLSCompliant(false)]
        public static void BindTexture(OpenTK.Graphics.ES11.TextureTarget target, Int32 texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target to which the texture is bound. Must be one of GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_BUFFER, GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY.
        /// </para>
        /// </param>
        /// <param name="texture">
        /// <para>
        /// Specifies the name of a texture.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindTexture")]
        [CLSCompliant(false)]
        public static void BindTexture(OpenTK.Graphics.ES11.TextureTarget target, UInt32 texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify pixel arithmetic
        /// </summary>
        /// <param name="buf">
        /// <para>
        /// For glBlendFunci, specifies the index of the draw buffer for which to set the blend function.
        /// </para>
        /// </param>
        /// <param name="sfactor">
        /// <para>
        /// Specifies how the red, green, blue, and alpha source blending factors are computed. The initial value is GL_ONE.
        /// </para>
        /// </param>
        /// <param name="dfactor">
        /// <para>
        /// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA. GL_CONSTANT_COLOR, GL_ONE_MINUS_CONSTANT_COLOR, GL_CONSTANT_ALPHA, and GL_ONE_MINUS_CONSTANT_ALPHA. The initial value is GL_ZERO.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBlendFunc")]
        public static void BlendFunc(OpenTK.Graphics.ES11.All sfactor, OpenTK.Graphics.ES11.All dfactor) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify pixel arithmetic
        /// </summary>
        /// <param name="buf">
        /// <para>
        /// For glBlendFunci, specifies the index of the draw buffer for which to set the blend function.
        /// </para>
        /// </param>
        /// <param name="sfactor">
        /// <para>
        /// Specifies how the red, green, blue, and alpha source blending factors are computed. The initial value is GL_ONE.
        /// </para>
        /// </param>
        /// <param name="dfactor">
        /// <para>
        /// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA. GL_CONSTANT_COLOR, GL_ONE_MINUS_CONSTANT_COLOR, GL_CONSTANT_ALPHA, and GL_ONE_MINUS_CONSTANT_ALPHA. The initial value is GL_ZERO.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBlendFunc")]
        public static void BlendFunc(OpenTK.Graphics.ES11.BlendingFactorSrc sfactor, OpenTK.Graphics.ES11.BlendingFactorDest dfactor) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Creates and initializes a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.
        /// </para>
        /// </param>
        /// <param name="usage">
        /// <para>
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        public static void BufferData(OpenTK.Graphics.ES11.All target, IntPtr size, IntPtr data, OpenTK.Graphics.ES11.All usage) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Creates and initializes a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.
        /// </para>
        /// </param>
        /// <param name="usage">
        /// <para>
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        [CLSCompliant(false)]
        public static void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] T2[] data, OpenTK.Graphics.ES11.All usage)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Creates and initializes a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.
        /// </para>
        /// </param>
        /// <param name="usage">
        /// <para>
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        [CLSCompliant(false)]
        public static void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] T2[,] data, OpenTK.Graphics.ES11.All usage)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Creates and initializes a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.
        /// </para>
        /// </param>
        /// <param name="usage">
        /// <para>
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        [CLSCompliant(false)]
        public static void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] T2[,,] data, OpenTK.Graphics.ES11.All usage)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Creates and initializes a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.
        /// </para>
        /// </param>
        /// <param name="usage">
        /// <para>
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        public static void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] ref T2 data, OpenTK.Graphics.ES11.All usage)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Updates a subset of a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="offset">
        /// <para>
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the data store region being replaced.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        public static void BufferSubData(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Updates a subset of a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="offset">
        /// <para>
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the data store region being replaced.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        [CLSCompliant(false)]
        public static void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[] data)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Updates a subset of a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="offset">
        /// <para>
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the data store region being replaced.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        [CLSCompliant(false)]
        public static void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[,] data)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Updates a subset of a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="offset">
        /// <para>
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the data store region being replaced.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        [CLSCompliant(false)]
        public static void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[,,] data)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Updates a subset of a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="offset">
        /// <para>
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the data store region being replaced.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        public static void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] ref T3 data)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Clear buffers to preset values
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClear")]
        public static void Clear(OpenTK.Graphics.ES11.All mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Clear buffers to preset values
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClear")]
        public static void Clear(OpenTK.Graphics.ES11.ClearBufferMask mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Clear buffers to preset values
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT.
        /// </para>
        /// </param>
        [Obsolete("Use ClearMask overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClear")]
        public static void Clear(UInt32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify clear values for the color buffers
        /// </summary>
        /// <param name="red">
        /// <para>
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearColor")]
        public static void ClearColor(Single red, Single green, Single blue, Single alpha) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearColorx")]
        public static void ClearColorx(int red, int green, int blue, int alpha) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the clear value for the depth buffer
        /// </summary>
        /// <param name="depth">
        /// <para>
        /// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearDepthf")]
        public static void ClearDepth(Single d) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearDepthx")]
        public static void ClearDepthx(int depth) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the clear value for the stencil buffer
        /// </summary>
        /// <param name="s">
        /// <para>
        /// Specifies the index used when the stencil buffer is cleared. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearStencil")]
        public static void ClearStencil(Int32 s) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least two. texture must be one of GL_TEXTURE, where i ranges from 0 to the value of GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value. The initial value is GL_TEXTURE0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClientActiveTexture")]
        public static void ClientActiveTexture(OpenTK.Graphics.ES11.All texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least two. texture must be one of GL_TEXTURE, where i ranges from 0 to the value of GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value. The initial value is GL_TEXTURE0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClientActiveTexture")]
        public static void ClientActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a plane against which all geometry is clipped
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
        /// </para>
        /// </param>
        /// <param name="equation">
        /// <para>
        /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanef")]
        [CLSCompliant(false)]
        public static void ClipPlane(OpenTK.Graphics.ES11.All p, Single[] eqn) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a plane against which all geometry is clipped
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
        /// </para>
        /// </param>
        /// <param name="equation">
        /// <para>
        /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanef")]
        [CLSCompliant(false)]
        public static void ClipPlane(OpenTK.Graphics.ES11.All p, ref Single eqn) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a plane against which all geometry is clipped
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
        /// </para>
        /// </param>
        /// <param name="equation">
        /// <para>
        /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanef")]
        [CLSCompliant(false)]
        public static unsafe void ClipPlane(OpenTK.Graphics.ES11.All p, Single* eqn) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanex")]
        [CLSCompliant(false)]
        public static void ClipPlanex(OpenTK.Graphics.ES11.All plane, int[] equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanex")]
        [CLSCompliant(false)]
        public static void ClipPlanex(OpenTK.Graphics.ES11.All plane, ref int equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanex")]
        [CLSCompliant(false)]
        public static unsafe void ClipPlanex(OpenTK.Graphics.ES11.All plane, int* equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the current color
        /// </summary>
        /// <param name="red">
        /// <para>
        /// Specify new red, green, and blue values for the current color.
        /// </para>
        /// </param>
        /// <param name="alpha">
        /// <para>
        /// Specifies a new alpha value for the current color. Included only in the four-argument glColor4 commands.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColor4f")]
        public static void Color4(Single red, Single green, Single blue, Single alpha) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the current color
        /// </summary>
        /// <param name="red">
        /// <para>
        /// Specify new red, green, and blue values for the current color.
        /// </para>
        /// </param>
        /// <param name="alpha">
        /// <para>
        /// Specifies a new alpha value for the current color. Included only in the four-argument glColor4 commands.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColor4ub")]
        public static void Color4(Byte red, Byte green, Byte blue, Byte alpha) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColor4x")]
        public static void Color4x(int red, int green, int blue, int alpha) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Enable and disable writing of frame buffer color components
        /// </summary>
        /// <param name="buf">
        /// <para>
        /// For glColorMaski, specifies the index of the draw buffer whose color mask to set.
        /// </para>
        /// </param>
        /// <param name="red">
        /// <para>
        /// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorMask")]
        public static void ColorMask(bool red, bool green, bool blue, bool alpha) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        public static void ColorPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        [CLSCompliant(false)]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        [CLSCompliant(false)]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        [CLSCompliant(false)]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        public static void ColorPointer(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        [CLSCompliant(false)]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        [CLSCompliant(false)]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        [CLSCompliant(false)]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        public static void CompressedTexImage2D(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,,] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] ref T7 data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        public static void CompressedTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,,] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] ref T7 data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        public static void CompressedTexSubImage2D(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, [InAttribute, OutAttribute] T8[] data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, [InAttribute, OutAttribute] T8[,] data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, [InAttribute, OutAttribute] T8[,,] data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, [InAttribute, OutAttribute] ref T8 data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        public static void CompressedTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[] data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[,] data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[,,] data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] ref T8 data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Copy pixels into a 2D texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: GL_COMPRESSED_RED, GL_COMPRESSED_RG, GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, GL_COMPRESSED_SRGB_ALPHA. GL_DEPTH_COMPONENT, GL_DEPTH_COMPONENT16, GL_DEPTH_COMPONENT24, GL_DEPTH_COMPONENT32, GL_STENCIL_INDEX8, GL_RED, GL_RG, GL_RGB, GL_R3_G3_B2, GL_RGB4, GL_RGB5, GL_RGB8, GL_RGB10, GL_RGB12, GL_RGB16, GL_RGBA, GL_RGBA2, GL_RGBA4, GL_RGB5_A1, GL_RGBA8, GL_RGB10_A2, GL_RGBA12, GL_RGBA16, GL_SRGB, GL_SRGB8, GL_SRGB_ALPHA, or GL_SRGB8_ALPHA8.
        /// </para>
        /// </param>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// Must be 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCopyTexImage2D")]
        public static void CopyTexImage2D(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Copy pixels into a 2D texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: GL_COMPRESSED_RED, GL_COMPRESSED_RG, GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, GL_COMPRESSED_SRGB_ALPHA. GL_DEPTH_COMPONENT, GL_DEPTH_COMPONENT16, GL_DEPTH_COMPONENT24, GL_DEPTH_COMPONENT32, GL_STENCIL_INDEX8, GL_RED, GL_RG, GL_RGB, GL_R3_G3_B2, GL_RGB4, GL_RGB5, GL_RGB8, GL_RGB10, GL_RGB12, GL_RGB16, GL_RGBA, GL_RGBA2, GL_RGBA4, GL_RGB5_A1, GL_RGBA8, GL_RGB10_A2, GL_RGBA12, GL_RGBA16, GL_SRGB, GL_SRGB8, GL_SRGB_ALPHA, or GL_SRGB8_ALPHA8.
        /// </para>
        /// </param>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// Must be 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCopyTexImage2D")]
        public static void CopyTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Copy a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCopyTexSubImage2D")]
        public static void CopyTexSubImage2D(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Copy a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCopyTexSubImage2D")]
        public static void CopyTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify whether front- or back-facing facets can be culled
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies whether front- or back-facing facets are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCullFace")]
        public static void CullFace(OpenTK.Graphics.ES11.All mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify whether front- or back-facing facets can be culled
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies whether front- or back-facing facets are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCullFace")]
        public static void CullFace(OpenTK.Graphics.ES11.CullFaceMode mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static void DeleteBuffer(Int32 buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static void DeleteBuffer(UInt32 buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static void DeleteBuffers(Int32 n, Int32[] buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static void DeleteBuffers(Int32 n, ref Int32 buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static unsafe void DeleteBuffers(Int32 n, Int32* buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static void DeleteBuffers(Int32 n, UInt32[] buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static void DeleteBuffers(Int32 n, ref UInt32 buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static unsafe void DeleteBuffers(Int32 n, UInt32* buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static void DeleteTexture(Int32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static void DeleteTexture(UInt32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static void DeleteTextures(Int32 n, Int32[] textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static void DeleteTextures(Int32 n, ref Int32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static unsafe void DeleteTextures(Int32 n, Int32* textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static void DeleteTextures(Int32 n, UInt32[] textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static void DeleteTextures(Int32 n, ref UInt32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static unsafe void DeleteTextures(Int32 n, UInt32* textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the value used for depth buffer comparisons
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthFunc")]
        public static void DepthFunc(OpenTK.Graphics.ES11.All func) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the value used for depth buffer comparisons
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthFunc")]
        public static void DepthFunc(OpenTK.Graphics.ES11.DepthFunction func) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Enable or disable writing into the depth buffer
        /// </summary>
        /// <param name="flag">
        /// <para>
        /// Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthMask")]
        public static void DepthMask(bool flag) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify mapping of depth values from normalized device coordinates to window coordinates
        /// </summary>
        /// <param name="nearVal">
        /// <para>
        /// Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="farVal">
        /// <para>
        /// Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthRangef")]
        public static void DepthRange(Single n, Single f) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthRangex")]
        public static void DepthRangex(int n, int f) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisable")]
        public static void Disable(OpenTK.Graphics.ES11.All cap) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisable")]
        public static void Disable(OpenTK.Graphics.ES11.EnableCap cap) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisableClientState")]
        public static void DisableClientState(OpenTK.Graphics.ES11.All array) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisableClientState")]
        public static void DisableClientState(OpenTK.Graphics.ES11.EnableCap array) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="first">
        /// <para>
        /// Specifies the starting index in the enabled arrays.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of indices to be rendered.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawArrays")]
        public static void DrawArrays(OpenTK.Graphics.ES11.All mode, Int32 first, Int32 count) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="first">
        /// <para>
        /// Specifies the starting index in the enabled arrays.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of indices to be rendered.
        /// </para>
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawArrays")]
        public static void DrawArrays(OpenTK.Graphics.ES11.BeginMode mode, Int32 first, Int32 count) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="first">
        /// <para>
        /// Specifies the starting index in the enabled arrays.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of indices to be rendered.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawArrays")]
        public static void DrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 first, Int32 count) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Enable or disable server-side GL capabilities
        /// </summary>
        /// <param name="cap">
        /// <para>
        /// Specifies a symbolic constant indicating a GL capability.
        /// </para>
        /// </param>
        /// <param name="index">
        /// <para>
        /// Specifies the index of the switch to disable (for glEnablei and glDisablei only).
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glEnable")]
        public static void Enable(OpenTK.Graphics.ES11.All cap) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Enable or disable server-side GL capabilities
        /// </summary>
        /// <param name="cap">
        /// <para>
        /// Specifies a symbolic constant indicating a GL capability.
        /// </para>
        /// </param>
        /// <param name="index">
        /// <para>
        /// Specifies the index of the switch to disable (for glEnablei and glDisablei only).
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glEnable")]
        public static void Enable(OpenTK.Graphics.ES11.EnableCap cap) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Enable or disable client-side capability
        /// </summary>
        /// <param name="cap">
        /// <para>
        /// Specifies the capability to enable. Symbolic constants GL_COLOR_ARRAY, GL_EDGE_FLAG_ARRAY, GL_FOG_COORD_ARRAY, GL_INDEX_ARRAY, GL_NORMAL_ARRAY, GL_SECONDARY_COLOR_ARRAY, GL_TEXTURE_COORD_ARRAY, and GL_VERTEX_ARRAY are accepted.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glEnableClientState")]
        public static void EnableClientState(OpenTK.Graphics.ES11.All array) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Enable or disable client-side capability
        /// </summary>
        /// <param name="cap">
        /// <para>
        /// Specifies the capability to enable. Symbolic constants GL_COLOR_ARRAY, GL_EDGE_FLAG_ARRAY, GL_FOG_COORD_ARRAY, GL_INDEX_ARRAY, GL_NORMAL_ARRAY, GL_SECONDARY_COLOR_ARRAY, GL_TEXTURE_COORD_ARRAY, and GL_VERTEX_ARRAY are accepted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glEnableClientState")]
        public static void EnableClientState(OpenTK.Graphics.ES11.EnableCap array) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Block until all GL execution is complete
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFinish")]
        public static void Finish() { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Force execution of GL commands in finite time
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFlush")]
        public static void Flush() { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, GL_FOG_END, GL_FOG_INDEX, and GL_FOG_COORD_SRC are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that pname will be set to.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogf")]
        public static void Fog(OpenTK.Graphics.ES11.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, GL_FOG_END, GL_FOG_INDEX, and GL_FOG_COORD_SRC are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that pname will be set to.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogf")]
        public static void Fog(OpenTK.Graphics.ES11.FogParameter pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, GL_FOG_END, GL_FOG_INDEX, and GL_FOG_COORD_SRC are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that pname will be set to.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogfv")]
        [CLSCompliant(false)]
        public static void Fog(OpenTK.Graphics.ES11.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, GL_FOG_END, GL_FOG_INDEX, and GL_FOG_COORD_SRC are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that pname will be set to.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogfv")]
        [CLSCompliant(false)]
        public static unsafe void Fog(OpenTK.Graphics.ES11.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, GL_FOG_END, GL_FOG_INDEX, and GL_FOG_COORD_SRC are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that pname will be set to.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogfv")]
        [CLSCompliant(false)]
        public static void Fog(OpenTK.Graphics.ES11.FogParameter pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, GL_FOG_END, GL_FOG_INDEX, and GL_FOG_COORD_SRC are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that pname will be set to.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogfv")]
        [CLSCompliant(false)]
        public static unsafe void Fog(OpenTK.Graphics.ES11.FogParameter pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogx")]
        public static void Fogx(OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogxv")]
        [CLSCompliant(false)]
        public static void Fogx(OpenTK.Graphics.ES11.All pname, int[] param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogxv")]
        [CLSCompliant(false)]
        public static unsafe void Fogx(OpenTK.Graphics.ES11.All pname, int* param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define front- and back-facing polygons
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFrontFace")]
        public static void FrontFace(OpenTK.Graphics.ES11.All mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define front- and back-facing polygons
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFrontFace")]
        public static void FrontFace(OpenTK.Graphics.ES11.FrontFaceDirection mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a perspective matrix
        /// </summary>
        /// <param name="left">
        /// <para>
        /// Specify the coordinates for the left and right vertical clipping planes.
        /// </para>
        /// </param>
        /// <param name="bottom">
        /// <para>
        /// Specify the coordinates for the bottom and top horizontal clipping planes.
        /// </para>
        /// </param>
        /// <param name="nearVal">
        /// <para>
        /// Specify the distances to the near and far depth clipping planes. Both distances must be positive.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFrustumf")]
        public static void Frustum(Single l, Single r, Single b, Single t, Single n, Single f) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFrustumx")]
        public static void Frustumx(int l, int r, int b, int t, int n, int f) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static Int32 GenBuffer() { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static void GenBuffers(Int32 n, [OutAttribute] Int32[] buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static void GenBuffers(Int32 n, [OutAttribute] out Int32 buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static unsafe void GenBuffers(Int32 n, [OutAttribute] Int32* buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static void GenBuffers(Int32 n, [OutAttribute] UInt32[] buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static void GenBuffers(Int32 n, [OutAttribute] out UInt32 buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static unsafe void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static Int32 GenTexture() { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static void GenTextures(Int32 n, [OutAttribute] Int32[] textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static void GenTextures(Int32 n, [OutAttribute] out Int32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static unsafe void GenTextures(Int32 n, [OutAttribute] Int32* textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static void GenTextures(Int32 n, [OutAttribute] UInt32[] textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static void GenTextures(Int32 n, [OutAttribute] out UInt32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static unsafe void GenTextures(Int32 n, [OutAttribute] UInt32* textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static bool GetBoolean(OpenTK.Graphics.ES11.All pname) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static bool GetBoolean(OpenTK.Graphics.ES11.GetPName pname) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static void GetBoolean(OpenTK.Graphics.ES11.All pname, [OutAttribute] bool[] data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static void GetBoolean(OpenTK.Graphics.ES11.All pname, [OutAttribute] out bool data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static unsafe void GetBoolean(OpenTK.Graphics.ES11.All pname, [OutAttribute] bool* data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static void GetBoolean(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool[] data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static void GetBoolean(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] out bool data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static unsafe void GetBoolean(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool* data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, or GL_PIXEL_UNPACK_BUFFER.
        /// </para>
        /// </param>
        /// <param name="value">
        /// <para>
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS, GL_BUFFER_MAPPED, GL_BUFFER_SIZE, or GL_BUFFER_USAGE.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the requested parameter.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBufferParameteriv")]
        [CLSCompliant(false)]
        public static void GetBufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, or GL_PIXEL_UNPACK_BUFFER.
        /// </para>
        /// </param>
        /// <param name="value">
        /// <para>
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS, GL_BUFFER_MAPPED, GL_BUFFER_SIZE, or GL_BUFFER_USAGE.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the requested parameter.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBufferParameteriv")]
        [CLSCompliant(false)]
        public static void GetBufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, or GL_PIXEL_UNPACK_BUFFER.
        /// </para>
        /// </param>
        /// <param name="value">
        /// <para>
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS, GL_BUFFER_MAPPED, GL_BUFFER_SIZE, or GL_BUFFER_USAGE.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the requested parameter.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBufferParameteriv")]
        [CLSCompliant(false)]
        public static unsafe void GetBufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the coefficients of the specified clipping plane
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
        /// </para>
        /// </param>
        /// <param name="equation">
        /// <para>
        /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanef")]
        [CLSCompliant(false)]
        public static Single GetClipPlane(OpenTK.Graphics.ES11.All plane) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the coefficients of the specified clipping plane
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
        /// </para>
        /// </param>
        /// <param name="equation">
        /// <para>
        /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanef")]
        [CLSCompliant(false)]
        public static void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single[] equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the coefficients of the specified clipping plane
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
        /// </para>
        /// </param>
        /// <param name="equation">
        /// <para>
        /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanef")]
        [CLSCompliant(false)]
        public static void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] out Single equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the coefficients of the specified clipping plane
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
        /// </para>
        /// </param>
        /// <param name="equation">
        /// <para>
        /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanef")]
        [CLSCompliant(false)]
        public static unsafe void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        [CLSCompliant(false)]
        public static int GetClipPlanex(OpenTK.Graphics.ES11.All plane) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        [CLSCompliant(false)]
        public static void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int[] equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        [CLSCompliant(false)]
        public static void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] out int equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        [CLSCompliant(false)]
        public static unsafe void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return error information
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetError")]
        public static OpenTK.Graphics.ES11.ErrorCode GetError() { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        [CLSCompliant(false)]
        public static int GetFixed(OpenTK.Graphics.ES11.All pname) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        [CLSCompliant(false)]
        public static void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        [CLSCompliant(false)]
        public static void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        [CLSCompliant(false)]
        public static unsafe void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static Single GetFloat(OpenTK.Graphics.ES11.All pname) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static Single GetFloat(OpenTK.Graphics.ES11.GetPName pname) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static void GetFloat(OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static void GetFloat(OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static unsafe void GetFloat(OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static void GetFloat(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single[] data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static void GetFloat(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] out Single data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static unsafe void GetFloat(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single* data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static Int32 GetInteger(OpenTK.Graphics.ES11.All pname) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static Int32 GetInteger(OpenTK.Graphics.ES11.GetPName pname) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static void GetInteger(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static void GetInteger(OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static unsafe void GetInteger(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static void GetInteger(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32[] data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static void GetInteger(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] out Int32 data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static unsafe void GetInteger(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32* data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT where ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        [CLSCompliant(false)]
        public static void GetLight(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT where ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        [CLSCompliant(false)]
        public static void GetLight(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT where ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        [CLSCompliant(false)]
        public static unsafe void GetLight(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT where ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        [CLSCompliant(false)]
        public static void GetLight(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT where ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        [CLSCompliant(false)]
        public static void GetLight(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT where ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        [CLSCompliant(false)]
        public static unsafe void GetLight(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightxv")]
        [CLSCompliant(false)]
        public static void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightxv")]
        [CLSCompliant(false)]
        public static void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightxv")]
        [CLSCompliant(false)]
        public static unsafe void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the material parameter to return. GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, GL_SHININESS, and GL_COLOR_INDEXES are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        [CLSCompliant(false)]
        public static void GetMaterial(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the material parameter to return. GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, GL_SHININESS, and GL_COLOR_INDEXES are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        [CLSCompliant(false)]
        public static void GetMaterial(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the material parameter to return. GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, GL_SHININESS, and GL_COLOR_INDEXES are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        [CLSCompliant(false)]
        public static unsafe void GetMaterial(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the material parameter to return. GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, GL_SHININESS, and GL_COLOR_INDEXES are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        [CLSCompliant(false)]
        public static void GetMaterial(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the material parameter to return. GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, GL_SHININESS, and GL_COLOR_INDEXES are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        [CLSCompliant(false)]
        public static void GetMaterial(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the material parameter to return. GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, GL_SHININESS, and GL_COLOR_INDEXES are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        [CLSCompliant(false)]
        public static unsafe void GetMaterial(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialxv")]
        [CLSCompliant(false)]
        public static void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialxv")]
        [CLSCompliant(false)]
        public static void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialxv")]
        [CLSCompliant(false)]
        public static unsafe void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetPixelMapxv")]
        [CLSCompliant(false)]
        public static void GetPixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] int[] values) { throw new NotImplementedException(); }

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetPixelMapxv")]
        [CLSCompliant(false)]
        public static void GetPixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] out int values) { throw new NotImplementedException(); }

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetPixelMapxv")]
        [CLSCompliant(false)]
        public static unsafe void GetPixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] int* values) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        public static void GetPointer(OpenTK.Graphics.ES11.All pname, [OutAttribute] IntPtr @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        [CLSCompliant(false)]
        public static void GetPointer<T1>(OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T1[] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        [CLSCompliant(false)]
        public static void GetPointer<T1>(OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T1[,] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        [CLSCompliant(false)]
        public static void GetPointer<T1>(OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T1[,,] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        public static void GetPointer<T1>(OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] ref T1 @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        public static void GetPointer(OpenTK.Graphics.ES11.GetPointervPName pname, [OutAttribute] IntPtr @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        [CLSCompliant(false)]
        public static void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] T1[] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        [CLSCompliant(false)]
        public static void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] T1[,] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        [CLSCompliant(false)]
        public static void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] T1[,,] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        public static void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] ref T1 @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return a string describing the current GL connection
        /// </summary>
        /// <param name="name">
        /// <para>
        /// Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_SHADING_LANGUAGE_VERSION. Additionally, glGetStringi accepts the GL_EXTENSIONS token.
        /// </para>
        /// </param>
        /// <param name="index">
        /// <para>
        /// For glGetStringi, specifies the index of the string to return.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetString")]
        public static String GetString(OpenTK.Graphics.ES11.All name) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return a string describing the current GL connection
        /// </summary>
        /// <param name="name">
        /// <para>
        /// Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_SHADING_LANGUAGE_VERSION. Additionally, glGetStringi accepts the GL_EXTENSIONS token.
        /// </para>
        /// </param>
        /// <param name="index">
        /// <para>
        /// For glGetStringi, specifies the index of the string to return.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetString")]
        public static String GetString(OpenTK.Graphics.ES11.StringName name) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvxv")]
        [CLSCompliant(false)]
        public static void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvxv")]
        [CLSCompliant(false)]
        public static void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvxv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterxv")]
        [CLSCompliant(false)]
        public static void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterxv")]
        [CLSCompliant(false)]
        public static void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterxv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify implementation-specific hints
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a symbolic constant indicating the behavior to be controlled. GL_LINE_SMOOTH_HINT, GL_POLYGON_SMOOTH_HINT, GL_TEXTURE_COMPRESSION_HINT, and GL_FRAGMENT_SHADER_DERIVATIVE_HINT are accepted.
        /// </para>
        /// </param>
        /// <param name="mode">
        /// <para>
        /// Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glHint")]
        public static void Hint(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify implementation-specific hints
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a symbolic constant indicating the behavior to be controlled. GL_LINE_SMOOTH_HINT, GL_POLYGON_SMOOTH_HINT, GL_TEXTURE_COMPRESSION_HINT, and GL_FRAGMENT_SHADER_DERIVATIVE_HINT are accepted.
        /// </para>
        /// </param>
        /// <param name="mode">
        /// <para>
        /// Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glHint")]
        public static void Hint(OpenTK.Graphics.ES11.HintTarget target, OpenTK.Graphics.ES11.HintMode mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a buffer object
        /// </summary>
        /// <param name="buffer">
        /// <para>
        /// Specifies a value that may be the name of a buffer object.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsBuffer")]
        [CLSCompliant(false)]
        public static bool IsBuffer(Int32 buffer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a buffer object
        /// </summary>
        /// <param name="buffer">
        /// <para>
        /// Specifies a value that may be the name of a buffer object.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsBuffer")]
        [CLSCompliant(false)]
        public static bool IsBuffer(UInt32 buffer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Test whether a capability is enabled
        /// </summary>
        /// <param name="cap">
        /// <para>
        /// Specifies a symbolic constant indicating a GL capability.
        /// </para>
        /// </param>
        /// <param name="index">
        /// <para>
        /// Specifies the index of the capability.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsEnabled")]
        public static bool IsEnabled(OpenTK.Graphics.ES11.All cap) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Test whether a capability is enabled
        /// </summary>
        /// <param name="cap">
        /// <para>
        /// Specifies a symbolic constant indicating a GL capability.
        /// </para>
        /// </param>
        /// <param name="index">
        /// <para>
        /// Specifies the index of the capability.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsEnabled")]
        public static bool IsEnabled(OpenTK.Graphics.ES11.EnableCap cap) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a texture
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies a value that may be the name of a texture.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsTexture")]
        [CLSCompliant(false)]
        public static bool IsTexture(Int32 texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a texture
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies a value that may be the name of a texture.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsTexture")]
        [CLSCompliant(false)]
        public static bool IsTexture(UInt32 texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT , where i ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter pname of light source light will be set to.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightf")]
        public static void Light(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT , where i ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter pname of light source light will be set to.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightf")]
        public static void Light(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT , where i ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter pname of light source light will be set to.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightfv")]
        [CLSCompliant(false)]
        public static void Light(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT , where i ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter pname of light source light will be set to.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightfv")]
        [CLSCompliant(false)]
        public static unsafe void Light(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT , where i ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter pname of light source light will be set to.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightfv")]
        [CLSCompliant(false)]
        public static void Light(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT , where i ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter pname of light source light will be set to.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightfv")]
        [CLSCompliant(false)]
        public static unsafe void Light(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued lighting model parameter. GL_LIGHT_MODEL_LOCAL_VIEWER, GL_LIGHT_MODEL_COLOR_CONTROL, and GL_LIGHT_MODEL_TWO_SIDE are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that param will be set to.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelf")]
        public static void LightModel(OpenTK.Graphics.ES11.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued lighting model parameter. GL_LIGHT_MODEL_LOCAL_VIEWER, GL_LIGHT_MODEL_COLOR_CONTROL, and GL_LIGHT_MODEL_TWO_SIDE are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that param will be set to.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelf")]
        public static void LightModel(OpenTK.Graphics.ES11.LightModelParameter pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued lighting model parameter. GL_LIGHT_MODEL_LOCAL_VIEWER, GL_LIGHT_MODEL_COLOR_CONTROL, and GL_LIGHT_MODEL_TWO_SIDE are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that param will be set to.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelfv")]
        [CLSCompliant(false)]
        public static void LightModel(OpenTK.Graphics.ES11.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued lighting model parameter. GL_LIGHT_MODEL_LOCAL_VIEWER, GL_LIGHT_MODEL_COLOR_CONTROL, and GL_LIGHT_MODEL_TWO_SIDE are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that param will be set to.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelfv")]
        [CLSCompliant(false)]
        public static unsafe void LightModel(OpenTK.Graphics.ES11.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued lighting model parameter. GL_LIGHT_MODEL_LOCAL_VIEWER, GL_LIGHT_MODEL_COLOR_CONTROL, and GL_LIGHT_MODEL_TWO_SIDE are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that param will be set to.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelfv")]
        [CLSCompliant(false)]
        public static void LightModel(OpenTK.Graphics.ES11.LightModelParameter pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued lighting model parameter. GL_LIGHT_MODEL_LOCAL_VIEWER, GL_LIGHT_MODEL_COLOR_CONTROL, and GL_LIGHT_MODEL_TWO_SIDE are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that param will be set to.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelfv")]
        [CLSCompliant(false)]
        public static unsafe void LightModel(OpenTK.Graphics.ES11.LightModelParameter pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelx")]
        public static void LightModelx(OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelxv")]
        [CLSCompliant(false)]
        public static void LightModelx(OpenTK.Graphics.ES11.All pname, int[] param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelxv")]
        [CLSCompliant(false)]
        public static unsafe void LightModelx(OpenTK.Graphics.ES11.All pname, int* param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightx")]
        public static void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightxv")]
        [CLSCompliant(false)]
        public static void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightxv")]
        [CLSCompliant(false)]
        public static unsafe void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the width of rasterized lines
        /// </summary>
        /// <param name="width">
        /// <para>
        /// Specifies the width of rasterized lines. The initial value is 1.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLineWidth")]
        public static void LineWidth(Single width) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLineWidthx")]
        public static void LineWidthx(int width) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the identity matrix
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadIdentity")]
        public static void LoadIdentity() { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixf")]
        [CLSCompliant(false)]
        public static void LoadMatrix(Single[] m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixf")]
        [CLSCompliant(false)]
        public static void LoadMatrix(ref Single m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixf")]
        [CLSCompliant(false)]
        public static unsafe void LoadMatrix(Single* m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixx")]
        [CLSCompliant(false)]
        public static void LoadMatrixx(int[] m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixx")]
        [CLSCompliant(false)]
        public static void LoadMatrixx(ref int m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixx")]
        [CLSCompliant(false)]
        public static unsafe void LoadMatrixx(int* m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a logical pixel operation for rendering
        /// </summary>
        /// <param name="opcode">
        /// <para>
        /// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: GL_CLEAR, GL_SET, GL_COPY, GL_COPY_INVERTED, GL_NOOP, GL_INVERT, GL_AND, GL_NAND, GL_OR, GL_NOR, GL_XOR, GL_EQUIV, GL_AND_REVERSE, GL_AND_INVERTED, GL_OR_REVERSE, and GL_OR_INVERTED. The initial value is GL_COPY.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLogicOp")]
        public static void LogicOp(OpenTK.Graphics.ES11.All opcode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a logical pixel operation for rendering
        /// </summary>
        /// <param name="opcode">
        /// <para>
        /// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: GL_CLEAR, GL_SET, GL_COPY, GL_COPY_INVERTED, GL_NOOP, GL_INVERT, GL_AND, GL_NAND, GL_OR, GL_NOR, GL_XOR, GL_EQUIV, GL_AND_REVERSE, GL_AND_INVERTED, GL_OR_REVERSE, and GL_OR_INVERTED. The initial value is GL_COPY.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLogicOp")]
        public static void LogicOp(OpenTK.Graphics.ES11.LogicOp opcode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which face or faces are being updated. Must be one of GL_FRONT, GL_BACK, or GL_FRONT_AND_BACK.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter GL_SHININESS will be set to.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialf")]
        public static void Material(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which face or faces are being updated. Must be one of GL_FRONT, GL_BACK, or GL_FRONT_AND_BACK.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter GL_SHININESS will be set to.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialf")]
        public static void Material(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which face or faces are being updated. Must be one of GL_FRONT, GL_BACK, or GL_FRONT_AND_BACK.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter GL_SHININESS will be set to.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialfv")]
        [CLSCompliant(false)]
        public static void Material(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which face or faces are being updated. Must be one of GL_FRONT, GL_BACK, or GL_FRONT_AND_BACK.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter GL_SHININESS will be set to.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialfv")]
        [CLSCompliant(false)]
        public static unsafe void Material(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which face or faces are being updated. Must be one of GL_FRONT, GL_BACK, or GL_FRONT_AND_BACK.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter GL_SHININESS will be set to.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialfv")]
        [CLSCompliant(false)]
        public static void Material(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which face or faces are being updated. Must be one of GL_FRONT, GL_BACK, or GL_FRONT_AND_BACK.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter GL_SHININESS will be set to.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialfv")]
        [CLSCompliant(false)]
        public static unsafe void Material(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialx")]
        public static void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialxv")]
        [CLSCompliant(false)]
        public static void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int[] param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialxv")]
        [CLSCompliant(false)]
        public static unsafe void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify which matrix is the current matrix
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies which matrix stack is the target for subsequent matrix operations. Three values are accepted: GL_MODELVIEW, GL_PROJECTION, and GL_TEXTURE. The initial value is GL_MODELVIEW. Additionally, if the ARB_imaging extension is supported, GL_COLOR is also accepted.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMatrixMode")]
        public static void MatrixMode(OpenTK.Graphics.ES11.All mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify which matrix is the current matrix
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies which matrix stack is the target for subsequent matrix operations. Three values are accepted: GL_MODELVIEW, GL_PROJECTION, and GL_TEXTURE. The initial value is GL_MODELVIEW. Additionally, if the ARB_imaging extension is supported, GL_COLOR is also accepted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMatrixMode")]
        public static void MatrixMode(OpenTK.Graphics.ES11.MatrixMode mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </para>
        /// </param>
        /// <param name="s">
        /// <para>
        /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultiTexCoord4f")]
        public static void MultiTexCoord4(OpenTK.Graphics.ES11.All target, Single s, Single t, Single r, Single q) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </para>
        /// </param>
        /// <param name="s">
        /// <para>
        /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultiTexCoord4f")]
        public static void MultiTexCoord4(OpenTK.Graphics.ES11.TextureUnit target, Single s, Single t, Single r, Single q) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultiTexCoord4x")]
        public static void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Points to 16 consecutive values that are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixf")]
        [CLSCompliant(false)]
        public static void MultMatrix(Single[] m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Points to 16 consecutive values that are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixf")]
        [CLSCompliant(false)]
        public static void MultMatrix(ref Single m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Points to 16 consecutive values that are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixf")]
        [CLSCompliant(false)]
        public static unsafe void MultMatrix(Single* m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixx")]
        [CLSCompliant(false)]
        public static void MultMatrixx(int[] m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixx")]
        [CLSCompliant(false)]
        public static void MultMatrixx(ref int m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixx")]
        [CLSCompliant(false)]
        public static unsafe void MultMatrixx(int* m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the current normal vector
        /// </summary>
        /// <param name="nx">
        /// <para>
        /// Specify the , , and coordinates of the new current normal. The initial value of the current normal is the unit vector, (0, 0, 1).
        /// </para>
        /// <para>
        ///
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormal3f")]
        public static void Normal3(Single nx, Single ny, Single nz) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormal3x")]
        public static void Normal3x(int nx, int ny, int nz) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        public static void NormalPointer(OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        [CLSCompliant(false)]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[] pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        [CLSCompliant(false)]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,] pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        [CLSCompliant(false)]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,,] pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T2 pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        public static void NormalPointer(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        [CLSCompliant(false)]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[] pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        [CLSCompliant(false)]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[,] pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        [CLSCompliant(false)]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[,,] pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T2 pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with an orthographic matrix
        /// </summary>
        /// <param name="left">
        /// <para>
        /// Specify the coordinates for the left and right vertical clipping planes.
        /// </para>
        /// </param>
        /// <param name="bottom">
        /// <para>
        /// Specify the coordinates for the bottom and top horizontal clipping planes.
        /// </para>
        /// </param>
        /// <param name="nearVal">
        /// <para>
        /// Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glOrthof")]
        public static void Ortho(Single l, Single r, Single b, Single t, Single n, Single f) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glOrthox")]
        public static void Orthox(int l, int r, int b, int t, int n, int f) { throw new NotImplementedException(); }

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelMapx")]
        [CLSCompliant(false)]
        public static void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, int[] values) { throw new NotImplementedException(); }

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelMapx")]
        [CLSCompliant(false)]
        public static void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, ref int values) { throw new NotImplementedException(); }

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelMapx")]
        [CLSCompliant(false)]
        public static unsafe void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, int* values) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set pixel storage modes
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: GL_PACK_SWAP_BYTES, GL_PACK_LSB_FIRST, GL_PACK_ROW_LENGTH, GL_PACK_IMAGE_HEIGHT, GL_PACK_SKIP_PIXELS, GL_PACK_SKIP_ROWS, GL_PACK_SKIP_IMAGES, and GL_PACK_ALIGNMENT. Six more affect the unpacking of pixel data from memory: GL_UNPACK_SWAP_BYTES, GL_UNPACK_LSB_FIRST, GL_UNPACK_ROW_LENGTH, GL_UNPACK_IMAGE_HEIGHT, GL_UNPACK_SKIP_PIXELS, GL_UNPACK_SKIP_ROWS, GL_UNPACK_SKIP_IMAGES, and GL_UNPACK_ALIGNMENT.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that pname is set to.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPixelStorei")]
        public static void PixelStore(OpenTK.Graphics.ES11.All pname, Int32 param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set pixel storage modes
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: GL_PACK_SWAP_BYTES, GL_PACK_LSB_FIRST, GL_PACK_ROW_LENGTH, GL_PACK_IMAGE_HEIGHT, GL_PACK_SKIP_PIXELS, GL_PACK_SKIP_ROWS, GL_PACK_SKIP_IMAGES, and GL_PACK_ALIGNMENT. Six more affect the unpacking of pixel data from memory: GL_UNPACK_SWAP_BYTES, GL_UNPACK_LSB_FIRST, GL_UNPACK_ROW_LENGTH, GL_UNPACK_IMAGE_HEIGHT, GL_UNPACK_SKIP_PIXELS, GL_UNPACK_SKIP_ROWS, GL_UNPACK_SKIP_IMAGES, and GL_UNPACK_ALIGNMENT.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that pname is set to.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPixelStorei")]
        public static void PixelStore(OpenTK.Graphics.ES11.PixelStoreParameter pname, Int32 param) { throw new NotImplementedException(); }

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelStorex")]
        public static void PixelStorex(OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify point parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For glPointParameterfv and glPointParameteriv, specifies a pointer to an array where the value or values to be assigned to pname are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterf")]
        public static void PointParameter(OpenTK.Graphics.ES11.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify point parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For glPointParameterfv and glPointParameteriv, specifies a pointer to an array where the value or values to be assigned to pname are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterfv")]
        [CLSCompliant(false)]
        public static void PointParameter(OpenTK.Graphics.ES11.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify point parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For glPointParameterfv and glPointParameteriv, specifies a pointer to an array where the value or values to be assigned to pname are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterfv")]
        [CLSCompliant(false)]
        public static unsafe void PointParameter(OpenTK.Graphics.ES11.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterx")]
        public static void PointParameterx(OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterxv")]
        [CLSCompliant(false)]
        public static void PointParameterx(OpenTK.Graphics.ES11.All pname, int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterxv")]
        [CLSCompliant(false)]
        public static unsafe void PointParameterx(OpenTK.Graphics.ES11.All pname, int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the diameter of rasterized points
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the diameter of rasterized points. The initial value is 1.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointSize")]
        public static void PointSize(Single size) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointSizex")]
        public static void PointSizex(int size) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the scale and units used to calculate depth values
        /// </summary>
        /// <param name="factor">
        /// <para>
        /// Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="units">
        /// <para>
        /// Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPolygonOffset")]
        public static void PolygonOffset(Single factor, Single units) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPolygonOffsetx")]
        public static void PolygonOffsetx(int factor, int units) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPopMatrix")]
        public static void PopMatrix() { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Push and pop the current matrix stack
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPushMatrix")]
        public static void PushMatrix() { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        public static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [OutAttribute] IntPtr pixels) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        [CLSCompliant(false)]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T6[] pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        [CLSCompliant(false)]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T6[,] pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        [CLSCompliant(false)]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T6[,,] pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T6 pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        public static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [OutAttribute] IntPtr pixels) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        [CLSCompliant(false)]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T6[] pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        [CLSCompliant(false)]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T6[,] pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        [CLSCompliant(false)]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T6[,,] pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] ref T6 pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a rotation matrix
        /// </summary>
        /// <param name="angle">
        /// <para>
        /// Specifies the angle of rotation, in degrees.
        /// </para>
        /// </param>
        /// <param name="x">
        /// <para>
        /// Specify the x, y, and z coordinates of a vector, respectively.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glRotatef")]
        public static void Rotate(Single angle, Single x, Single y, Single z) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glRotatex")]
        public static void Rotatex(int angle, int x, int y, int z) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify multisample coverage parameters
        /// </summary>
        /// <param name="value">
        /// <para>
        /// Specify a single floating-point sample coverage value. The value is clamped to the range [0 ,1]. The initial value is 1.0.
        /// </para>
        /// </param>
        /// <param name="invert">
        /// <para>
        /// Specify a single boolean value representing if the coverage masks should be inverted. GL_TRUE and GL_FALSE are accepted. The initial value is GL_FALSE.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glSampleCoverage")]
        public static void SampleCoverage(Single value, bool invert) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glSampleCoveragex")]
        public static void SampleCoveragex(int value, bool invert) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a general scaling matrix
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify scale factors along the x, y, and z axes, respectively.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glScalef")]
        public static void Scale(Single x, Single y, Single z) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glScalex")]
        public static void Scalex(int x, int y, int z) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define the scissor box
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the lower left corner of the scissor box. Initially (0, 0).
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glScissor")]
        public static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Select flat or smooth shading
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies a symbolic value representing a shading technique. Accepted values are GL_FLAT and GL_SMOOTH. The initial value is GL_SMOOTH.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glShadeModel")]
        public static void ShadeModel(OpenTK.Graphics.ES11.All mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Select flat or smooth shading
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies a symbolic value representing a shading technique. Accepted values are GL_FLAT and GL_SMOOTH. The initial value is GL_SMOOTH.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glShadeModel")]
        public static void ShadeModel(OpenTK.Graphics.ES11.ShadingModel mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS.
        /// </para>
        /// </param>
        /// <param name="ref">
        /// <para>
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="mask">
        /// <para>
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilFunc")]
        [CLSCompliant(false)]
        public static void StencilFunc(OpenTK.Graphics.ES11.All func, Int32 @ref, Int32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS.
        /// </para>
        /// </param>
        /// <param name="ref">
        /// <para>
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="mask">
        /// <para>
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilFunc")]
        [CLSCompliant(false)]
        public static void StencilFunc(OpenTK.Graphics.ES11.All func, Int32 @ref, UInt32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS.
        /// </para>
        /// </param>
        /// <param name="ref">
        /// <para>
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="mask">
        /// <para>
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilFunc")]
        [CLSCompliant(false)]
        public static void StencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, Int32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS.
        /// </para>
        /// </param>
        /// <param name="ref">
        /// <para>
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="mask">
        /// <para>
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilFunc")]
        [CLSCompliant(false)]
        public static void StencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, UInt32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Control the front and back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilMask")]
        [CLSCompliant(false)]
        public static void StencilMask(Int32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Control the front and back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilMask")]
        [CLSCompliant(false)]
        public static void StencilMask(UInt32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set front and back stencil test actions
        /// </summary>
        /// <param name="sfail">
        /// <para>
        /// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR, GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP.
        /// </para>
        /// </param>
        /// <param name="dpfail">
        /// <para>
        /// Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is GL_KEEP.
        /// </para>
        /// </param>
        /// <param name="dppass">
        /// <para>
        /// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is GL_KEEP.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilOp")]
        public static void StencilOp(OpenTK.Graphics.ES11.All fail, OpenTK.Graphics.ES11.All zfail, OpenTK.Graphics.ES11.All zpass) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set front and back stencil test actions
        /// </summary>
        /// <param name="sfail">
        /// <para>
        /// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR, GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP.
        /// </para>
        /// </param>
        /// <param name="dpfail">
        /// <para>
        /// Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is GL_KEEP.
        /// </para>
        /// </param>
        /// <param name="dppass">
        /// <para>
        /// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is GL_KEEP.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilOp")]
        public static void StencilOp(OpenTK.Graphics.ES11.StencilOp fail, OpenTK.Graphics.ES11.StencilOp zfail, OpenTK.Graphics.ES11.StencilOp zpass) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        public static void TexCoordPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        [CLSCompliant(false)]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        [CLSCompliant(false)]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        [CLSCompliant(false)]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        public static void TexCoordPointer(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        [CLSCompliant(false)]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        [CLSCompliant(false)]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        [CLSCompliant(false)]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvf")]
        public static void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvf")]
        public static void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        [CLSCompliant(false)]
        public static void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        [CLSCompliant(false)]
        public static unsafe void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        [CLSCompliant(false)]
        public static void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        [CLSCompliant(false)]
        public static unsafe void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvi")]
        public static void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvi")]
        public static void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32 param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        [CLSCompliant(false)]
        public static void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        [CLSCompliant(false)]
        public static unsafe void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        [CLSCompliant(false)]
        public static void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        [CLSCompliant(false)]
        public static unsafe void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvx")]
        public static void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvxv")]
        [CLSCompliant(false)]
        public static void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvxv")]
        [CLSCompliant(false)]
        public static unsafe void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        public static void TexImage2D(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, IntPtr pixels) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        [CLSCompliant(false)]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        [CLSCompliant(false)]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        [CLSCompliant(false)]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        public static void TexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        [CLSCompliant(false)]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        [CLSCompliant(false)]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        [CLSCompliant(false)]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterf")]
        public static void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterf")]
        public static void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        [CLSCompliant(false)]
        public static void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        [CLSCompliant(false)]
        public static unsafe void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        [CLSCompliant(false)]
        public static void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        [CLSCompliant(false)]
        public static unsafe void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteri")]
        public static void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteri")]
        public static void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32 param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        [CLSCompliant(false)]
        public static void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        [CLSCompliant(false)]
        public static unsafe void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        [CLSCompliant(false)]
        public static void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        [CLSCompliant(false)]
        public static unsafe void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterx")]
        public static void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterxv")]
        [CLSCompliant(false)]
        public static void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterxv")]
        [CLSCompliant(false)]
        public static unsafe void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        public static void TexSubImage2D(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, IntPtr pixels) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        [CLSCompliant(false)]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        [CLSCompliant(false)]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        [CLSCompliant(false)]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        public static void TexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        [CLSCompliant(false)]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        [CLSCompliant(false)]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        [CLSCompliant(false)]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a translation matrix
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the x, y, and z coordinates of a translation vector.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTranslatef")]
        public static void Translate(Single x, Single y, Single z) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTranslatex")]
        public static void Translatex(int x, int y, int z) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        public static void VertexPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        [CLSCompliant(false)]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        [CLSCompliant(false)]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        [CLSCompliant(false)]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        public static void VertexPointer(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        [CLSCompliant(false)]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        [CLSCompliant(false)]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        [CLSCompliant(false)]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the viewport
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glViewport")]
        public static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height) { throw new NotImplementedException(); }

        public static partial class Ext
        {
            /// <summary>[requires: EXT_blend_minmax]
            /// Specify the equation used for both the RGB blend equation and the Alpha blend equation
            /// </summary>
            /// <param name="buf">
            /// <para>
            /// for glBlendEquationi, specifies the index of the draw buffer for which to set the blend equation.
            /// </para>
            /// </param>
            /// <param name="mode">
            /// <para>
            /// specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_blend_minmax", Version = "", EntryPoint = "glBlendEquationEXT")]
            public static void BlendEquation(OpenTK.Graphics.ES11.All mode) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_blend_minmax]
            /// Specify the equation used for both the RGB blend equation and the Alpha blend equation
            /// </summary>
            /// <param name="buf">
            /// <para>
            /// for glBlendEquationi, specifies the index of the draw buffer for which to set the blend equation.
            /// </para>
            /// </param>
            /// <param name="mode">
            /// <para>
            /// specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_blend_minmax", Version = "", EntryPoint = "glBlendEquationEXT")]
            public static void BlendEquation(OpenTK.Graphics.ES11.BlendEquationModeExt mode) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_discard_framebuffer]</summary>
            [AutoGenerated(Category = "EXT_discard_framebuffer", Version = "", EntryPoint = "glDiscardFramebufferEXT")]
            [CLSCompliant(false)]
            public static void DiscardFramebuffer(OpenTK.Graphics.ES11.All target, Int32 numAttachments, OpenTK.Graphics.ES11.All[] attachments) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_discard_framebuffer]</summary>
            [AutoGenerated(Category = "EXT_discard_framebuffer", Version = "", EntryPoint = "glDiscardFramebufferEXT")]
            [CLSCompliant(false)]
            public static void DiscardFramebuffer(OpenTK.Graphics.ES11.All target, Int32 numAttachments, ref OpenTK.Graphics.ES11.All attachments) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_discard_framebuffer]</summary>
            [AutoGenerated(Category = "EXT_discard_framebuffer", Version = "", EntryPoint = "glDiscardFramebufferEXT")]
            [CLSCompliant(false)]
            public static unsafe void DiscardFramebuffer(OpenTK.Graphics.ES11.All target, Int32 numAttachments, OpenTK.Graphics.ES11.All* attachments) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_map_buffer_range]
            /// Indicate modifications to a range of a mapped buffer
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the flush operation. target must be GL_ARRAY_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
            /// </para>
            /// </param>
            /// <param name="offset">
            /// <para>
            /// Specifies the start of the buffer subrange, in basic machine units.
            /// </para>
            /// </param>
            /// <param name="length">
            /// <para>
            /// Specifies the length of the buffer subrange, in basic machine units.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_map_buffer_range", Version = "", EntryPoint = "glFlushMappedBufferRangeEXT")]
            public static void FlushMappedBufferRange(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multisampled_render_to_texture]</summary>
            [AutoGenerated(Category = "EXT_multisampled_render_to_texture", Version = "", EntryPoint = "glFramebufferTexture2DMultisampleEXT")]
            [CLSCompliant(false)]
            public static void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, Int32 texture, Int32 level, Int32 samples) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multisampled_render_to_texture]</summary>
            [AutoGenerated(Category = "EXT_multisampled_render_to_texture", Version = "", EntryPoint = "glFramebufferTexture2DMultisampleEXT")]
            [CLSCompliant(false)]
            public static void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetGraphicsResetStatusEXT")]
            public static OpenTK.Graphics.ES11.All GetGraphicsResetStatus() { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            [CLSCompliant(false)]
            public static void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            [CLSCompliant(false)]
            public static void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            [CLSCompliant(false)]
            public static unsafe void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            [CLSCompliant(false)]
            public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            [CLSCompliant(false)]
            public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            [CLSCompliant(false)]
            public static unsafe void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            [CLSCompliant(false)]
            public static void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            [CLSCompliant(false)]
            public static void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            [CLSCompliant(false)]
            public static unsafe void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            [CLSCompliant(false)]
            public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            [CLSCompliant(false)]
            public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            [CLSCompliant(false)]
            public static unsafe void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_map_buffer_range]
            /// Map a section of a buffer object's data store
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies a binding to which the target buffer is bound.
            /// </para>
            /// </param>
            /// <param name="offset">
            /// <para>
            /// Specifies a the starting offset within the buffer of the range to be mapped.
            /// </para>
            /// </param>
            /// <param name="length">
            /// <para>
            /// Specifies a length of the range to be mapped.
            /// </para>
            /// </param>
            /// <param name="access">
            /// <para>
            /// Specifies a combination of access flags indicating the desired access to the range.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_map_buffer_range", Version = "", EntryPoint = "glMapBufferRangeEXT")]
            [CLSCompliant(false)]
            public static IntPtr MapBufferRange(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length, Int32 access) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_map_buffer_range]
            /// Map a section of a buffer object's data store
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies a binding to which the target buffer is bound.
            /// </para>
            /// </param>
            /// <param name="offset">
            /// <para>
            /// Specifies a the starting offset within the buffer of the range to be mapped.
            /// </para>
            /// </param>
            /// <param name="length">
            /// <para>
            /// Specifies a length of the range to be mapped.
            /// </para>
            /// </param>
            /// <param name="access">
            /// <para>
            /// Specifies a combination of access flags indicating the desired access to the range.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_map_buffer_range", Version = "", EntryPoint = "glMapBufferRangeEXT")]
            [CLSCompliant(false)]
            public static IntPtr MapBufferRange(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length, UInt32 access) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives from array data
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="first">
            /// <para>
            /// Points to an array of starting indices in the enabled arrays.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the number of indices to be rendered.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the first and count
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawArraysEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawArrays(OpenTK.Graphics.ES11.All mode, Int32[] first, Int32[] count, Int32 primcount) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives from array data
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="first">
            /// <para>
            /// Points to an array of starting indices in the enabled arrays.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the number of indices to be rendered.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the first and count
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawArraysEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawArrays(OpenTK.Graphics.ES11.All mode, ref Int32 first, ref Int32 count, Int32 primcount) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives from array data
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="first">
            /// <para>
            /// Points to an array of starting indices in the enabled arrays.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the number of indices to be rendered.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the first and count
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawArraysEXT")]
            [CLSCompliant(false)]
            public static unsafe void MultiDrawArrays(OpenTK.Graphics.ES11.All mode, Int32* first, Int32* count, Int32 primcount) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives from array data
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="first">
            /// <para>
            /// Points to an array of starting indices in the enabled arrays.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the number of indices to be rendered.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the first and count
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawArraysEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] first, Int32[] count, Int32 primcount) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives from array data
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="first">
            /// <para>
            /// Points to an array of starting indices in the enabled arrays.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the number of indices to be rendered.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the first and count
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawArraysEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 first, ref Int32 count, Int32 primcount) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives from array data
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="first">
            /// <para>
            /// Points to an array of starting indices in the enabled arrays.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the number of indices to be rendered.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the first and count
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawArraysEXT")]
            [CLSCompliant(false)]
            public static unsafe void MultiDrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static unsafe void MultiDrawElements(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [Obsolete("Use strongly-typed overload instead")]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static unsafe void MultiDrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            [CLSCompliant(false)]
            public static unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            public static void ReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [OutAttribute] IntPtr data) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            [CLSCompliant(false)]
            public static void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] T7[] data)
                where T7 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            [CLSCompliant(false)]
            public static void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] T7[,] data)
                where T7 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            [CLSCompliant(false)]
            public static void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] T7[,,] data)
                where T7 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            public static void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] ref T7 data)
                where T7 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_multisampled_render_to_texture]
            /// Establish data storage, format, dimensions and sample count of a renderbuffer object's image
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="samples">
            /// <para>
            /// Specifies the number of samples to be used for the renderbuffer object's storage.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the internal format to use for the renderbuffer object's image.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            /// <param name="height">
            /// <para>
            /// Specifies the height of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_multisampled_render_to_texture", Version = "", EntryPoint = "glRenderbufferStorageMultisampleEXT")]
            public static void RenderbufferStorageMultisample(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_texture_storage]
            /// Simultaneously specify storage for all levels of a one-dimensional texture
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specify the target of the operation. target must be either GL_TEXTURE_1D or GL_PROXY_TEXTURE_1D.
            /// </para>
            /// </param>
            /// <param name="levels">
            /// <para>
            /// Specify the number of texture levels.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the sized internal format to be used to store texture image data.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the texture, in texels.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTexStorage1DEXT")]
            public static void TexStorage1D(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_texture_storage]
            /// Simultaneously specify storage for all levels of a two-dimensional or one-dimensional array texture
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specify the target of the operation. target must be one of GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, or GL_PROXY_TEXTURE_CUBE_MAP.
            /// </para>
            /// </param>
            /// <param name="levels">
            /// <para>
            /// Specify the number of texture levels.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the sized internal format to be used to store texture image data.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the texture, in texels.
            /// </para>
            /// </param>
            /// <param name="height">
            /// <para>
            /// Specifies the height of the texture, in texels.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTexStorage2DEXT")]
            public static void TexStorage2D(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_texture_storage]
            /// Simultaneously specify storage for all levels of a three-dimensional, two-dimensional array or cube-map array texture
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specify the target of the operation. target must be one of GL_TEXTURE_3D, GL_PROXY_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_PROXY_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_ARRAY, or GL_PROXY_TEXTURE_CUBE_ARRAY.
            /// </para>
            /// </param>
            /// <param name="levels">
            /// <para>
            /// Specify the number of texture levels.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the sized internal format to be used to store texture image data.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the texture, in texels.
            /// </para>
            /// </param>
            /// <param name="height">
            /// <para>
            /// Specifies the height of the texture, in texels.
            /// </para>
            /// </param>
            /// <param name="depth">
            /// <para>
            /// Specifies the depth of the texture, in texels.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTexStorage3DEXT")]
            public static void TexStorage3D(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_texture_storage]</summary>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage1DEXT")]
            [CLSCompliant(false)]
            public static void TextureStorage1D(Int32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_texture_storage]</summary>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage1DEXT")]
            [CLSCompliant(false)]
            public static void TextureStorage1D(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_texture_storage]</summary>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage2DEXT")]
            [CLSCompliant(false)]
            public static void TextureStorage2D(Int32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_texture_storage]</summary>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage2DEXT")]
            [CLSCompliant(false)]
            public static void TextureStorage2D(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_texture_storage]</summary>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage3DEXT")]
            [CLSCompliant(false)]
            public static void TextureStorage3D(Int32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth) { throw new NotImplementedException(); }

            /// <summary>[requires: EXT_texture_storage]</summary>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage3DEXT")]
            [CLSCompliant(false)]
            public static void TextureStorage3D(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth) { throw new NotImplementedException(); }

        }

        public static partial class Img
        {
            /// <summary>[requires: IMG_user_clip_plane]
            /// Specify a plane against which all geometry is clipped
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "IMG_user_clip_plane", Version = "", EntryPoint = "glClipPlanefIMG")]
            [CLSCompliant(false)]
            public static void ClipPlane(OpenTK.Graphics.ES11.All p, Single[] eqn) { throw new NotImplementedException(); }

            /// <summary>[requires: IMG_user_clip_plane]
            /// Specify a plane against which all geometry is clipped
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "IMG_user_clip_plane", Version = "", EntryPoint = "glClipPlanefIMG")]
            [CLSCompliant(false)]
            public static void ClipPlane(OpenTK.Graphics.ES11.All p, ref Single eqn) { throw new NotImplementedException(); }

            /// <summary>[requires: IMG_user_clip_plane]
            /// Specify a plane against which all geometry is clipped
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "IMG_user_clip_plane", Version = "", EntryPoint = "glClipPlanefIMG")]
            [CLSCompliant(false)]
            public static unsafe void ClipPlane(OpenTK.Graphics.ES11.All p, Single* eqn) { throw new NotImplementedException(); }

            /// <summary>[requires: IMG_user_clip_plane]</summary>
            [AutoGenerated(Category = "IMG_user_clip_plane", Version = "", EntryPoint = "glClipPlanexIMG")]
            [CLSCompliant(false)]
            public static void ClipPlanex(OpenTK.Graphics.ES11.All p, int[] eqn) { throw new NotImplementedException(); }

            /// <summary>[requires: IMG_user_clip_plane]</summary>
            [AutoGenerated(Category = "IMG_user_clip_plane", Version = "", EntryPoint = "glClipPlanexIMG")]
            [CLSCompliant(false)]
            public static void ClipPlanex(OpenTK.Graphics.ES11.All p, ref int eqn) { throw new NotImplementedException(); }

            /// <summary>[requires: IMG_user_clip_plane]</summary>
            [AutoGenerated(Category = "IMG_user_clip_plane", Version = "", EntryPoint = "glClipPlanexIMG")]
            [CLSCompliant(false)]
            public static unsafe void ClipPlanex(OpenTK.Graphics.ES11.All p, int* eqn) { throw new NotImplementedException(); }

            /// <summary>[requires: IMG_multisampled_render_to_texture]</summary>
            [AutoGenerated(Category = "IMG_multisampled_render_to_texture", Version = "", EntryPoint = "glFramebufferTexture2DMultisampleIMG")]
            [CLSCompliant(false)]
            public static void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, Int32 texture, Int32 level, Int32 samples) { throw new NotImplementedException(); }

            /// <summary>[requires: IMG_multisampled_render_to_texture]</summary>
            [AutoGenerated(Category = "IMG_multisampled_render_to_texture", Version = "", EntryPoint = "glFramebufferTexture2DMultisampleIMG")]
            [CLSCompliant(false)]
            public static void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples) { throw new NotImplementedException(); }

            /// <summary>[requires: IMG_multisampled_render_to_texture]
            /// Establish data storage, format, dimensions and sample count of a renderbuffer object's image
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="samples">
            /// <para>
            /// Specifies the number of samples to be used for the renderbuffer object's storage.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the internal format to use for the renderbuffer object's image.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            /// <param name="height">
            /// <para>
            /// Specifies the height of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "IMG_multisampled_render_to_texture", Version = "", EntryPoint = "glRenderbufferStorageMultisampleIMG")]
            public static void RenderbufferStorageMultisample(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height) { throw new NotImplementedException(); }

        }

        public static partial class NV
        {
            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [CLSCompliant(false)]
            public static void DeleteFence(Int32 fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [CLSCompliant(false)]
            public static void DeleteFence(UInt32 fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [CLSCompliant(false)]
            public static void DeleteFences(Int32 n, Int32[] fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [CLSCompliant(false)]
            public static void DeleteFences(Int32 n, ref Int32 fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [CLSCompliant(false)]
            public static unsafe void DeleteFences(Int32 n, Int32* fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [CLSCompliant(false)]
            public static void DeleteFences(Int32 n, UInt32[] fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [CLSCompliant(false)]
            public static void DeleteFences(Int32 n, ref UInt32 fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [CLSCompliant(false)]
            public static unsafe void DeleteFences(Int32 n, UInt32* fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glFinishFenceNV")]
            [CLSCompliant(false)]
            public static void FinishFence(Int32 fence) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glFinishFenceNV")]
            [CLSCompliant(false)]
            public static void FinishFence(UInt32 fence) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [CLSCompliant(false)]
            public static Int32 GenFence() { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [CLSCompliant(false)]
            public static void GenFences(Int32 n, [OutAttribute] Int32[] fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [CLSCompliant(false)]
            public static void GenFences(Int32 n, [OutAttribute] out Int32 fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [CLSCompliant(false)]
            public static unsafe void GenFences(Int32 n, [OutAttribute] Int32* fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [CLSCompliant(false)]
            public static void GenFences(Int32 n, [OutAttribute] UInt32[] fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [CLSCompliant(false)]
            public static void GenFences(Int32 n, [OutAttribute] out UInt32 fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [CLSCompliant(false)]
            public static unsafe void GenFences(Int32 n, [OutAttribute] UInt32* fences) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            [CLSCompliant(false)]
            public static void GetFence(Int32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            [CLSCompliant(false)]
            public static void GetFence(Int32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            [CLSCompliant(false)]
            public static unsafe void GetFence(Int32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            [CLSCompliant(false)]
            public static void GetFence(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            [CLSCompliant(false)]
            public static void GetFence(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            [CLSCompliant(false)]
            public static unsafe void GetFence(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glIsFenceNV")]
            [CLSCompliant(false)]
            public static bool IsFence(Int32 fence) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glIsFenceNV")]
            [CLSCompliant(false)]
            public static bool IsFence(UInt32 fence) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glSetFenceNV")]
            [CLSCompliant(false)]
            public static void SetFence(Int32 fence, OpenTK.Graphics.ES11.All condition) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glSetFenceNV")]
            [CLSCompliant(false)]
            public static void SetFence(UInt32 fence, OpenTK.Graphics.ES11.All condition) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glTestFenceNV")]
            [CLSCompliant(false)]
            public static bool TestFence(Int32 fence) { throw new NotImplementedException(); }

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glTestFenceNV")]
            [CLSCompliant(false)]
            public static bool TestFence(UInt32 fence) { throw new NotImplementedException(); }

        }

        public static partial class Oes
        {
            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glAccumxOES")]
            public static void Accumx(OpenTK.Graphics.ES11.All op, int value) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glAlphaFuncxOES")]
            public static void AlphaFuncx(OpenTK.Graphics.ES11.All func, int @ref) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Bind a framebuffer to a framebuffer target
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the framebuffer target of the binding operation.
            /// </para>
            /// </param>
            /// <param name="framebuffer">
            /// <para>
            /// Specifies the name of the framebuffer object to bind.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glBindFramebufferOES")]
            [CLSCompliant(false)]
            public static void BindFramebuffer(OpenTK.Graphics.ES11.All target, Int32 framebuffer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Bind a framebuffer to a framebuffer target
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the framebuffer target of the binding operation.
            /// </para>
            /// </param>
            /// <param name="framebuffer">
            /// <para>
            /// Specifies the name of the framebuffer object to bind.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glBindFramebufferOES")]
            [CLSCompliant(false)]
            public static void BindFramebuffer(OpenTK.Graphics.ES11.All target, UInt32 framebuffer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Bind a renderbuffer to a renderbuffer target
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the renderbuffer target of the binding operation. target must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies the name of the renderbuffer object to bind.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glBindRenderbufferOES")]
            [CLSCompliant(false)]
            public static void BindRenderbuffer(OpenTK.Graphics.ES11.All target, Int32 renderbuffer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Bind a renderbuffer to a renderbuffer target
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the renderbuffer target of the binding operation. target must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies the name of the renderbuffer object to bind.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glBindRenderbufferOES")]
            [CLSCompliant(false)]
            public static void BindRenderbuffer(OpenTK.Graphics.ES11.All target, UInt32 renderbuffer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Bind a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies the name of the vertex array to bind.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glBindVertexArrayOES")]
            [CLSCompliant(false)]
            public static void BindVertexArray(Int32 array) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Bind a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies the name of the vertex array to bind.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glBindVertexArrayOES")]
            [CLSCompliant(false)]
            public static void BindVertexArray(UInt32 array) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glBitmapxOES")]
            [CLSCompliant(false)]
            public static void Bitmapx(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte[] bitmap) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glBitmapxOES")]
            [CLSCompliant(false)]
            public static void Bitmapx(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, ref Byte bitmap) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glBitmapxOES")]
            [CLSCompliant(false)]
            public static unsafe void Bitmapx(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte* bitmap) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glBlendColorxOES")]
            public static void BlendColorx(int red, int green, int blue, int alpha) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_blend_subtract]
            /// Specify the equation used for both the RGB blend equation and the Alpha blend equation
            /// </summary>
            /// <param name="buf">
            /// <para>
            /// for glBlendEquationi, specifies the index of the draw buffer for which to set the blend equation.
            /// </para>
            /// </param>
            /// <param name="mode">
            /// <para>
            /// specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_blend_subtract", Version = "", EntryPoint = "glBlendEquationOES")]
            public static void BlendEquation(OpenTK.Graphics.ES11.All mode) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_blend_equation_separate]
            /// Set the RGB blend equation and the alpha blend equation separately
            /// </summary>
            /// <param name="buf">
            /// <para>
            /// for glBlendEquationSeparatei, specifies the index of the draw buffer for which to set the blend equations.
            /// </para>
            /// </param>
            /// <param name="modeRGB">
            /// <para>
            /// specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.
            /// </para>
            /// </param>
            /// <param name="modeAlpha">
            /// <para>
            /// specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_blend_equation_separate", Version = "", EntryPoint = "glBlendEquationSeparateOES")]
            public static void BlendEquationSeparate(OpenTK.Graphics.ES11.All modeRGB, OpenTK.Graphics.ES11.All modeAlpha) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_blend_func_separate]
            /// Specify pixel arithmetic for RGB and alpha components separately
            /// </summary>
            /// <param name="buf">
            /// <para>
            /// For glBlendFuncSeparatei, specifies the index of the draw buffer for which to set the blend functions.
            /// </para>
            /// </param>
            /// <param name="srcRGB">
            /// <para>
            /// Specifies how the red, green, and blue blending factors are computed. The initial value is GL_ONE.
            /// </para>
            /// </param>
            /// <param name="dstRGB">
            /// <para>
            /// Specifies how the red, green, and blue destination blending factors are computed. The initial value is GL_ZERO.
            /// </para>
            /// </param>
            /// <param name="srcAlpha">
            /// <para>
            /// Specified how the alpha source blending factor is computed. The initial value is GL_ONE.
            /// </para>
            /// </param>
            /// <param name="dstAlpha">
            /// <para>
            /// Specified how the alpha destination blending factor is computed. The initial value is GL_ZERO.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_blend_func_separate", Version = "", EntryPoint = "glBlendFuncSeparateOES")]
            public static void BlendFuncSeparate(OpenTK.Graphics.ES11.All srcRGB, OpenTK.Graphics.ES11.All dstRGB, OpenTK.Graphics.ES11.All srcAlpha, OpenTK.Graphics.ES11.All dstAlpha) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Check the completeness status of a framebuffer
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specify the target of the framebuffer completeness check.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glCheckFramebufferStatusOES")]
            public static OpenTK.Graphics.ES11.All CheckFramebufferStatus(OpenTK.Graphics.ES11.All target) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClearAccumxOES")]
            public static void ClearAccumx(int red, int green, int blue, int alpha) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClearColorxOES")]
            public static void ClearColorx(int red, int green, int blue, int alpha) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_single_precision]
            /// Specify the clear value for the depth buffer
            /// </summary>
            /// <param name="depth">
            /// <para>
            /// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glClearDepthfOES")]
            public static void ClearDepth(Single depth) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClearDepthxOES")]
            public static void ClearDepthx(int depth) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_single_precision]
            /// Specify a plane against which all geometry is clipped
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glClipPlanefOES")]
            [CLSCompliant(false)]
            public static void ClipPlane(OpenTK.Graphics.ES11.All plane, Single[] equation) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_single_precision]
            /// Specify a plane against which all geometry is clipped
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glClipPlanefOES")]
            [CLSCompliant(false)]
            public static void ClipPlane(OpenTK.Graphics.ES11.All plane, ref Single equation) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_single_precision]
            /// Specify a plane against which all geometry is clipped
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glClipPlanefOES")]
            [CLSCompliant(false)]
            public static unsafe void ClipPlane(OpenTK.Graphics.ES11.All plane, Single* equation) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClipPlanexOES")]
            [CLSCompliant(false)]
            public static void ClipPlanex(OpenTK.Graphics.ES11.All plane, int[] equation) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClipPlanexOES")]
            [CLSCompliant(false)]
            public static void ClipPlanex(OpenTK.Graphics.ES11.All plane, ref int equation) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClipPlanexOES")]
            [CLSCompliant(false)]
            public static unsafe void ClipPlanex(OpenTK.Graphics.ES11.All plane, int* equation) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor3xOES")]
            public static void Color3x(int red, int green, int blue) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor3xvOES")]
            [CLSCompliant(false)]
            public static void Color3x(int[] components) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor3xvOES")]
            [CLSCompliant(false)]
            public static void Color3x(ref int components) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor3xvOES")]
            [CLSCompliant(false)]
            public static unsafe void Color3x(int* components) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor4xOES")]
            public static void Color4x(int red, int green, int blue, int alpha) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor4xvOES")]
            [CLSCompliant(false)]
            public static void Color4x(int[] components) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor4xvOES")]
            [CLSCompliant(false)]
            public static void Color4x(ref int components) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor4xvOES")]
            [CLSCompliant(false)]
            public static unsafe void Color4x(int* components) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glConvolutionParameterxOES")]
            public static void ConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glConvolutionParameterxvOES")]
            [CLSCompliant(false)]
            public static void ConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glConvolutionParameterxvOES")]
            [CLSCompliant(false)]
            public static unsafe void ConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glCurrentPaletteMatrixOES")]
            [CLSCompliant(false)]
            public static void CurrentPaletteMatrix(Int32 matrixpaletteindex) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glCurrentPaletteMatrixOES")]
            [CLSCompliant(false)]
            public static void CurrentPaletteMatrix(UInt32 matrixpaletteindex) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            [CLSCompliant(false)]
            public static void DeleteFramebuffer(Int32 framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            [CLSCompliant(false)]
            public static void DeleteFramebuffer(UInt32 framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete framebuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="framebuffers">
            /// <para>
            /// A pointer to an array containing n framebuffer objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            [CLSCompliant(false)]
            public static void DeleteFramebuffers(Int32 n, Int32[] framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete framebuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="framebuffers">
            /// <para>
            /// A pointer to an array containing n framebuffer objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            [CLSCompliant(false)]
            public static void DeleteFramebuffers(Int32 n, ref Int32 framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete framebuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="framebuffers">
            /// <para>
            /// A pointer to an array containing n framebuffer objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            [CLSCompliant(false)]
            public static unsafe void DeleteFramebuffers(Int32 n, Int32* framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete framebuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="framebuffers">
            /// <para>
            /// A pointer to an array containing n framebuffer objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            [CLSCompliant(false)]
            public static void DeleteFramebuffers(Int32 n, UInt32[] framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete framebuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="framebuffers">
            /// <para>
            /// A pointer to an array containing n framebuffer objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            [CLSCompliant(false)]
            public static void DeleteFramebuffers(Int32 n, ref UInt32 framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete framebuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="framebuffers">
            /// <para>
            /// A pointer to an array containing n framebuffer objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            [CLSCompliant(false)]
            public static unsafe void DeleteFramebuffers(Int32 n, UInt32* framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            [CLSCompliant(false)]
            public static void DeleteRenderbuffer(Int32 renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            [CLSCompliant(false)]
            public static void DeleteRenderbuffer(UInt32 renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete renderbuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// A pointer to an array containing n renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            [CLSCompliant(false)]
            public static void DeleteRenderbuffers(Int32 n, Int32[] renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete renderbuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// A pointer to an array containing n renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            [CLSCompliant(false)]
            public static void DeleteRenderbuffers(Int32 n, ref Int32 renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete renderbuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// A pointer to an array containing n renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            [CLSCompliant(false)]
            public static unsafe void DeleteRenderbuffers(Int32 n, Int32* renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete renderbuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// A pointer to an array containing n renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            [CLSCompliant(false)]
            public static void DeleteRenderbuffers(Int32 n, UInt32[] renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete renderbuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// A pointer to an array containing n renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            [CLSCompliant(false)]
            public static void DeleteRenderbuffers(Int32 n, ref UInt32 renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete renderbuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// A pointer to an array containing n renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            [CLSCompliant(false)]
            public static unsafe void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]</summary>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            [CLSCompliant(false)]
            public static void DeleteVertexArray(Int32 arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]</summary>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            [CLSCompliant(false)]
            public static void DeleteVertexArray(UInt32 arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Delete vertex array objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies the address of an array containing the n names of the objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            [CLSCompliant(false)]
            public static void DeleteVertexArrays(Int32 n, Int32[] arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Delete vertex array objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies the address of an array containing the n names of the objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            [CLSCompliant(false)]
            public static void DeleteVertexArrays(Int32 n, ref Int32 arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Delete vertex array objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies the address of an array containing the n names of the objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            [CLSCompliant(false)]
            public static unsafe void DeleteVertexArrays(Int32 n, Int32* arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Delete vertex array objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies the address of an array containing the n names of the objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            [CLSCompliant(false)]
            public static void DeleteVertexArrays(Int32 n, UInt32[] arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Delete vertex array objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies the address of an array containing the n names of the objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            [CLSCompliant(false)]
            public static void DeleteVertexArrays(Int32 n, ref UInt32 arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Delete vertex array objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies the address of an array containing the n names of the objects to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            [CLSCompliant(false)]
            public static unsafe void DeleteVertexArrays(Int32 n, UInt32* arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_single_precision]
            /// Specify mapping of depth values from normalized device coordinates to window coordinates
            /// </summary>
            /// <param name="nearVal">
            /// <para>
            /// Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.
            /// </para>
            /// </param>
            /// <param name="farVal">
            /// <para>
            /// Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glDepthRangefOES")]
            public static void DepthRange(Single n, Single f) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glDepthRangexOES")]
            public static void DepthRangex(int n, int f) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexfOES")]
            public static void DrawTex(Single x, Single y, Single z, Single width, Single height) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexfvOES")]
            [CLSCompliant(false)]
            public static void DrawTex(Single[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexfvOES")]
            [CLSCompliant(false)]
            public static void DrawTex(ref Single coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexfvOES")]
            [CLSCompliant(false)]
            public static unsafe void DrawTex(Single* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexiOES")]
            public static void DrawTex(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexivOES")]
            [CLSCompliant(false)]
            public static void DrawTex(Int32[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexivOES")]
            [CLSCompliant(false)]
            public static void DrawTex(ref Int32 coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexivOES")]
            [CLSCompliant(false)]
            public static unsafe void DrawTex(Int32* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexsOES")]
            public static void DrawTex(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexsvOES")]
            [CLSCompliant(false)]
            public static void DrawTex(Int16[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexsvOES")]
            [CLSCompliant(false)]
            public static void DrawTex(ref Int16 coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexsvOES")]
            [CLSCompliant(false)]
            public static unsafe void DrawTex(Int16* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexxOES")]
            public static void DrawTexx(int x, int y, int z, int width, int height) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexxvOES")]
            [CLSCompliant(false)]
            public static void DrawTexx(int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexxvOES")]
            [CLSCompliant(false)]
            public static void DrawTexx(ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexxvOES")]
            [CLSCompliant(false)]
            public static unsafe void DrawTexx(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_EGL_image]</summary>
            [AutoGenerated(Category = "OES_EGL_image", Version = "", EntryPoint = "glEGLImageTargetRenderbufferStorageOES")]
            public static void EGLImageTargetRenderbufferStorage(OpenTK.Graphics.ES11.All target, IntPtr image) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_EGL_image]</summary>
            [AutoGenerated(Category = "OES_EGL_image", Version = "", EntryPoint = "glEGLImageTargetTexture2DOES")]
            public static void EGLImageTargetTexture2D(OpenTK.Graphics.ES11.All target, IntPtr image) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord1xOES")]
            public static void EvalCoord1x(int u) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord1xvOES")]
            [CLSCompliant(false)]
            public static unsafe void EvalCoord1x(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord2xOES")]
            public static void EvalCoord2x(int u, int v) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord2xvOES")]
            [CLSCompliant(false)]
            public static void EvalCoord2x(int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord2xvOES")]
            [CLSCompliant(false)]
            public static void EvalCoord2x(ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord2xvOES")]
            [CLSCompliant(false)]
            public static unsafe void EvalCoord2x(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFeedbackBufferxOES")]
            [CLSCompliant(false)]
            public static void FeedbackBufferx(Int32 n, OpenTK.Graphics.ES11.All type, int[] buffer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFeedbackBufferxOES")]
            [CLSCompliant(false)]
            public static void FeedbackBufferx(Int32 n, OpenTK.Graphics.ES11.All type, ref int buffer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFeedbackBufferxOES")]
            [CLSCompliant(false)]
            public static unsafe void FeedbackBufferx(Int32 n, OpenTK.Graphics.ES11.All type, int* buffer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFogxOES")]
            public static void Fogx(OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFogxvOES")]
            [CLSCompliant(false)]
            public static void Fogx(OpenTK.Graphics.ES11.All pname, int[] param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFogxvOES")]
            [CLSCompliant(false)]
            public static unsafe void Fogx(OpenTK.Graphics.ES11.All pname, int* param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Attach a renderbuffer as a logical buffer to the currently bound framebuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER.
            /// </para>
            /// </param>
            /// <param name="attachment">
            /// <para>
            /// Specifies the attachment point of the framebuffer.
            /// </para>
            /// </param>
            /// <param name="renderbuffertarget">
            /// <para>
            /// Specifies the renderbuffer target and must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies the name of an existing renderbuffer object of type renderbuffertarget to attach.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glFramebufferRenderbufferOES")]
            [CLSCompliant(false)]
            public static void FramebufferRenderbuffer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All renderbuffertarget, Int32 renderbuffer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Attach a renderbuffer as a logical buffer to the currently bound framebuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER.
            /// </para>
            /// </param>
            /// <param name="attachment">
            /// <para>
            /// Specifies the attachment point of the framebuffer.
            /// </para>
            /// </param>
            /// <param name="renderbuffertarget">
            /// <para>
            /// Specifies the renderbuffer target and must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies the name of an existing renderbuffer object of type renderbuffertarget to attach.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glFramebufferRenderbufferOES")]
            [CLSCompliant(false)]
            public static void FramebufferRenderbuffer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All renderbuffertarget, UInt32 renderbuffer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glFramebufferTexture2DOES")]
            [CLSCompliant(false)]
            public static void FramebufferTexture2D(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, Int32 texture, Int32 level) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glFramebufferTexture2DOES")]
            [CLSCompliant(false)]
            public static void FramebufferTexture2D(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_single_precision]
            /// Multiply the current matrix by a perspective matrix
            /// </summary>
            /// <param name="left">
            /// <para>
            /// Specify the coordinates for the left and right vertical clipping planes.
            /// </para>
            /// </param>
            /// <param name="bottom">
            /// <para>
            /// Specify the coordinates for the bottom and top horizontal clipping planes.
            /// </para>
            /// </param>
            /// <param name="nearVal">
            /// <para>
            /// Specify the distances to the near and far depth clipping planes. Both distances must be positive.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glFrustumfOES")]
            public static void Frustum(Single l, Single r, Single b, Single t, Single n, Single f) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFrustumxOES")]
            public static void Frustumx(int l, int r, int b, int t, int n, int f) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate mipmaps for a specified texture target
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target to which the texture whose mimaps to generate is bound. target must be GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY or GL_TEXTURE_CUBE_MAP.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenerateMipmapOES")]
            public static void GenerateMipmap(OpenTK.Graphics.ES11.All target) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenFramebuffersOES")]
            [CLSCompliant(false)]
            public static Int32 GenFramebuffer() { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate framebuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="ids">
            /// <para>
            /// Specifies an array in which the generated framebuffer object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenFramebuffersOES")]
            [CLSCompliant(false)]
            public static void GenFramebuffers(Int32 n, [OutAttribute] Int32[] framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate framebuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="ids">
            /// <para>
            /// Specifies an array in which the generated framebuffer object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenFramebuffersOES")]
            [CLSCompliant(false)]
            public static void GenFramebuffers(Int32 n, [OutAttribute] out Int32 framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate framebuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="ids">
            /// <para>
            /// Specifies an array in which the generated framebuffer object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenFramebuffersOES")]
            [CLSCompliant(false)]
            public static unsafe void GenFramebuffers(Int32 n, [OutAttribute] Int32* framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate framebuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="ids">
            /// <para>
            /// Specifies an array in which the generated framebuffer object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenFramebuffersOES")]
            [CLSCompliant(false)]
            public static void GenFramebuffers(Int32 n, [OutAttribute] UInt32[] framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate framebuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="ids">
            /// <para>
            /// Specifies an array in which the generated framebuffer object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenFramebuffersOES")]
            [CLSCompliant(false)]
            public static void GenFramebuffers(Int32 n, [OutAttribute] out UInt32 framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate framebuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="ids">
            /// <para>
            /// Specifies an array in which the generated framebuffer object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenFramebuffersOES")]
            [CLSCompliant(false)]
            public static unsafe void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenRenderbuffersOES")]
            [CLSCompliant(false)]
            public static Int32 GenRenderbuffer() { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate renderbuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// Specifies an array in which the generated renderbuffer object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenRenderbuffersOES")]
            [CLSCompliant(false)]
            public static void GenRenderbuffers(Int32 n, [OutAttribute] Int32[] renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate renderbuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// Specifies an array in which the generated renderbuffer object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenRenderbuffersOES")]
            [CLSCompliant(false)]
            public static void GenRenderbuffers(Int32 n, [OutAttribute] out Int32 renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate renderbuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// Specifies an array in which the generated renderbuffer object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenRenderbuffersOES")]
            [CLSCompliant(false)]
            public static unsafe void GenRenderbuffers(Int32 n, [OutAttribute] Int32* renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate renderbuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// Specifies an array in which the generated renderbuffer object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenRenderbuffersOES")]
            [CLSCompliant(false)]
            public static void GenRenderbuffers(Int32 n, [OutAttribute] UInt32[] renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate renderbuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// Specifies an array in which the generated renderbuffer object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenRenderbuffersOES")]
            [CLSCompliant(false)]
            public static void GenRenderbuffers(Int32 n, [OutAttribute] out UInt32 renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate renderbuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// Specifies an array in which the generated renderbuffer object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenRenderbuffersOES")]
            [CLSCompliant(false)]
            public static unsafe void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]</summary>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glGenVertexArraysOES")]
            [CLSCompliant(false)]
            public static Int32 GenVertexArray() { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Generate vertex array object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array object names to generate.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies an array in which the generated vertex array object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glGenVertexArraysOES")]
            [CLSCompliant(false)]
            public static void GenVertexArrays(Int32 n, [OutAttribute] Int32[] arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Generate vertex array object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array object names to generate.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies an array in which the generated vertex array object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glGenVertexArraysOES")]
            [CLSCompliant(false)]
            public static void GenVertexArrays(Int32 n, [OutAttribute] out Int32 arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Generate vertex array object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array object names to generate.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies an array in which the generated vertex array object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glGenVertexArraysOES")]
            [CLSCompliant(false)]
            public static unsafe void GenVertexArrays(Int32 n, [OutAttribute] Int32* arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Generate vertex array object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array object names to generate.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies an array in which the generated vertex array object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glGenVertexArraysOES")]
            [CLSCompliant(false)]
            public static void GenVertexArrays(Int32 n, [OutAttribute] UInt32[] arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Generate vertex array object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array object names to generate.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies an array in which the generated vertex array object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glGenVertexArraysOES")]
            [CLSCompliant(false)]
            public static void GenVertexArrays(Int32 n, [OutAttribute] out UInt32 arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Generate vertex array object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array object names to generate.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies an array in which the generated vertex array object names are stored.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glGenVertexArraysOES")]
            [CLSCompliant(false)]
            public static unsafe void GenVertexArrays(Int32 n, [OutAttribute] UInt32* arrays) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            public static void GetBufferPointer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] IntPtr @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            [CLSCompliant(false)]
            public static void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T2[] @params)
                where T2 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            [CLSCompliant(false)]
            public static void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T2[,] @params)
                where T2 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            [CLSCompliant(false)]
            public static void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T2[,,] @params)
                where T2 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            public static void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] ref T2 @params)
                where T2 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_single_precision]
            /// Return the coefficients of the specified clipping plane
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glGetClipPlanefOES")]
            [CLSCompliant(false)]
            public static void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single[] equation) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_single_precision]
            /// Return the coefficients of the specified clipping plane
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glGetClipPlanefOES")]
            [CLSCompliant(false)]
            public static void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] out Single equation) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_single_precision]
            /// Return the coefficients of the specified clipping plane
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glGetClipPlanefOES")]
            [CLSCompliant(false)]
            public static unsafe void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetClipPlanexOES")]
            [CLSCompliant(false)]
            public static void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int[] equation) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetClipPlanexOES")]
            [CLSCompliant(false)]
            public static void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] out int equation) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetClipPlanexOES")]
            [CLSCompliant(false)]
            public static unsafe void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetConvolutionParameterxvOES")]
            [CLSCompliant(false)]
            public static void GetConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetConvolutionParameterxvOES")]
            [CLSCompliant(false)]
            public static void GetConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetConvolutionParameterxvOES")]
            [CLSCompliant(false)]
            public static unsafe void GetConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetFixedvOES")]
            [CLSCompliant(false)]
            public static int GetFixed(OpenTK.Graphics.ES11.All pname) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetFixedvOES")]
            [CLSCompliant(false)]
            public static void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetFixedvOES")]
            [CLSCompliant(false)]
            public static void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetFixedvOES")]
            [CLSCompliant(false)]
            public static unsafe void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Retrieve information about attachments of a bound framebuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the query operation.
            /// </para>
            /// </param>
            /// <param name="attachment">
            /// <para>
            /// Specifies the attachment within target
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter of attachment to query.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Specifies the address of a variable receive the value of pname for attachment.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGetFramebufferAttachmentParameterivOES")]
            [CLSCompliant(false)]
            public static void GetFramebufferAttachmentParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Retrieve information about attachments of a bound framebuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the query operation.
            /// </para>
            /// </param>
            /// <param name="attachment">
            /// <para>
            /// Specifies the attachment within target
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter of attachment to query.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Specifies the address of a variable receive the value of pname for attachment.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGetFramebufferAttachmentParameterivOES")]
            [CLSCompliant(false)]
            public static void GetFramebufferAttachmentParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Retrieve information about attachments of a bound framebuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the query operation.
            /// </para>
            /// </param>
            /// <param name="attachment">
            /// <para>
            /// Specifies the attachment within target
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter of attachment to query.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Specifies the address of a variable receive the value of pname for attachment.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGetFramebufferAttachmentParameterivOES")]
            [CLSCompliant(false)]
            public static unsafe void GetFramebufferAttachmentParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetHistogramParameterxvOES")]
            [CLSCompliant(false)]
            public static void GetHistogramParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetHistogramParameterxvOES")]
            [CLSCompliant(false)]
            public static void GetHistogramParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetHistogramParameterxvOES")]
            [CLSCompliant(false)]
            public static unsafe void GetHistogramParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetLightxOES")]
            [CLSCompliant(false)]
            public static void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetLightxOES")]
            [CLSCompliant(false)]
            public static void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetLightxOES")]
            [CLSCompliant(false)]
            public static unsafe void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMapxvOES")]
            [CLSCompliant(false)]
            public static void GetMapx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] int[] v) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMapxvOES")]
            [CLSCompliant(false)]
            public static void GetMapx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] out int v) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMapxvOES")]
            [CLSCompliant(false)]
            public static unsafe void GetMapx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] int* v) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMaterialxOES")]
            public static void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMaterialxvOES")]
            [CLSCompliant(false)]
            public static void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMaterialxvOES")]
            [CLSCompliant(false)]
            public static unsafe void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Retrieve information about a bound renderbuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the query operation. target must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter whose value to retrieve from the renderbuffer bound to target.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Specifies the address of an array to receive the value of the queried parameter.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGetRenderbufferParameterivOES")]
            [CLSCompliant(false)]
            public static void GetRenderbufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Retrieve information about a bound renderbuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the query operation. target must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter whose value to retrieve from the renderbuffer bound to target.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Specifies the address of an array to receive the value of the queried parameter.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGetRenderbufferParameterivOES")]
            [CLSCompliant(false)]
            public static void GetRenderbufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Retrieve information about a bound renderbuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the query operation. target must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter whose value to retrieve from the renderbuffer bound to target.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Specifies the address of an array to receive the value of the queried parameter.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGetRenderbufferParameterivOES")]
            [CLSCompliant(false)]
            public static unsafe void GetRenderbufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexEnvxvOES")]
            [CLSCompliant(false)]
            public static void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexEnvxvOES")]
            [CLSCompliant(false)]
            public static void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexEnvxvOES")]
            [CLSCompliant(false)]
            public static unsafe void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_texture_cube_map]
            /// Return texture coordinate generation parameters
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the value(s) to be returned. Must be either GL_TEXTURE_GEN_MODE or the name of one of the texture generation plane equations: GL_OBJECT_PLANE or GL_EYE_PLANE.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Returns the requested data.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenfvOES")]
            [CLSCompliant(false)]
            public static void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_texture_cube_map]
            /// Return texture coordinate generation parameters
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the value(s) to be returned. Must be either GL_TEXTURE_GEN_MODE or the name of one of the texture generation plane equations: GL_OBJECT_PLANE or GL_EYE_PLANE.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Returns the requested data.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenfvOES")]
            [CLSCompliant(false)]
            public static void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_texture_cube_map]
            /// Return texture coordinate generation parameters
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the value(s) to be returned. Must be either GL_TEXTURE_GEN_MODE or the name of one of the texture generation plane equations: GL_OBJECT_PLANE or GL_EYE_PLANE.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Returns the requested data.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenfvOES")]
            [CLSCompliant(false)]
            public static unsafe void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_texture_cube_map]
            /// Return texture coordinate generation parameters
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the value(s) to be returned. Must be either GL_TEXTURE_GEN_MODE or the name of one of the texture generation plane equations: GL_OBJECT_PLANE or GL_EYE_PLANE.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Returns the requested data.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenivOES")]
            [CLSCompliant(false)]
            public static void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_texture_cube_map]
            /// Return texture coordinate generation parameters
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the value(s) to be returned. Must be either GL_TEXTURE_GEN_MODE or the name of one of the texture generation plane equations: GL_OBJECT_PLANE or GL_EYE_PLANE.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Returns the requested data.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenivOES")]
            [CLSCompliant(false)]
            public static void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_texture_cube_map]
            /// Return texture coordinate generation parameters
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the value(s) to be returned. Must be either GL_TEXTURE_GEN_MODE or the name of one of the texture generation plane equations: GL_OBJECT_PLANE or GL_EYE_PLANE.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Returns the requested data.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenivOES")]
            [CLSCompliant(false)]
            public static unsafe void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenxvOES")]
            [CLSCompliant(false)]
            public static void GetTexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenxvOES")]
            [CLSCompliant(false)]
            public static void GetTexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenxvOES")]
            [CLSCompliant(false)]
            public static unsafe void GetTexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexLevelParameterxvOES")]
            [CLSCompliant(false)]
            public static void GetTexLevelParameterx(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexLevelParameterxvOES")]
            [CLSCompliant(false)]
            public static void GetTexLevelParameterx(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexLevelParameterxvOES")]
            [CLSCompliant(false)]
            public static unsafe void GetTexLevelParameterx(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexParameterxvOES")]
            [CLSCompliant(false)]
            public static void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexParameterxvOES")]
            [CLSCompliant(false)]
            public static void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexParameterxvOES")]
            [CLSCompliant(false)]
            public static unsafe void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glIndexxOES")]
            public static void Indexx(int component) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glIndexxvOES")]
            [CLSCompliant(false)]
            public static unsafe void Indexx(int* component) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a framebuffer object
            /// </summary>
            /// <param name="framebuffer">
            /// <para>
            /// Specifies a value that may be the name of a framebuffer object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glIsFramebufferOES")]
            [CLSCompliant(false)]
            public static bool IsFramebuffer(Int32 framebuffer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a framebuffer object
            /// </summary>
            /// <param name="framebuffer">
            /// <para>
            /// Specifies a value that may be the name of a framebuffer object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glIsFramebufferOES")]
            [CLSCompliant(false)]
            public static bool IsFramebuffer(UInt32 framebuffer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a renderbuffer object
            /// </summary>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies a value that may be the name of a renderbuffer object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glIsRenderbufferOES")]
            [CLSCompliant(false)]
            public static bool IsRenderbuffer(Int32 renderbuffer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a renderbuffer object
            /// </summary>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies a value that may be the name of a renderbuffer object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glIsRenderbufferOES")]
            [CLSCompliant(false)]
            public static bool IsRenderbuffer(UInt32 renderbuffer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Determine if a name corresponds to a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies a value that may be the name of a vertex array object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glIsVertexArrayOES")]
            [CLSCompliant(false)]
            public static bool IsVertexArray(Int32 array) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_vertex_array_object]
            /// Determine if a name corresponds to a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies a value that may be the name of a vertex array object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glIsVertexArrayOES")]
            [CLSCompliant(false)]
            public static bool IsVertexArray(UInt32 array) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightModelxOES")]
            public static void LightModelx(OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightModelxvOES")]
            [CLSCompliant(false)]
            public static void LightModelx(OpenTK.Graphics.ES11.All pname, int[] param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightModelxvOES")]
            [CLSCompliant(false)]
            public static unsafe void LightModelx(OpenTK.Graphics.ES11.All pname, int* param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightxOES")]
            public static void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightxvOES")]
            [CLSCompliant(false)]
            public static void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightxvOES")]
            [CLSCompliant(false)]
            public static unsafe void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLineWidthxOES")]
            public static void LineWidthx(int width) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadMatrixxOES")]
            [CLSCompliant(false)]
            public static void LoadMatrixx(int[] m) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadMatrixxOES")]
            [CLSCompliant(false)]
            public static void LoadMatrixx(ref int m) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadMatrixxOES")]
            [CLSCompliant(false)]
            public static unsafe void LoadMatrixx(int* m) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glLoadPaletteFromModelViewMatrixOES")]
            public static void LoadPaletteFromModelViewMatrix() { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadTransposeMatrixxOES")]
            [CLSCompliant(false)]
            public static void LoadTransposeMatrixx(int[] m) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadTransposeMatrixxOES")]
            [CLSCompliant(false)]
            public static void LoadTransposeMatrixx(ref int m) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadTransposeMatrixxOES")]
            [CLSCompliant(false)]
            public static unsafe void LoadTransposeMatrixx(int* m) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMap1xOES")]
            public static void Map1x(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 stride, Int32 order, int points) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMap2xOES")]
            public static void Map2x(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 ustride, Int32 uorder, int v1, int v2, Int32 vstride, Int32 vorder, int points) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_mapbuffer]
            /// Map a buffer object's data store
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target buffer object being mapped. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER or GL_UNIFORM_BUFFER.
            /// </para>
            /// </param>
            /// <param name="access">
            /// <para>
            /// For glMapBuffer only, specifies the access policy, indicating whether it will be possible to read from, write to, or both read from and write to the buffer object's mapped data store. The symbolic constant must be GL_READ_ONLY, GL_WRITE_ONLY, or GL_READ_WRITE.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glMapBufferOES")]
            public static IntPtr MapBuffer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All access) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMapGrid1xOES")]
            public static void MapGrid1x(Int32 n, int u1, int u2) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMapGrid2xOES")]
            public static void MapGrid2x(Int32 n, int u1, int u2, int v1, int v2) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMaterialxOES")]
            public static void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMaterialxvOES")]
            [CLSCompliant(false)]
            public static void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int[] param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMaterialxvOES")]
            [CLSCompliant(false)]
            public static unsafe void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            public static void MatrixIndexPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            [CLSCompliant(false)]
            public static void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            [CLSCompliant(false)]
            public static void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            [CLSCompliant(false)]
            public static void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            public static void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord1bOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, Byte s) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord1bOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, SByte s) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord1bvOES")]
            [CLSCompliant(false)]
            public static unsafe void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, Byte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord1bvOES")]
            [CLSCompliant(false)]
            public static unsafe void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, SByte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord1xOES")]
            public static void MultiTexCoord1x(OpenTK.Graphics.ES11.All texture, int s) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord1xvOES")]
            [CLSCompliant(false)]
            public static unsafe void MultiTexCoord1x(OpenTK.Graphics.ES11.All texture, int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, Byte s, Byte t) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, SByte s, SByte t) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, Byte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, ref Byte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            [CLSCompliant(false)]
            public static unsafe void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, Byte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, SByte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, ref SByte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            [CLSCompliant(false)]
            public static unsafe void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, SByte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord2xOES")]
            public static void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, int s, int t) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord2xvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord2xvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord2xvOES")]
            [CLSCompliant(false)]
            public static unsafe void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, Byte s, Byte t, Byte r) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, Byte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, ref Byte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            [CLSCompliant(false)]
            public static unsafe void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, Byte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, SByte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, ref SByte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            [CLSCompliant(false)]
            public static unsafe void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, SByte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord3xOES")]
            public static void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, int s, int t, int r) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord3xvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord3xvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord3xvOES")]
            [CLSCompliant(false)]
            public static unsafe void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, Byte s, Byte t, Byte r, Byte q) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r, SByte q) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, Byte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, ref Byte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            [CLSCompliant(false)]
            public static unsafe void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, Byte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, SByte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, ref SByte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            [CLSCompliant(false)]
            public static unsafe void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, SByte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord4xOES")]
            public static void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord4xvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord4xvOES")]
            [CLSCompliant(false)]
            public static void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord4xvOES")]
            [CLSCompliant(false)]
            public static unsafe void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultMatrixxOES")]
            [CLSCompliant(false)]
            public static void MultMatrixx(int[] m) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultMatrixxOES")]
            [CLSCompliant(false)]
            public static void MultMatrixx(ref int m) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultMatrixxOES")]
            [CLSCompliant(false)]
            public static unsafe void MultMatrixx(int* m) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultTransposeMatrixxOES")]
            [CLSCompliant(false)]
            public static void MultTransposeMatrixx(int[] m) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultTransposeMatrixxOES")]
            [CLSCompliant(false)]
            public static void MultTransposeMatrixx(ref int m) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultTransposeMatrixxOES")]
            [CLSCompliant(false)]
            public static unsafe void MultTransposeMatrixx(int* m) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glNormal3xOES")]
            public static void Normal3x(int nx, int ny, int nz) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glNormal3xvOES")]
            [CLSCompliant(false)]
            public static void Normal3x(int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glNormal3xvOES")]
            [CLSCompliant(false)]
            public static void Normal3x(ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glNormal3xvOES")]
            [CLSCompliant(false)]
            public static unsafe void Normal3x(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_single_precision]
            /// Multiply the current matrix with an orthographic matrix
            /// </summary>
            /// <param name="left">
            /// <para>
            /// Specify the coordinates for the left and right vertical clipping planes.
            /// </para>
            /// </param>
            /// <param name="bottom">
            /// <para>
            /// Specify the coordinates for the bottom and top horizontal clipping planes.
            /// </para>
            /// </param>
            /// <param name="nearVal">
            /// <para>
            /// Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glOrthofOES")]
            public static void Ortho(Single l, Single r, Single b, Single t, Single n, Single f) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glOrthoxOES")]
            public static void Orthox(int l, int r, int b, int t, int n, int f) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPassThroughxOES")]
            public static void PassThroughx(int token) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelTransferxOES")]
            public static void PixelTransferx(OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelZoomxOES")]
            public static void PixelZoomx(int xfactor, int yfactor) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPointParameterxOES")]
            public static void PointParameterx(OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPointParameterxvOES")]
            [CLSCompliant(false)]
            public static void PointParameterx(OpenTK.Graphics.ES11.All pname, int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPointParameterxvOES")]
            [CLSCompliant(false)]
            public static unsafe void PointParameterx(OpenTK.Graphics.ES11.All pname, int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            public static void PointSizePointer(OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            [CLSCompliant(false)]
            public static void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[] pointer)
                where T2 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            [CLSCompliant(false)]
            public static void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,] pointer)
                where T2 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            [CLSCompliant(false)]
            public static void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,,] pointer)
                where T2 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            public static void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T2 pointer)
                where T2 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPointSizexOES")]
            public static void PointSizex(int size) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPolygonOffsetxOES")]
            public static void PolygonOffsetx(int factor, int units) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            [CLSCompliant(false)]
            public static void PrioritizeTexturesx(Int32 n, Int32[] textures, int[] priorities) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            [CLSCompliant(false)]
            public static void PrioritizeTexturesx(Int32 n, ref Int32 textures, ref int priorities) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            [CLSCompliant(false)]
            public static unsafe void PrioritizeTexturesx(Int32 n, Int32* textures, int* priorities) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            [CLSCompliant(false)]
            public static void PrioritizeTexturesx(Int32 n, UInt32[] textures, int[] priorities) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            [CLSCompliant(false)]
            public static void PrioritizeTexturesx(Int32 n, ref UInt32 textures, ref int priorities) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            [CLSCompliant(false)]
            public static unsafe void PrioritizeTexturesx(Int32 n, UInt32* textures, int* priorities) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_query_matrix]</summary>
            [AutoGenerated(Category = "OES_query_matrix", Version = "", EntryPoint = "glQueryMatrixxOES")]
            [CLSCompliant(false)]
            public static Int32 QueryMatrixx([OutAttribute] int[] mantissa, [OutAttribute] Int32[] exponent) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_query_matrix]</summary>
            [AutoGenerated(Category = "OES_query_matrix", Version = "", EntryPoint = "glQueryMatrixxOES")]
            [CLSCompliant(false)]
            public static Int32 QueryMatrixx([OutAttribute] out int mantissa, [OutAttribute] out Int32 exponent) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_query_matrix]</summary>
            [AutoGenerated(Category = "OES_query_matrix", Version = "", EntryPoint = "glQueryMatrixxOES")]
            [CLSCompliant(false)]
            public static unsafe Int32 QueryMatrixx([OutAttribute] int* mantissa, [OutAttribute] Int32* exponent) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos2xOES")]
            public static void RasterPos2x(int x, int y) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos2xvOES")]
            [CLSCompliant(false)]
            public static void RasterPos2x(int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos2xvOES")]
            [CLSCompliant(false)]
            public static void RasterPos2x(ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos2xvOES")]
            [CLSCompliant(false)]
            public static unsafe void RasterPos2x(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos3xOES")]
            public static void RasterPos3x(int x, int y, int z) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos3xvOES")]
            [CLSCompliant(false)]
            public static void RasterPos3x(int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos3xvOES")]
            [CLSCompliant(false)]
            public static void RasterPos3x(ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos3xvOES")]
            [CLSCompliant(false)]
            public static unsafe void RasterPos3x(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos4xOES")]
            public static void RasterPos4x(int x, int y, int z, int w) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos4xvOES")]
            [CLSCompliant(false)]
            public static void RasterPos4x(int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos4xvOES")]
            [CLSCompliant(false)]
            public static void RasterPos4x(ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos4xvOES")]
            [CLSCompliant(false)]
            public static unsafe void RasterPos4x(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRectxOES")]
            public static void Rectx(int x1, int y1, int x2, int y2) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRectxvOES")]
            [CLSCompliant(false)]
            public static void Rectx(int[] v1, int[] v2) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRectxvOES")]
            [CLSCompliant(false)]
            public static void Rectx(ref int v1, ref int v2) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRectxvOES")]
            [CLSCompliant(false)]
            public static unsafe void Rectx(int* v1, int* v2) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_framebuffer_object]
            /// Establish data storage, format and dimensions of a renderbuffer object's image
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the internal format to use for the renderbuffer object's image.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            /// <param name="height">
            /// <para>
            /// Specifies the height of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glRenderbufferStorageOES")]
            public static void RenderbufferStorage(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRotatexOES")]
            public static void Rotatex(int angle, int x, int y, int z) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]
            /// Specify multisample coverage parameters
            /// </summary>
            /// <param name="value">
            /// <para>
            /// Specify a single floating-point sample coverage value. The value is clamped to the range [0 ,1]. The initial value is 1.0.
            /// </para>
            /// </param>
            /// <param name="invert">
            /// <para>
            /// Specify a single boolean value representing if the coverage masks should be inverted. GL_TRUE and GL_FALSE are accepted. The initial value is GL_FALSE.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glSampleCoverageOES")]
            public static void SampleCoverage(int value, bool invert) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glSampleCoveragexOES")]
            public static void SampleCoveragex(int value, bool invert) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glScalexOES")]
            public static void Scalex(int x, int y, int z) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord1bOES")]
            [CLSCompliant(false)]
            public static void TexCoord1(Byte s) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord1bOES")]
            [CLSCompliant(false)]
            public static void TexCoord1(SByte s) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord1bvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexCoord1(Byte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord1bvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexCoord1(SByte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord1xOES")]
            public static void TexCoord1x(int s) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord1xvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexCoord1x(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bOES")]
            [CLSCompliant(false)]
            public static void TexCoord2(Byte s, Byte t) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bOES")]
            [CLSCompliant(false)]
            public static void TexCoord2(SByte s, SByte t) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            [CLSCompliant(false)]
            public static void TexCoord2(Byte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            [CLSCompliant(false)]
            public static void TexCoord2(ref Byte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexCoord2(Byte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            [CLSCompliant(false)]
            public static void TexCoord2(SByte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            [CLSCompliant(false)]
            public static void TexCoord2(ref SByte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexCoord2(SByte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord2xOES")]
            public static void TexCoord2x(int s, int t) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord2xvOES")]
            [CLSCompliant(false)]
            public static void TexCoord2x(int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord2xvOES")]
            [CLSCompliant(false)]
            public static void TexCoord2x(ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord2xvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexCoord2x(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bOES")]
            [CLSCompliant(false)]
            public static void TexCoord3(Byte s, Byte t, Byte r) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bOES")]
            [CLSCompliant(false)]
            public static void TexCoord3(SByte s, SByte t, SByte r) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            [CLSCompliant(false)]
            public static void TexCoord3(Byte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            [CLSCompliant(false)]
            public static void TexCoord3(ref Byte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexCoord3(Byte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            [CLSCompliant(false)]
            public static void TexCoord3(SByte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            [CLSCompliant(false)]
            public static void TexCoord3(ref SByte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexCoord3(SByte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord3xOES")]
            public static void TexCoord3x(int s, int t, int r) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord3xvOES")]
            [CLSCompliant(false)]
            public static void TexCoord3x(int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord3xvOES")]
            [CLSCompliant(false)]
            public static void TexCoord3x(ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord3xvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexCoord3x(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bOES")]
            [CLSCompliant(false)]
            public static void TexCoord4(Byte s, Byte t, Byte r, Byte q) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bOES")]
            [CLSCompliant(false)]
            public static void TexCoord4(SByte s, SByte t, SByte r, SByte q) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            [CLSCompliant(false)]
            public static void TexCoord4(Byte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            [CLSCompliant(false)]
            public static void TexCoord4(ref Byte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexCoord4(Byte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            [CLSCompliant(false)]
            public static void TexCoord4(SByte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            [CLSCompliant(false)]
            public static void TexCoord4(ref SByte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexCoord4(SByte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord4xOES")]
            public static void TexCoord4x(int s, int t, int r, int q) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord4xvOES")]
            [CLSCompliant(false)]
            public static void TexCoord4x(int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord4xvOES")]
            [CLSCompliant(false)]
            public static void TexCoord4x(ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord4xvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexCoord4x(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexEnvxOES")]
            public static void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexEnvxvOES")]
            [CLSCompliant(false)]
            public static void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexEnvxvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_texture_cube_map]
            /// Control the generation of texture coordinates
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be one of GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the texture-coordinate generation function. Must be GL_TEXTURE_GEN_MODE.
            /// </para>
            /// </param>
            /// <param name="param">
            /// <para>
            /// Specifies a single-valued texture generation parameter, one of GL_OBJECT_LINEAR, GL_EYE_LINEAR, GL_SPHERE_MAP, GL_NORMAL_MAP, or GL_REFLECTION_MAP.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenfOES")]
            public static void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_texture_cube_map]
            /// Control the generation of texture coordinates
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be one of GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the texture-coordinate generation function. Must be GL_TEXTURE_GEN_MODE.
            /// </para>
            /// </param>
            /// <param name="param">
            /// <para>
            /// Specifies a single-valued texture generation parameter, one of GL_OBJECT_LINEAR, GL_EYE_LINEAR, GL_SPHERE_MAP, GL_NORMAL_MAP, or GL_REFLECTION_MAP.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenfvOES")]
            [CLSCompliant(false)]
            public static void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_texture_cube_map]
            /// Control the generation of texture coordinates
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be one of GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the texture-coordinate generation function. Must be GL_TEXTURE_GEN_MODE.
            /// </para>
            /// </param>
            /// <param name="param">
            /// <para>
            /// Specifies a single-valued texture generation parameter, one of GL_OBJECT_LINEAR, GL_EYE_LINEAR, GL_SPHERE_MAP, GL_NORMAL_MAP, or GL_REFLECTION_MAP.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenfvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_texture_cube_map]
            /// Control the generation of texture coordinates
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be one of GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the texture-coordinate generation function. Must be GL_TEXTURE_GEN_MODE.
            /// </para>
            /// </param>
            /// <param name="param">
            /// <para>
            /// Specifies a single-valued texture generation parameter, one of GL_OBJECT_LINEAR, GL_EYE_LINEAR, GL_SPHERE_MAP, GL_NORMAL_MAP, or GL_REFLECTION_MAP.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGeniOES")]
            public static void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32 param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_texture_cube_map]
            /// Control the generation of texture coordinates
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be one of GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the texture-coordinate generation function. Must be GL_TEXTURE_GEN_MODE.
            /// </para>
            /// </param>
            /// <param name="param">
            /// <para>
            /// Specifies a single-valued texture generation parameter, one of GL_OBJECT_LINEAR, GL_EYE_LINEAR, GL_SPHERE_MAP, GL_NORMAL_MAP, or GL_REFLECTION_MAP.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenivOES")]
            [CLSCompliant(false)]
            public static void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_texture_cube_map]
            /// Control the generation of texture coordinates
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be one of GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the texture-coordinate generation function. Must be GL_TEXTURE_GEN_MODE.
            /// </para>
            /// </param>
            /// <param name="param">
            /// <para>
            /// Specifies a single-valued texture generation parameter, one of GL_OBJECT_LINEAR, GL_EYE_LINEAR, GL_SPHERE_MAP, GL_NORMAL_MAP, or GL_REFLECTION_MAP.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenivOES")]
            [CLSCompliant(false)]
            public static unsafe void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glTexGenxOES")]
            public static void TexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glTexGenxvOES")]
            [CLSCompliant(false)]
            public static void TexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glTexGenxvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexParameterxOES")]
            public static void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexParameterxvOES")]
            [CLSCompliant(false)]
            public static void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexParameterxvOES")]
            [CLSCompliant(false)]
            public static unsafe void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTranslatexOES")]
            public static void Translatex(int x, int y, int z) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glUnmapBufferOES")]
            public static bool UnmapBuffer(OpenTK.Graphics.ES11.All target) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bOES")]
            [CLSCompliant(false)]
            public static void Vertex2(Byte x) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bOES")]
            [CLSCompliant(false)]
            public static void Vertex2(SByte x) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bvOES")]
            [CLSCompliant(false)]
            public static void Vertex2(Byte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bvOES")]
            [CLSCompliant(false)]
            public static unsafe void Vertex2(Byte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bvOES")]
            [CLSCompliant(false)]
            public static void Vertex2(SByte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bvOES")]
            [CLSCompliant(false)]
            public static unsafe void Vertex2(SByte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex2xOES")]
            public static void Vertex2x(int x) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex2xvOES")]
            [CLSCompliant(false)]
            public static void Vertex2x(int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex2xvOES")]
            [CLSCompliant(false)]
            public static unsafe void Vertex2x(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bOES")]
            [CLSCompliant(false)]
            public static void Vertex3(Byte x, Byte y) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bOES")]
            [CLSCompliant(false)]
            public static void Vertex3(SByte x, SByte y) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            [CLSCompliant(false)]
            public static void Vertex3(Byte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            [CLSCompliant(false)]
            public static void Vertex3(ref Byte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            [CLSCompliant(false)]
            public static unsafe void Vertex3(Byte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            [CLSCompliant(false)]
            public static void Vertex3(SByte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            [CLSCompliant(false)]
            public static void Vertex3(ref SByte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            [CLSCompliant(false)]
            public static unsafe void Vertex3(SByte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex3xOES")]
            public static void Vertex3x(int x, int y) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex3xvOES")]
            [CLSCompliant(false)]
            public static void Vertex3x(int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex3xvOES")]
            [CLSCompliant(false)]
            public static void Vertex3x(ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex3xvOES")]
            [CLSCompliant(false)]
            public static unsafe void Vertex3x(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bOES")]
            [CLSCompliant(false)]
            public static void Vertex4(Byte x, Byte y, Byte z) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bOES")]
            [CLSCompliant(false)]
            public static void Vertex4(SByte x, SByte y, SByte z) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            [CLSCompliant(false)]
            public static void Vertex4(Byte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            [CLSCompliant(false)]
            public static void Vertex4(ref Byte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            [CLSCompliant(false)]
            public static unsafe void Vertex4(Byte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            [CLSCompliant(false)]
            public static void Vertex4(SByte[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            [CLSCompliant(false)]
            public static void Vertex4(ref SByte coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            [CLSCompliant(false)]
            public static unsafe void Vertex4(SByte* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex4xOES")]
            public static void Vertex4x(int x, int y, int z) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex4xvOES")]
            [CLSCompliant(false)]
            public static void Vertex4x(int[] coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex4xvOES")]
            [CLSCompliant(false)]
            public static void Vertex4x(ref int coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex4xvOES")]
            [CLSCompliant(false)]
            public static unsafe void Vertex4x(int* coords) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            public static void WeightPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            [CLSCompliant(false)]
            public static void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            [CLSCompliant(false)]
            public static void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            [CLSCompliant(false)]
            public static void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
                where T3 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            public static void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
                where T3 : struct
             { throw new NotImplementedException(); }

        }

        public static partial class Qcom
        {
            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glDisableDriverControlQCOM")]
            [CLSCompliant(false)]
            public static void DisableDriverControl(Int32 driverControl) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glDisableDriverControlQCOM")]
            [CLSCompliant(false)]
            public static void DisableDriverControl(UInt32 driverControl) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glEnableDriverControlQCOM")]
            [CLSCompliant(false)]
            public static void EnableDriverControl(Int32 driverControl) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glEnableDriverControlQCOM")]
            [CLSCompliant(false)]
            public static void EnableDriverControl(UInt32 driverControl) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glEndTilingQCOM")]
            [CLSCompliant(false)]
            public static void EndTiling(Int32 preserveMask) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glEndTilingQCOM")]
            [CLSCompliant(false)]
            public static void EndTiling(UInt32 preserveMask) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            public static void ExtGetBufferPointer(OpenTK.Graphics.ES11.All target, [OutAttribute] IntPtr @params) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] T1[] @params)
                where T1 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] T1[,] @params)
                where T1 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] T1[,,] @params)
                where T1 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            public static void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] ref T1 @params)
                where T1 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetBuffers([OutAttribute] Int32[] buffers, Int32 maxBuffers, [OutAttribute] Int32[] numBuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetBuffers([OutAttribute] out Int32 buffers, Int32 maxBuffers, [OutAttribute] out Int32 numBuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetBuffers([OutAttribute] Int32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetBuffers([OutAttribute] UInt32[] buffers, Int32 maxBuffers, [OutAttribute] Int32[] numBuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetBuffers([OutAttribute] out UInt32 buffers, Int32 maxBuffers, [OutAttribute] out Int32 numBuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetBuffers([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetFramebuffers([OutAttribute] Int32[] framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32[] numFramebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetFramebuffers([OutAttribute] out Int32 framebuffers, Int32 maxFramebuffers, [OutAttribute] out Int32 numFramebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetFramebuffers([OutAttribute] Int32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetFramebuffers([OutAttribute] UInt32[] framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32[] numFramebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetFramebuffers([OutAttribute] out UInt32 framebuffers, Int32 maxFramebuffers, [OutAttribute] out Int32 numFramebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetFramebuffers([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetProgramBinarySource(Int32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32[] length) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetProgramBinarySource(Int32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] out Int32 length) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetProgramBinarySource(Int32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetProgramBinarySource(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32[] length) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetProgramBinarySource(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] out Int32 length) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetProgramBinarySource(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetProgram([OutAttribute] Int32[] programs, Int32 maxPrograms, [OutAttribute] Int32[] numPrograms) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetProgram([OutAttribute] out Int32 programs, Int32 maxPrograms, [OutAttribute] out Int32 numPrograms) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetProgram([OutAttribute] Int32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetProgram([OutAttribute] UInt32[] programs, Int32 maxPrograms, [OutAttribute] Int32[] numPrograms) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetProgram([OutAttribute] out UInt32 programs, Int32 maxPrograms, [OutAttribute] out Int32 numPrograms) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetProgram([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetRenderbuffers([OutAttribute] Int32[] renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32[] numRenderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetRenderbuffers([OutAttribute] out Int32 renderbuffers, Int32 maxRenderbuffers, [OutAttribute] out Int32 numRenderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetRenderbuffers([OutAttribute] Int32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetRenderbuffers([OutAttribute] UInt32[] renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32[] numRenderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetRenderbuffers([OutAttribute] out UInt32 renderbuffers, Int32 maxRenderbuffers, [OutAttribute] out Int32 numRenderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetRenderbuffers([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetShaders([OutAttribute] Int32[] shaders, Int32 maxShaders, [OutAttribute] Int32[] numShaders) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetShaders([OutAttribute] out Int32 shaders, Int32 maxShaders, [OutAttribute] out Int32 numShaders) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetShaders([OutAttribute] Int32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetShaders([OutAttribute] UInt32[] shaders, Int32 maxShaders, [OutAttribute] Int32[] numShaders) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetShaders([OutAttribute] out UInt32 shaders, Int32 maxShaders, [OutAttribute] out Int32 numShaders) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetShaders([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetTexLevelParameter(Int32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetTexLevelParameter(Int32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetTexLevelParameter(Int32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetTexLevelParameter(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetTexLevelParameter(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetTexLevelParameter(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            public static void ExtGetTexSubImage(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [OutAttribute] IntPtr texels) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T10[] texels)
                where T10 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T10[,] texels)
                where T10 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T10[,,] texels)
                where T10 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            public static void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T10 texels)
                where T10 : struct
             { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetTextures([OutAttribute] Int32[] textures, Int32 maxTextures, [OutAttribute] Int32[] numTextures) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetTextures([OutAttribute] out Int32 textures, Int32 maxTextures, [OutAttribute] out Int32 numTextures) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetTextures([OutAttribute] Int32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetTextures([OutAttribute] UInt32[] textures, Int32 maxTextures, [OutAttribute] Int32[] numTextures) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            [CLSCompliant(false)]
            public static void ExtGetTextures([OutAttribute] out UInt32 textures, Int32 maxTextures, [OutAttribute] out Int32 numTextures) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            [CLSCompliant(false)]
            public static unsafe void ExtGetTextures([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtIsProgramBinaryQCOM")]
            [CLSCompliant(false)]
            public static bool ExtIsProgramBinary(Int32 program) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtIsProgramBinaryQCOM")]
            [CLSCompliant(false)]
            public static bool ExtIsProgramBinary(UInt32 program) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtTexObjectStateOverrideiQCOM")]
            public static void ExtTexObjectStateOverride(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            [CLSCompliant(false)]
            public static void GetDriverControl([OutAttribute] Int32[] num, Int32 size, [OutAttribute] Int32[] driverControls) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            [CLSCompliant(false)]
            public static void GetDriverControl([OutAttribute] Int32[] num, Int32 size, [OutAttribute] UInt32[] driverControls) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            [CLSCompliant(false)]
            public static void GetDriverControl([OutAttribute] out Int32 num, Int32 size, [OutAttribute] out Int32 driverControls) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            [CLSCompliant(false)]
            public static void GetDriverControl([OutAttribute] out Int32 num, Int32 size, [OutAttribute] out UInt32 driverControls) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            [CLSCompliant(false)]
            public static unsafe void GetDriverControl([OutAttribute] Int32* num, Int32 size, [OutAttribute] Int32* driverControls) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            [CLSCompliant(false)]
            public static unsafe void GetDriverControl([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            [CLSCompliant(false)]
            public static void GetDriverControlString(Int32 driverControl, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] StringBuilder driverControlString) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            [CLSCompliant(false)]
            public static void GetDriverControlString(Int32 driverControl, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder driverControlString) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            [CLSCompliant(false)]
            public static unsafe void GetDriverControlString(Int32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            [CLSCompliant(false)]
            public static void GetDriverControlString(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] StringBuilder driverControlString) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            [CLSCompliant(false)]
            public static void GetDriverControlString(UInt32 driverControl, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder driverControlString) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            [CLSCompliant(false)]
            public static unsafe void GetDriverControlString(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glStartTilingQCOM")]
            [CLSCompliant(false)]
            public static void StartTiling(Int32 x, Int32 y, Int32 width, Int32 height, Int32 preserveMask) { throw new NotImplementedException(); }

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glStartTilingQCOM")]
            [CLSCompliant(false)]
            public static void StartTiling(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask) { throw new NotImplementedException(); }

        }

        [Slot(31)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 glClientWaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
        [Slot(53)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glCopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);
        [Slot(60)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDeleteSyncAPPLE(IntPtr sync);
        [Slot(106)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern IntPtr glFenceSyncAPPLE(System.Int32 condition, UInt32 flags);
        [Slot(151)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetInteger64vAPPLE(System.Int32 pname, [OutAttribute] Int64* @params);
        [Slot(168)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetSyncivAPPLE(IntPtr sync, System.Int32 pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
        [Slot(189)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool glIsSyncAPPLE(IntPtr sync);
        [Slot(294)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRenderbufferStorageMultisampleAPPLE(System.Int32 target, Int32 samples, System.Int32 internalformat, Int32 width, Int32 height);
        [Slot(298)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glResolveMultisampleFramebufferAPPLE();
        [Slot(382)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glWaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
        [Slot(1)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glActiveTexture(System.Int32 texture);
        [Slot(2)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glAlphaFunc(System.Int32 func, Single @ref);
        [Slot(3)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glAlphaFuncx(System.Int32 func, int @ref);
        [Slot(5)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBindBuffer(System.Int32 target, UInt32 buffer);
        [Slot(8)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBindTexture(System.Int32 target, UInt32 texture);
        [Slot(15)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBlendFunc(System.Int32 sfactor, System.Int32 dfactor);
        [Slot(17)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBufferData(System.Int32 target, IntPtr size, IntPtr data, System.Int32 usage);
        [Slot(18)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBufferSubData(System.Int32 target, IntPtr offset, IntPtr size, IntPtr data);
        [Slot(20)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClear(System.Int32 mask);
        [Slot(22)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearColor(Single red, Single green, Single blue, Single alpha);
        [Slot(23)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearColorx(int red, int green, int blue, int alpha);
        [Slot(25)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearDepthf(Single d);
        [Slot(27)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearDepthx(int depth);
        [Slot(29)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearStencil(Int32 s);
        [Slot(30)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClientActiveTexture(System.Int32 texture);
        [Slot(32)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glClipPlanef(System.Int32 p, Single* eqn);
        [Slot(35)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glClipPlanex(System.Int32 plane, int* equation);
        [Slot(40)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glColor4f(Single red, Single green, Single blue, Single alpha);
        [Slot(41)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glColor4ub(Byte red, Byte green, Byte blue, Byte alpha);
        [Slot(42)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glColor4x(int red, int green, int blue, int alpha);
        [Slot(45)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glColorMask(bool red, bool green, bool blue, bool alpha);
        [Slot(46)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glColorPointer(Int32 size, System.Int32 type, Int32 stride, IntPtr pointer);
        [Slot(47)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glCompressedTexImage2D(System.Int32 target, Int32 level, System.Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
        [Slot(48)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glCompressedTexSubImage2D(System.Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, System.Int32 format, Int32 imageSize, IntPtr data);
        [Slot(51)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glCopyTexImage2D(System.Int32 target, Int32 level, System.Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
        [Slot(52)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glCopyTexSubImage2D(System.Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        [Slot(54)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glCullFace(System.Int32 mode);
        [Slot(56)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glDeleteBuffers(Int32 n, UInt32* buffers);
        [Slot(61)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glDeleteTextures(Int32 n, UInt32* textures);
        [Slot(63)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDepthFunc(System.Int32 func);
        [Slot(64)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDepthMask(bool flag);
        [Slot(65)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDepthRangef(Single n, Single f);
        [Slot(67)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDepthRangex(int n, int f);
        [Slot(69)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDisable(System.Int32 cap);
        [Slot(70)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDisableClientState(System.Int32 array);
        [Slot(73)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDrawArrays(System.Int32 mode, Int32 first, Int32 count);
        [Slot(74)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDrawElements(System.Int32 mode, Int32 count, System.Int32 type, IntPtr indices);
        [Slot(85)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glEnable(System.Int32 cap);
        [Slot(86)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glEnableClientState(System.Int32 array);
        [Slot(107)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFinish();
        [Slot(109)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFlush();
        [Slot(111)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFogf(System.Int32 pname, Single param);
        [Slot(112)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glFogfv(System.Int32 pname, Single* @params);
        [Slot(113)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFogx(System.Int32 pname, int param);
        [Slot(115)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glFogxv(System.Int32 pname, int* param);
        [Slot(121)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFrontFace(System.Int32 mode);
        [Slot(122)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFrustumf(Single l, Single r, Single b, Single t, Single n, Single f);
        [Slot(124)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFrustumx(int l, int r, int b, int t, int n, int f);
        [Slot(126)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
        [Slot(131)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGenTextures(Int32 n, [OutAttribute] UInt32* textures);
        [Slot(133)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetBooleanv(System.Int32 pname, [OutAttribute] bool* data);
        [Slot(134)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetBufferParameteriv(System.Int32 target, System.Int32 pname, [OutAttribute] Int32* @params);
        [Slot(136)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetClipPlanef(System.Int32 plane, [OutAttribute] Single* equation);
        [Slot(138)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetClipPlanex(System.Int32 plane, [OutAttribute] int* equation);
        [Slot(143)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 glGetError();
        [Slot(145)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetFixedv(System.Int32 pname, [OutAttribute] int* @params);
        [Slot(147)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetFloatv(System.Int32 pname, [OutAttribute] Single* data);
        [Slot(152)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetIntegerv(System.Int32 pname, [OutAttribute] Int32* data);
        [Slot(153)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetLightfv(System.Int32 light, System.Int32 pname, [OutAttribute] Single* @params);
        [Slot(155)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetLightxv(System.Int32 light, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(158)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetMaterialfv(System.Int32 face, System.Int32 pname, [OutAttribute] Single* @params);
        [Slot(160)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetMaterialxv(System.Int32 face, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(164)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetPixelMapxv(System.Int32 map, Int32 size, [OutAttribute] int* values);
        [Slot(165)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glGetPointerv(System.Int32 pname, [OutAttribute] IntPtr @params);
        [Slot(167)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern IntPtr glGetString(System.Int32 name);
        [Slot(169)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexEnvfv(System.Int32 target, System.Int32 pname, [OutAttribute] Single* @params);
        [Slot(170)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexEnviv(System.Int32 target, System.Int32 pname, [OutAttribute] Int32* @params);
        [Slot(171)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexEnvxv(System.Int32 target, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(177)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexParameterfv(System.Int32 target, System.Int32 pname, [OutAttribute] Single* @params);
        [Slot(178)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexParameteriv(System.Int32 target, System.Int32 pname, [OutAttribute] Int32* @params);
        [Slot(179)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexParameterxv(System.Int32 target, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(181)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glHint(System.Int32 target, System.Int32 mode);
        [Slot(184)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool glIsBuffer(UInt32 buffer);
        [Slot(185)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool glIsEnabled(System.Int32 cap);
        [Slot(190)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool glIsTexture(UInt32 texture);
        [Slot(192)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLightf(System.Int32 light, System.Int32 pname, Single param);
        [Slot(193)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLightfv(System.Int32 light, System.Int32 pname, Single* @params);
        [Slot(194)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLightModelf(System.Int32 pname, Single param);
        [Slot(195)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLightModelfv(System.Int32 pname, Single* @params);
        [Slot(196)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLightModelx(System.Int32 pname, int param);
        [Slot(198)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLightModelxv(System.Int32 pname, int* param);
        [Slot(200)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLightx(System.Int32 light, System.Int32 pname, int param);
        [Slot(202)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLightxv(System.Int32 light, System.Int32 pname, int* @params);
        [Slot(204)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLineWidth(Single width);
        [Slot(205)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLineWidthx(int width);
        [Slot(207)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLoadIdentity();
        [Slot(208)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLoadMatrixf(Single* m);
        [Slot(209)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLoadMatrixx(int* m);
        [Slot(213)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLogicOp(System.Int32 opcode);
        [Slot(220)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMaterialf(System.Int32 face, System.Int32 pname, Single param);
        [Slot(221)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMaterialfv(System.Int32 face, System.Int32 pname, Single* @params);
        [Slot(222)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMaterialx(System.Int32 face, System.Int32 pname, int param);
        [Slot(224)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMaterialxv(System.Int32 face, System.Int32 pname, int* param);
        [Slot(227)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMatrixMode(System.Int32 mode);
        [Slot(244)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMultiTexCoord4f(System.Int32 target, Single s, Single t, Single r, Single q);
        [Slot(245)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMultiTexCoord4x(System.Int32 texture, int s, int t, int r, int q);
        [Slot(248)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultMatrixf(Single* m);
        [Slot(249)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultMatrixx(int* m);
        [Slot(252)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glNormal3f(Single nx, Single ny, Single nz);
        [Slot(253)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glNormal3x(int nx, int ny, int nz);
        [Slot(256)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glNormalPointer(System.Int32 type, Int32 stride, IntPtr pointer);
        [Slot(257)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glOrthof(Single l, Single r, Single b, Single t, Single n, Single f);
        [Slot(259)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glOrthox(int l, int r, int b, int t, int n, int f);
        [Slot(262)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glPixelMapx(System.Int32 map, Int32 size, int* values);
        [Slot(263)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPixelStorei(System.Int32 pname, Int32 param);
        [Slot(264)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPixelStorex(System.Int32 pname, int param);
        [Slot(267)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPointParameterf(System.Int32 pname, Single param);
        [Slot(268)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glPointParameterfv(System.Int32 pname, Single* @params);
        [Slot(269)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPointParameterx(System.Int32 pname, int param);
        [Slot(271)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glPointParameterxv(System.Int32 pname, int* @params);
        [Slot(273)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPointSize(Single size);
        [Slot(275)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPointSizex(int size);
        [Slot(277)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPolygonOffset(Single factor, Single units);
        [Slot(278)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPolygonOffsetx(int factor, int units);
        [Slot(280)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPopMatrix();
        [Slot(282)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPushMatrix();
        [Slot(291)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, System.Int32 format, System.Int32 type, [OutAttribute] IntPtr pixels);
        [Slot(299)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRotatef(Single angle, Single x, Single y, Single z);
        [Slot(300)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRotatex(int angle, int x, int y, int z);
        [Slot(302)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glSampleCoverage(Single value, bool invert);
        [Slot(304)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glSampleCoveragex(int value, bool invert);
        [Slot(306)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glScalef(Single x, Single y, Single z);
        [Slot(307)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glScalex(int x, int y, int z);
        [Slot(309)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glScissor(Int32 x, Int32 y, Int32 width, Int32 height);
        [Slot(311)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glShadeModel(System.Int32 mode);
        [Slot(313)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glStencilFunc(System.Int32 func, Int32 @ref, UInt32 mask);
        [Slot(314)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glStencilMask(UInt32 mask);
        [Slot(315)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glStencilOp(System.Int32 fail, System.Int32 zfail, System.Int32 zpass);
        [Slot(333)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexCoordPointer(Int32 size, System.Int32 type, Int32 stride, IntPtr pointer);
        [Slot(334)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexEnvf(System.Int32 target, System.Int32 pname, Single param);
        [Slot(335)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexEnvfv(System.Int32 target, System.Int32 pname, Single* @params);
        [Slot(336)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexEnvi(System.Int32 target, System.Int32 pname, Int32 param);
        [Slot(337)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexEnviv(System.Int32 target, System.Int32 pname, Int32* @params);
        [Slot(338)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexEnvx(System.Int32 target, System.Int32 pname, int param);
        [Slot(340)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexEnvxv(System.Int32 target, System.Int32 pname, int* @params);
        [Slot(348)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexImage2D(System.Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, System.Int32 format, System.Int32 type, IntPtr pixels);
        [Slot(349)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexParameterf(System.Int32 target, System.Int32 pname, Single param);
        [Slot(350)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexParameterfv(System.Int32 target, System.Int32 pname, Single* @params);
        [Slot(351)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexParameteri(System.Int32 target, System.Int32 pname, Int32 param);
        [Slot(352)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexParameteriv(System.Int32 target, System.Int32 pname, Int32* @params);
        [Slot(353)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexParameterx(System.Int32 target, System.Int32 pname, int param);
        [Slot(355)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexParameterxv(System.Int32 target, System.Int32 pname, int* @params);
        [Slot(360)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexSubImage2D(System.Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, System.Int32 format, System.Int32 type, IntPtr pixels);
        [Slot(364)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTranslatef(Single x, Single y, Single z);
        [Slot(365)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTranslatex(int x, int y, int z);
        [Slot(380)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glVertexPointer(Int32 size, System.Int32 type, Int32 stride, IntPtr pointer);
        [Slot(381)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glViewport(Int32 x, Int32 y, Int32 width, Int32 height);
        [Slot(12)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBlendEquationEXT(System.Int32 mode);
        [Slot(72)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glDiscardFramebufferEXT(System.Int32 target, Int32 numAttachments, System.Int32* attachments);
        [Slot(110)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFlushMappedBufferRangeEXT(System.Int32 target, IntPtr offset, IntPtr length);
        [Slot(118)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFramebufferTexture2DMultisampleEXT(System.Int32 target, System.Int32 attachment, System.Int32 textarget, UInt32 texture, Int32 level, Int32 samples);
        [Slot(149)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 glGetGraphicsResetStatusEXT();
        [Slot(162)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
        [Slot(163)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
        [Slot(217)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern IntPtr glMapBufferRangeEXT(System.Int32 target, IntPtr offset, IntPtr length, UInt32 access);
        [Slot(228)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultiDrawArraysEXT(System.Int32 mode, Int32* first, Int32* count, Int32 primcount);
        [Slot(229)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultiDrawElementsEXT(System.Int32 mode, Int32* count, System.Int32 type, IntPtr indices, Int32 primcount);
        [Slot(290)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, System.Int32 format, System.Int32 type, Int32 bufSize, [OutAttribute] IntPtr data);
        [Slot(295)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRenderbufferStorageMultisampleEXT(System.Int32 target, Int32 samples, System.Int32 internalformat, Int32 width, Int32 height);
        [Slot(357)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexStorage1DEXT(System.Int32 target, Int32 levels, System.Int32 internalformat, Int32 width);
        [Slot(358)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexStorage2DEXT(System.Int32 target, Int32 levels, System.Int32 internalformat, Int32 width, Int32 height);
        [Slot(359)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexStorage3DEXT(System.Int32 target, Int32 levels, System.Int32 internalformat, Int32 width, Int32 height, Int32 depth);
        [Slot(361)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTextureStorage1DEXT(UInt32 texture, System.Int32 target, Int32 levels, System.Int32 internalformat, Int32 width);
        [Slot(362)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTextureStorage2DEXT(UInt32 texture, System.Int32 target, Int32 levels, System.Int32 internalformat, Int32 width, Int32 height);
        [Slot(363)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTextureStorage3DEXT(UInt32 texture, System.Int32 target, Int32 levels, System.Int32 internalformat, Int32 width, Int32 height, Int32 depth);
        [Slot(33)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glClipPlanefIMG(System.Int32 p, Single* eqn);
        [Slot(36)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glClipPlanexIMG(System.Int32 p, int* eqn);
        [Slot(119)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFramebufferTexture2DMultisampleIMG(System.Int32 target, System.Int32 attachment, System.Int32 textarget, UInt32 texture, Int32 level, Int32 samples);
        [Slot(296)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRenderbufferStorageMultisampleIMG(System.Int32 target, Int32 samples, System.Int32 internalformat, Int32 width, Int32 height);
        [Slot(57)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glDeleteFencesNV(Int32 n, UInt32* fences);
        [Slot(108)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFinishFenceNV(UInt32 fence);
        [Slot(128)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGenFencesNV(Int32 n, [OutAttribute] UInt32* fences);
        [Slot(144)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetFenceivNV(UInt32 fence, System.Int32 pname, [OutAttribute] Int32* @params);
        [Slot(186)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool glIsFenceNV(UInt32 fence);
        [Slot(310)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glSetFenceNV(UInt32 fence, System.Int32 condition);
        [Slot(316)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool glTestFenceNV(UInt32 fence);
        [Slot(0)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glAccumxOES(System.Int32 op, int value);
        [Slot(4)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glAlphaFuncxOES(System.Int32 func, int @ref);
        [Slot(6)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBindFramebufferOES(System.Int32 target, UInt32 framebuffer);
        [Slot(7)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBindRenderbufferOES(System.Int32 target, UInt32 renderbuffer);
        [Slot(9)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBindVertexArrayOES(UInt32 array);
        [Slot(10)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glBitmapxOES(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte* bitmap);
        [Slot(11)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBlendColorxOES(int red, int green, int blue, int alpha);
        [Slot(13)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBlendEquationOES(System.Int32 mode);
        [Slot(14)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBlendEquationSeparateOES(System.Int32 modeRGB, System.Int32 modeAlpha);
        [Slot(16)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBlendFuncSeparateOES(System.Int32 srcRGB, System.Int32 dstRGB, System.Int32 srcAlpha, System.Int32 dstAlpha);
        [Slot(19)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 glCheckFramebufferStatusOES(System.Int32 target);
        [Slot(21)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearAccumxOES(int red, int green, int blue, int alpha);
        [Slot(24)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearColorxOES(int red, int green, int blue, int alpha);
        [Slot(26)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearDepthfOES(Single depth);
        [Slot(28)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearDepthxOES(int depth);
        [Slot(34)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glClipPlanefOES(System.Int32 plane, Single* equation);
        [Slot(37)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glClipPlanexOES(System.Int32 plane, int* equation);
        [Slot(38)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glColor3xOES(int red, int green, int blue);
        [Slot(39)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glColor3xvOES(int* components);
        [Slot(43)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glColor4xOES(int red, int green, int blue, int alpha);
        [Slot(44)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glColor4xvOES(int* components);
        [Slot(49)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glConvolutionParameterxOES(System.Int32 target, System.Int32 pname, int param);
        [Slot(50)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glConvolutionParameterxvOES(System.Int32 target, System.Int32 pname, int* @params);
        [Slot(55)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glCurrentPaletteMatrixOES(UInt32 matrixpaletteindex);
        [Slot(58)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glDeleteFramebuffersOES(Int32 n, UInt32* framebuffers);
        [Slot(59)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glDeleteRenderbuffersOES(Int32 n, UInt32* renderbuffers);
        [Slot(62)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glDeleteVertexArraysOES(Int32 n, UInt32* arrays);
        [Slot(66)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDepthRangefOES(Single n, Single f);
        [Slot(68)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDepthRangexOES(int n, int f);
        [Slot(75)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDrawTexfOES(Single x, Single y, Single z, Single width, Single height);
        [Slot(76)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glDrawTexfvOES(Single* coords);
        [Slot(77)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDrawTexiOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height);
        [Slot(78)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glDrawTexivOES(Int32* coords);
        [Slot(79)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDrawTexsOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height);
        [Slot(80)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glDrawTexsvOES(Int16* coords);
        [Slot(81)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDrawTexxOES(int x, int y, int z, int width, int height);
        [Slot(82)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glDrawTexxvOES(int* coords);
        [Slot(83)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glEGLImageTargetRenderbufferStorageOES(System.Int32 target, IntPtr image);
        [Slot(84)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glEGLImageTargetTexture2DOES(System.Int32 target, IntPtr image);
        [Slot(89)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glEvalCoord1xOES(int u);
        [Slot(90)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glEvalCoord1xvOES(int* coords);
        [Slot(91)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glEvalCoord2xOES(int u, int v);
        [Slot(92)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glEvalCoord2xvOES(int* coords);
        [Slot(105)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glFeedbackBufferxOES(Int32 n, System.Int32 type, int* buffer);
        [Slot(114)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFogxOES(System.Int32 pname, int param);
        [Slot(116)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glFogxvOES(System.Int32 pname, int* param);
        [Slot(117)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFramebufferRenderbufferOES(System.Int32 target, System.Int32 attachment, System.Int32 renderbuffertarget, UInt32 renderbuffer);
        [Slot(120)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFramebufferTexture2DOES(System.Int32 target, System.Int32 attachment, System.Int32 textarget, UInt32 texture, Int32 level);
        [Slot(123)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFrustumfOES(Single l, Single r, Single b, Single t, Single n, Single f);
        [Slot(125)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFrustumxOES(int l, int r, int b, int t, int n, int f);
        [Slot(127)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glGenerateMipmapOES(System.Int32 target);
        [Slot(129)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGenFramebuffersOES(Int32 n, [OutAttribute] UInt32* framebuffers);
        [Slot(130)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGenRenderbuffersOES(Int32 n, [OutAttribute] UInt32* renderbuffers);
        [Slot(132)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGenVertexArraysOES(Int32 n, [OutAttribute] UInt32* arrays);
        [Slot(135)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glGetBufferPointervOES(System.Int32 target, System.Int32 pname, [OutAttribute] IntPtr @params);
        [Slot(137)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetClipPlanefOES(System.Int32 plane, [OutAttribute] Single* equation);
        [Slot(139)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetClipPlanexOES(System.Int32 plane, [OutAttribute] int* equation);
        [Slot(140)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetConvolutionParameterxvOES(System.Int32 target, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(146)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetFixedvOES(System.Int32 pname, [OutAttribute] int* @params);
        [Slot(148)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetFramebufferAttachmentParameterivOES(System.Int32 target, System.Int32 attachment, System.Int32 pname, [OutAttribute] Int32* @params);
        [Slot(150)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetHistogramParameterxvOES(System.Int32 target, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(154)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetLightxOES(System.Int32 light, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(157)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetMapxvOES(System.Int32 target, System.Int32 query, [OutAttribute] int* v);
        [Slot(159)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glGetMaterialxOES(System.Int32 face, System.Int32 pname, int param);
        [Slot(161)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetMaterialxvOES(System.Int32 face, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(166)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetRenderbufferParameterivOES(System.Int32 target, System.Int32 pname, [OutAttribute] Int32* @params);
        [Slot(172)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexEnvxvOES(System.Int32 target, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(173)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexGenfvOES(System.Int32 coord, System.Int32 pname, [OutAttribute] Single* @params);
        [Slot(174)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexGenivOES(System.Int32 coord, System.Int32 pname, [OutAttribute] Int32* @params);
        [Slot(175)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexGenxvOES(System.Int32 coord, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(176)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexLevelParameterxvOES(System.Int32 target, Int32 level, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(180)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexParameterxvOES(System.Int32 target, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(182)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glIndexxOES(int component);
        [Slot(183)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glIndexxvOES(int* component);
        [Slot(187)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool glIsFramebufferOES(UInt32 framebuffer);
        [Slot(188)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool glIsRenderbufferOES(UInt32 renderbuffer);
        [Slot(191)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool glIsVertexArrayOES(UInt32 array);
        [Slot(197)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLightModelxOES(System.Int32 pname, int param);
        [Slot(199)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLightModelxvOES(System.Int32 pname, int* param);
        [Slot(201)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLightxOES(System.Int32 light, System.Int32 pname, int param);
        [Slot(203)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLightxvOES(System.Int32 light, System.Int32 pname, int* @params);
        [Slot(206)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLineWidthxOES(int width);
        [Slot(210)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLoadMatrixxOES(int* m);
        [Slot(211)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLoadPaletteFromModelViewMatrixOES();
        [Slot(212)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLoadTransposeMatrixxOES(int* m);
        [Slot(214)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMap1xOES(System.Int32 target, int u1, int u2, Int32 stride, Int32 order, int points);
        [Slot(215)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMap2xOES(System.Int32 target, int u1, int u2, Int32 ustride, Int32 uorder, int v1, int v2, Int32 vstride, Int32 vorder, int points);
        [Slot(216)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern IntPtr glMapBufferOES(System.Int32 target, System.Int32 access);
        [Slot(218)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMapGrid1xOES(Int32 n, int u1, int u2);
        [Slot(219)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMapGrid2xOES(Int32 n, int u1, int u2, int v1, int v2);
        [Slot(223)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMaterialxOES(System.Int32 face, System.Int32 pname, int param);
        [Slot(225)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMaterialxvOES(System.Int32 face, System.Int32 pname, int* param);
        [Slot(226)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMatrixIndexPointerOES(Int32 size, System.Int32 type, Int32 stride, IntPtr pointer);
        [Slot(230)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMultiTexCoord1bOES(System.Int32 texture, SByte s);
        [Slot(231)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultiTexCoord1bvOES(System.Int32 texture, SByte* coords);
        [Slot(232)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMultiTexCoord1xOES(System.Int32 texture, int s);
        [Slot(233)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultiTexCoord1xvOES(System.Int32 texture, int* coords);
        [Slot(234)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMultiTexCoord2bOES(System.Int32 texture, SByte s, SByte t);
        [Slot(235)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultiTexCoord2bvOES(System.Int32 texture, SByte* coords);
        [Slot(236)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMultiTexCoord2xOES(System.Int32 texture, int s, int t);
        [Slot(237)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultiTexCoord2xvOES(System.Int32 texture, int* coords);
        [Slot(238)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMultiTexCoord3bOES(System.Int32 texture, SByte s, SByte t, SByte r);
        [Slot(239)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultiTexCoord3bvOES(System.Int32 texture, SByte* coords);
        [Slot(240)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMultiTexCoord3xOES(System.Int32 texture, int s, int t, int r);
        [Slot(241)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultiTexCoord3xvOES(System.Int32 texture, int* coords);
        [Slot(242)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMultiTexCoord4bOES(System.Int32 texture, SByte s, SByte t, SByte r, SByte q);
        [Slot(243)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultiTexCoord4bvOES(System.Int32 texture, SByte* coords);
        [Slot(246)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMultiTexCoord4xOES(System.Int32 texture, int s, int t, int r, int q);
        [Slot(247)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultiTexCoord4xvOES(System.Int32 texture, int* coords);
        [Slot(250)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultMatrixxOES(int* m);
        [Slot(251)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultTransposeMatrixxOES(int* m);
        [Slot(254)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glNormal3xOES(int nx, int ny, int nz);
        [Slot(255)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glNormal3xvOES(int* coords);
        [Slot(258)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glOrthofOES(Single l, Single r, Single b, Single t, Single n, Single f);
        [Slot(260)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glOrthoxOES(int l, int r, int b, int t, int n, int f);
        [Slot(261)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPassThroughxOES(int token);
        [Slot(265)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPixelTransferxOES(System.Int32 pname, int param);
        [Slot(266)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPixelZoomxOES(int xfactor, int yfactor);
        [Slot(270)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPointParameterxOES(System.Int32 pname, int param);
        [Slot(272)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glPointParameterxvOES(System.Int32 pname, int* @params);
        [Slot(274)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPointSizePointerOES(System.Int32 type, Int32 stride, IntPtr pointer);
        [Slot(276)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPointSizexOES(int size);
        [Slot(279)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPolygonOffsetxOES(int factor, int units);
        [Slot(281)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glPrioritizeTexturesxOES(Int32 n, UInt32* textures, int* priorities);
        [Slot(283)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe Int32 glQueryMatrixxOES([OutAttribute] int* mantissa, [OutAttribute] Int32* exponent);
        [Slot(284)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRasterPos2xOES(int x, int y);
        [Slot(285)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glRasterPos2xvOES(int* coords);
        [Slot(286)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRasterPos3xOES(int x, int y, int z);
        [Slot(287)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glRasterPos3xvOES(int* coords);
        [Slot(288)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRasterPos4xOES(int x, int y, int z, int w);
        [Slot(289)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glRasterPos4xvOES(int* coords);
        [Slot(292)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRectxOES(int x1, int y1, int x2, int y2);
        [Slot(293)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glRectxvOES(int* v1, int* v2);
        [Slot(297)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRenderbufferStorageOES(System.Int32 target, System.Int32 internalformat, Int32 width, Int32 height);
        [Slot(301)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRotatexOES(int angle, int x, int y, int z);
        [Slot(303)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glSampleCoverageOES(int value, bool invert);
        [Slot(305)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glSampleCoveragexOES(int value, bool invert);
        [Slot(308)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glScalexOES(int x, int y, int z);
        [Slot(317)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexCoord1bOES(SByte s);
        [Slot(318)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexCoord1bvOES(SByte* coords);
        [Slot(319)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexCoord1xOES(int s);
        [Slot(320)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexCoord1xvOES(int* coords);
        [Slot(321)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexCoord2bOES(SByte s, SByte t);
        [Slot(322)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexCoord2bvOES(SByte* coords);
        [Slot(323)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexCoord2xOES(int s, int t);
        [Slot(324)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexCoord2xvOES(int* coords);
        [Slot(325)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexCoord3bOES(SByte s, SByte t, SByte r);
        [Slot(326)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexCoord3bvOES(SByte* coords);
        [Slot(327)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexCoord3xOES(int s, int t, int r);
        [Slot(328)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexCoord3xvOES(int* coords);
        [Slot(329)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexCoord4bOES(SByte s, SByte t, SByte r, SByte q);
        [Slot(330)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexCoord4bvOES(SByte* coords);
        [Slot(331)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexCoord4xOES(int s, int t, int r, int q);
        [Slot(332)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexCoord4xvOES(int* coords);
        [Slot(339)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexEnvxOES(System.Int32 target, System.Int32 pname, int param);
        [Slot(341)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexEnvxvOES(System.Int32 target, System.Int32 pname, int* @params);
        [Slot(342)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexGenfOES(System.Int32 coord, System.Int32 pname, Single param);
        [Slot(343)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexGenfvOES(System.Int32 coord, System.Int32 pname, Single* @params);
        [Slot(344)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexGeniOES(System.Int32 coord, System.Int32 pname, Int32 param);
        [Slot(345)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexGenivOES(System.Int32 coord, System.Int32 pname, Int32* @params);
        [Slot(346)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexGenxOES(System.Int32 coord, System.Int32 pname, int param);
        [Slot(347)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexGenxvOES(System.Int32 coord, System.Int32 pname, int* @params);
        [Slot(354)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexParameterxOES(System.Int32 target, System.Int32 pname, int param);
        [Slot(356)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexParameterxvOES(System.Int32 target, System.Int32 pname, int* @params);
        [Slot(366)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTranslatexOES(int x, int y, int z);
        [Slot(367)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool glUnmapBufferOES(System.Int32 target);
        [Slot(368)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glVertex2bOES(SByte x);
        [Slot(369)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glVertex2bvOES(SByte* coords);
        [Slot(370)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glVertex2xOES(int x);
        [Slot(371)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glVertex2xvOES(int* coords);
        [Slot(372)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glVertex3bOES(SByte x, SByte y);
        [Slot(373)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glVertex3bvOES(SByte* coords);
        [Slot(374)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glVertex3xOES(int x, int y);
        [Slot(375)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glVertex3xvOES(int* coords);
        [Slot(376)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glVertex4bOES(SByte x, SByte y, SByte z);
        [Slot(377)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glVertex4bvOES(SByte* coords);
        [Slot(378)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glVertex4xOES(int x, int y, int z);
        [Slot(379)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glVertex4xvOES(int* coords);
        [Slot(383)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glWeightPointerOES(Int32 size, System.Int32 type, Int32 stride, IntPtr pointer);
        [Slot(71)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDisableDriverControlQCOM(UInt32 driverControl);
        [Slot(87)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glEnableDriverControlQCOM(UInt32 driverControl);
        [Slot(88)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glEndTilingQCOM(UInt32 preserveMask);
        [Slot(93)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glExtGetBufferPointervQCOM(System.Int32 target, [OutAttribute] IntPtr @params);
        [Slot(94)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetBuffersQCOM([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers);
        [Slot(95)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetFramebuffersQCOM([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers);
        [Slot(96)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetProgramBinarySourceQCOM(UInt32 program, System.Int32 shadertype, [OutAttribute] IntPtr source, [OutAttribute] Int32* length);
        [Slot(97)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetProgramsQCOM([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms);
        [Slot(98)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetRenderbuffersQCOM([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers);
        [Slot(99)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetShadersQCOM([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders);
        [Slot(100)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetTexLevelParameterivQCOM(UInt32 texture, System.Int32 face, Int32 level, System.Int32 pname, [OutAttribute] Int32* @params);
        [Slot(101)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glExtGetTexSubImageQCOM(System.Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, System.Int32 format, System.Int32 type, [OutAttribute] IntPtr texels);
        [Slot(102)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetTexturesQCOM([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures);
        [Slot(103)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool glExtIsProgramBinaryQCOM(UInt32 program);
        [Slot(104)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glExtTexObjectStateOverrideiQCOM(System.Int32 target, System.Int32 pname, Int32 param);
        [Slot(141)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls);
        [Slot(142)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] IntPtr driverControlString);
        [Slot(312)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glStartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);
    }
}
