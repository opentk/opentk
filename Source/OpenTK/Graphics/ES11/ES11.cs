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
            public static extern OpenTK.Graphics.ES11.All ClientWaitSync(IntPtr sync, Int32 flags, Int64 timeout);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glClientWaitSyncAPPLE")]
            public static extern OpenTK.Graphics.ES11.All ClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);

            /// <summary>[requires: APPLE_copy_texture_levels]</summary>
            [AutoGenerated(Category = "APPLE_copy_texture_levels", Version = "", EntryPoint = "glCopyTextureLevelsAPPLE")]
            public static extern void CopyTextureLevel(Int32 destinationTexture, Int32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);

            /// <summary>[requires: APPLE_copy_texture_levels]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "APPLE_copy_texture_levels", Version = "", EntryPoint = "glCopyTextureLevelsAPPLE")]
            public static extern void CopyTextureLevel(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);

            /// <summary>[requires: APPLE_sync]
            /// Delete a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// The sync object to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glDeleteSyncAPPLE")]
            public static extern void DeleteSync(IntPtr sync);

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
            public static extern IntPtr FenceSync(OpenTK.Graphics.ES11.All condition, Int32 flags);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glFenceSyncAPPLE")]
            public static extern IntPtr FenceSync(OpenTK.Graphics.ES11.All condition, UInt32 flags);

            /// <summary>[requires: APPLE_sync]</summary>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetInteger64vAPPLE")]
            public static extern Int64 GetInteger64(OpenTK.Graphics.ES11.All pname);

            /// <summary>[requires: APPLE_sync]</summary>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetInteger64vAPPLE")]
            public static extern void GetInteger64(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int64[] @params);

            /// <summary>[requires: APPLE_sync]</summary>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetInteger64vAPPLE")]
            public static extern void GetInteger64(OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int64 @params);

            /// <summary>[requires: APPLE_sync]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetInteger64vAPPLE")]
            public static extern unsafe void GetInteger64(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int64* @params);

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
            public static extern void GetSync(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] values);

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
            public static extern void GetSync(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out Int32 values);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetSyncivAPPLE")]
            public static extern unsafe void GetSync(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);

            /// <summary>[requires: APPLE_sync]
            /// Determine if a name corresponds to a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies a value that may be the name of a sync object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glIsSyncAPPLE")]
            public static extern bool IsSync(IntPtr sync);

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
            public static extern void RenderbufferStorageMultisample(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);

            /// <summary>[requires: APPLE_framebuffer_multisample]</summary>
            [AutoGenerated(Category = "APPLE_framebuffer_multisample", Version = "", EntryPoint = "glResolveMultisampleFramebufferAPPLE")]
            public static extern void ResolveMultisampleFramebuffer();

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
            public static extern void WaitSync(IntPtr sync, Int32 flags, Int64 timeout);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glWaitSyncAPPLE")]
            public static extern void WaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);

        }

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least 80. texture must be one of GL_TEXTUREi, where i ranges from 0 (GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS - 1). The initial value is GL_TEXTURE0.
        /// </para>
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glActiveTexture")]
        public static extern void ActiveTexture(OpenTK.Graphics.ES11.All texture);

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least 80. texture must be one of GL_TEXTUREi, where i ranges from 0 (GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS - 1). The initial value is GL_TEXTURE0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glActiveTexture")]
        public static extern void ActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture);

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
        public static extern void AlphaFunc(OpenTK.Graphics.ES11.All func, Single @ref);

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
        public static extern void AlphaFunc(OpenTK.Graphics.ES11.AlphaFunction func, Single @ref);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glAlphaFuncx")]
        public static extern void AlphaFuncx(OpenTK.Graphics.ES11.All func, int @ref);

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
        public static extern void BindBuffer(OpenTK.Graphics.ES11.All target, Int32 buffer);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindBuffer")]
        public static extern void BindBuffer(OpenTK.Graphics.ES11.All target, UInt32 buffer);

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
        public static extern void BindTexture(OpenTK.Graphics.ES11.All target, Int32 texture);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindTexture")]
        public static extern void BindTexture(OpenTK.Graphics.ES11.All target, UInt32 texture);

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
        public static extern void BindTexture(OpenTK.Graphics.ES11.TextureTarget target, Int32 texture);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindTexture")]
        public static extern void BindTexture(OpenTK.Graphics.ES11.TextureTarget target, UInt32 texture);

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
        public static extern void BlendFunc(OpenTK.Graphics.ES11.All sfactor, OpenTK.Graphics.ES11.All dfactor);

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
        public static extern void BlendFunc(OpenTK.Graphics.ES11.BlendingFactorSrc sfactor, OpenTK.Graphics.ES11.BlendingFactorDest dfactor);

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
        public static extern void BufferData(OpenTK.Graphics.ES11.All target, IntPtr size, IntPtr data, OpenTK.Graphics.ES11.All usage);

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
        public static extern void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] T2[] data, OpenTK.Graphics.ES11.All usage)
            where T2 : struct
        ;

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
        public static extern void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] T2[,] data, OpenTK.Graphics.ES11.All usage)
            where T2 : struct
        ;

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
        public static extern void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] T2[,,] data, OpenTK.Graphics.ES11.All usage)
            where T2 : struct
        ;

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
        public static extern void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] ref T2 data, OpenTK.Graphics.ES11.All usage)
            where T2 : struct
        ;

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
        public static extern void BufferSubData(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, IntPtr data);

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
        public static extern void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[] data)
            where T3 : struct
        ;

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
        public static extern void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[,] data)
            where T3 : struct
        ;

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
        public static extern void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[,,] data)
            where T3 : struct
        ;

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
        public static extern void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] ref T3 data)
            where T3 : struct
        ;

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
        public static extern void Clear(OpenTK.Graphics.ES11.All mask);

        /// <summary>[requires: v1.0]
        /// Clear buffers to preset values
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClear")]
        public static extern void Clear(OpenTK.Graphics.ES11.ClearBufferMask mask);

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
        public static extern void Clear(Int32 mask);

        /// <summary>[requires: v1.0]
        /// Clear buffers to preset values
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT.
        /// </para>
        /// </param>
        [Obsolete("Use ClearMask overload instead")]
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClear")]
        public static extern void Clear(UInt32 mask);

        /// <summary>[requires: v1.0]
        /// Specify clear values for the color buffers
        /// </summary>
        /// <param name="red">
        /// <para>
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearColor")]
        public static extern void ClearColor(Single red, Single green, Single blue, Single alpha);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearColorx")]
        public static extern void ClearColorx(int red, int green, int blue, int alpha);

        /// <summary>[requires: v1.0]
        /// Specify the clear value for the depth buffer
        /// </summary>
        /// <param name="depth">
        /// <para>
        /// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearDepthf")]
        public static extern void ClearDepth(Single d);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearDepthx")]
        public static extern void ClearDepthx(int depth);

        /// <summary>[requires: v1.0]
        /// Specify the clear value for the stencil buffer
        /// </summary>
        /// <param name="s">
        /// <para>
        /// Specifies the index used when the stencil buffer is cleared. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearStencil")]
        public static extern void ClearStencil(Int32 s);

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
        public static extern void ClientActiveTexture(OpenTK.Graphics.ES11.All texture);

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least two. texture must be one of GL_TEXTURE, where i ranges from 0 to the value of GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value. The initial value is GL_TEXTURE0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClientActiveTexture")]
        public static extern void ClientActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture);

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
        public static extern void ClipPlane(OpenTK.Graphics.ES11.All p, Single[] eqn);

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
        public static extern void ClipPlane(OpenTK.Graphics.ES11.All p, ref Single eqn);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanef")]
        public static extern unsafe void ClipPlane(OpenTK.Graphics.ES11.All p, Single* eqn);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanex")]
        public static extern void ClipPlanex(OpenTK.Graphics.ES11.All plane, int[] equation);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanex")]
        public static extern void ClipPlanex(OpenTK.Graphics.ES11.All plane, ref int equation);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanex")]
        public static extern unsafe void ClipPlanex(OpenTK.Graphics.ES11.All plane, int* equation);

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
        public static extern void Color4(Single red, Single green, Single blue, Single alpha);

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
        public static extern void Color4(Byte red, Byte green, Byte blue, Byte alpha);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColor4x")]
        public static extern void Color4x(int red, int green, int blue, int alpha);

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
        public static extern void ColorMask(bool red, bool green, bool blue, bool alpha);

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
        public static extern void ColorPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);

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
        public static extern void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
        ;

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
        public static extern void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
        ;

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
        public static extern void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
        ;

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
        public static extern void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
        ;

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
        public static extern void ColorPointer(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, IntPtr pointer);

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
        public static extern void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
        ;

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
        public static extern void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
        ;

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
        public static extern void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
        ;

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
        public static extern void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
        ;

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
        public static extern void CompressedTexImage2D(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);

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
        public static extern void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[] data)
            where T7 : struct
        ;

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
        public static extern void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,] data)
            where T7 : struct
        ;

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
        public static extern void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,,] data)
            where T7 : struct
        ;

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
        public static extern void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] ref T7 data)
            where T7 : struct
        ;

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
        public static extern void CompressedTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);

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
        public static extern void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[] data)
            where T7 : struct
        ;

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
        public static extern void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,] data)
            where T7 : struct
        ;

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
        public static extern void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,,] data)
            where T7 : struct
        ;

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
        public static extern void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] ref T7 data)
            where T7 : struct
        ;

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
        public static extern void CompressedTexSubImage2D(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, IntPtr data);

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
        public static extern void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, [InAttribute, OutAttribute] T8[] data)
            where T8 : struct
        ;

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
        public static extern void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, [InAttribute, OutAttribute] T8[,] data)
            where T8 : struct
        ;

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
        public static extern void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, [InAttribute, OutAttribute] T8[,,] data)
            where T8 : struct
        ;

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
        public static extern void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, [InAttribute, OutAttribute] ref T8 data)
            where T8 : struct
        ;

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
        public static extern void CompressedTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, IntPtr data);

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
        public static extern void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[] data)
            where T8 : struct
        ;

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
        public static extern void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[,] data)
            where T8 : struct
        ;

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
        public static extern void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[,,] data)
            where T8 : struct
        ;

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
        public static extern void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] ref T8 data)
            where T8 : struct
        ;

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
        public static extern void CopyTexImage2D(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

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
        public static extern void CopyTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

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
        public static extern void CopyTexSubImage2D(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

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
        public static extern void CopyTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

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
        public static extern void CullFace(OpenTK.Graphics.ES11.All mode);

        /// <summary>[requires: v1.0]
        /// Specify whether front- or back-facing facets can be culled
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies whether front- or back-facing facets are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCullFace")]
        public static extern void CullFace(OpenTK.Graphics.ES11.CullFaceMode mode);

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
        public static extern void DeleteBuffer(Int32 buffers);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        public static extern void DeleteBuffer(UInt32 buffers);

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
        public static extern void DeleteBuffers(Int32 n, Int32[] buffers);

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
        public static extern void DeleteBuffers(Int32 n, ref Int32 buffers);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        public static extern unsafe void DeleteBuffers(Int32 n, Int32* buffers);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        public static extern void DeleteBuffers(Int32 n, UInt32[] buffers);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        public static extern void DeleteBuffers(Int32 n, ref UInt32 buffers);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        public static extern unsafe void DeleteBuffers(Int32 n, UInt32* buffers);

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
        public static extern void DeleteTexture(Int32 textures);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        public static extern void DeleteTexture(UInt32 textures);

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
        public static extern void DeleteTextures(Int32 n, Int32[] textures);

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
        public static extern void DeleteTextures(Int32 n, ref Int32 textures);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        public static extern unsafe void DeleteTextures(Int32 n, Int32* textures);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        public static extern void DeleteTextures(Int32 n, UInt32[] textures);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        public static extern void DeleteTextures(Int32 n, ref UInt32 textures);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        public static extern unsafe void DeleteTextures(Int32 n, UInt32* textures);

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
        public static extern void DepthFunc(OpenTK.Graphics.ES11.All func);

        /// <summary>[requires: v1.0]
        /// Specify the value used for depth buffer comparisons
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthFunc")]
        public static extern void DepthFunc(OpenTK.Graphics.ES11.DepthFunction func);

        /// <summary>[requires: v1.0]
        /// Enable or disable writing into the depth buffer
        /// </summary>
        /// <param name="flag">
        /// <para>
        /// Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthMask")]
        public static extern void DepthMask(bool flag);

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
        public static extern void DepthRange(Single n, Single f);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthRangex")]
        public static extern void DepthRangex(int n, int f);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisable")]
        public static extern void Disable(OpenTK.Graphics.ES11.All cap);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisable")]
        public static extern void Disable(OpenTK.Graphics.ES11.EnableCap cap);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisableClientState")]
        public static extern void DisableClientState(OpenTK.Graphics.ES11.All array);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisableClientState")]
        public static extern void DisableClientState(OpenTK.Graphics.ES11.EnableCap array);

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
        public static extern void DrawArrays(OpenTK.Graphics.ES11.All mode, Int32 first, Int32 count);

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
        public static extern void DrawArrays(OpenTK.Graphics.ES11.BeginMode mode, Int32 first, Int32 count);

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
        public static extern void DrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 first, Int32 count);

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
        public static extern void DrawElements(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices);

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
        public static extern void DrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices)
            where T3 : struct
        ;

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
        public static extern void DrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices)
            where T3 : struct
        ;

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
        public static extern void DrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices)
            where T3 : struct
        ;

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
        public static extern void DrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices)
            where T3 : struct
        ;

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
        public static extern void DrawElements(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices);

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
        public static extern void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices)
            where T3 : struct
        ;

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
        public static extern void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices)
            where T3 : struct
        ;

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
        public static extern void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices)
            where T3 : struct
        ;

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
        public static extern void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices)
            where T3 : struct
        ;

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
        public static extern void DrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices);

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
        public static extern void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices)
            where T3 : struct
        ;

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
        public static extern void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices)
            where T3 : struct
        ;

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
        public static extern void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices)
            where T3 : struct
        ;

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
        public static extern void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices)
            where T3 : struct
        ;

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
        public static extern void Enable(OpenTK.Graphics.ES11.All cap);

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
        public static extern void Enable(OpenTK.Graphics.ES11.EnableCap cap);

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
        public static extern void EnableClientState(OpenTK.Graphics.ES11.All array);

        /// <summary>[requires: v1.0]
        /// Enable or disable client-side capability
        /// </summary>
        /// <param name="cap">
        /// <para>
        /// Specifies the capability to enable. Symbolic constants GL_COLOR_ARRAY, GL_EDGE_FLAG_ARRAY, GL_FOG_COORD_ARRAY, GL_INDEX_ARRAY, GL_NORMAL_ARRAY, GL_SECONDARY_COLOR_ARRAY, GL_TEXTURE_COORD_ARRAY, and GL_VERTEX_ARRAY are accepted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glEnableClientState")]
        public static extern void EnableClientState(OpenTK.Graphics.ES11.EnableCap array);

        /// <summary>[requires: v1.0]
        /// Block until all GL execution is complete
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFinish")]
        public static extern void Finish();

        /// <summary>[requires: v1.0]
        /// Force execution of GL commands in finite time
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFlush")]
        public static extern void Flush();

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
        public static extern void Fog(OpenTK.Graphics.ES11.All pname, Single param);

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
        public static extern void Fog(OpenTK.Graphics.ES11.FogParameter pname, Single param);

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
        public static extern void Fog(OpenTK.Graphics.ES11.All pname, Single[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogfv")]
        public static extern unsafe void Fog(OpenTK.Graphics.ES11.All pname, Single* @params);

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
        public static extern void Fog(OpenTK.Graphics.ES11.FogParameter pname, Single[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogfv")]
        public static extern unsafe void Fog(OpenTK.Graphics.ES11.FogParameter pname, Single* @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogx")]
        public static extern void Fogx(OpenTK.Graphics.ES11.All pname, int param);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogxv")]
        public static extern void Fogx(OpenTK.Graphics.ES11.All pname, int[] param);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogxv")]
        public static extern unsafe void Fogx(OpenTK.Graphics.ES11.All pname, int* param);

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
        public static extern void FrontFace(OpenTK.Graphics.ES11.All mode);

        /// <summary>[requires: v1.0]
        /// Define front- and back-facing polygons
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFrontFace")]
        public static extern void FrontFace(OpenTK.Graphics.ES11.FrontFaceDirection mode);

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
        public static extern void Frustum(Single l, Single r, Single b, Single t, Single n, Single f);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFrustumx")]
        public static extern void Frustumx(int l, int r, int b, int t, int n, int f);

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
        public static extern Int32 GenBuffer();

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
        public static extern void GenBuffers(Int32 n, [OutAttribute] Int32[] buffers);

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
        public static extern void GenBuffers(Int32 n, [OutAttribute] out Int32 buffers);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        public static extern unsafe void GenBuffers(Int32 n, [OutAttribute] Int32* buffers);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(Int32 n, [OutAttribute] UInt32[] buffers);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(Int32 n, [OutAttribute] out UInt32 buffers);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        public static extern unsafe void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);

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
        public static extern Int32 GenTexture();

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
        public static extern void GenTextures(Int32 n, [OutAttribute] Int32[] textures);

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
        public static extern void GenTextures(Int32 n, [OutAttribute] out Int32 textures);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        public static extern unsafe void GenTextures(Int32 n, [OutAttribute] Int32* textures);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        public static extern void GenTextures(Int32 n, [OutAttribute] UInt32[] textures);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        public static extern void GenTextures(Int32 n, [OutAttribute] out UInt32 textures);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        public static extern unsafe void GenTextures(Int32 n, [OutAttribute] UInt32* textures);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        public static extern bool GetBoolean(OpenTK.Graphics.ES11.All pname);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        public static extern bool GetBoolean(OpenTK.Graphics.ES11.GetPName pname);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        public static extern void GetBoolean(OpenTK.Graphics.ES11.All pname, [OutAttribute] bool[] data);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        public static extern void GetBoolean(OpenTK.Graphics.ES11.All pname, [OutAttribute] out bool data);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        public static extern unsafe void GetBoolean(OpenTK.Graphics.ES11.All pname, [OutAttribute] bool* data);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        public static extern void GetBoolean(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool[] data);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        public static extern void GetBoolean(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] out bool data);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        public static extern unsafe void GetBoolean(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool* data);

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
        public static extern void GetBufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params);

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
        public static extern void GetBufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBufferParameteriv")]
        public static extern unsafe void GetBufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);

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
        public static extern Single GetClipPlane(OpenTK.Graphics.ES11.All plane);

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
        public static extern void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single[] equation);

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
        public static extern void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] out Single equation);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanef")]
        public static extern unsafe void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        public static extern int GetClipPlanex(OpenTK.Graphics.ES11.All plane);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        public static extern void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int[] equation);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        public static extern void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] out int equation);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        public static extern unsafe void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation);

        /// <summary>[requires: v1.0]
        /// Return error information
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetError")]
        public static extern OpenTK.Graphics.ES11.ErrorCode GetError();

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        public static extern int GetFixed(OpenTK.Graphics.ES11.All pname);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        public static extern void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        public static extern void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        public static extern unsafe void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        public static extern Single GetFloat(OpenTK.Graphics.ES11.All pname);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        public static extern Single GetFloat(OpenTK.Graphics.ES11.GetPName pname);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        public static extern void GetFloat(OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] data);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        public static extern void GetFloat(OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single data);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        public static extern unsafe void GetFloat(OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* data);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        public static extern void GetFloat(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single[] data);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        public static extern void GetFloat(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] out Single data);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        public static extern unsafe void GetFloat(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single* data);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        public static extern Int32 GetInteger(OpenTK.Graphics.ES11.All pname);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        public static extern Int32 GetInteger(OpenTK.Graphics.ES11.GetPName pname);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        public static extern void GetInteger(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] data);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        public static extern void GetInteger(OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 data);

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        public static extern unsafe void GetInteger(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* data);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        public static extern void GetInteger(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32[] data);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        public static extern void GetInteger(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] out Int32 data);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        public static extern unsafe void GetInteger(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32* data);

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
        public static extern void GetLight(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params);

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
        public static extern void GetLight(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        public static extern unsafe void GetLight(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params);

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
        public static extern void GetLight(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single[] @params);

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
        public static extern void GetLight(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] out Single @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        public static extern unsafe void GetLight(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single* @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightxv")]
        public static extern void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightxv")]
        public static extern void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightxv")]
        public static extern unsafe void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

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
        public static extern void GetMaterial(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params);

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
        public static extern void GetMaterial(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        public static extern unsafe void GetMaterial(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params);

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
        public static extern void GetMaterial(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single[] @params);

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
        public static extern void GetMaterial(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] out Single @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        public static extern unsafe void GetMaterial(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single* @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialxv")]
        public static extern void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialxv")]
        public static extern void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialxv")]
        public static extern unsafe void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetPixelMapxv")]
        public static extern void GetPixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] int[] values);

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetPixelMapxv")]
        public static extern void GetPixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] out int values);

        /// <summary></summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetPixelMapxv")]
        public static extern unsafe void GetPixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] int* values);

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
        public static extern void GetPointer(OpenTK.Graphics.ES11.All pname, [OutAttribute] IntPtr @params);

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
        public static extern void GetPointer<T1>(OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T1[] @params)
            where T1 : struct
        ;

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
        public static extern void GetPointer<T1>(OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T1[,] @params)
            where T1 : struct
        ;

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
        public static extern void GetPointer<T1>(OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T1[,,] @params)
            where T1 : struct
        ;

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
        public static extern void GetPointer<T1>(OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] ref T1 @params)
            where T1 : struct
        ;

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
        public static extern void GetPointer(OpenTK.Graphics.ES11.GetPointervPName pname, [OutAttribute] IntPtr @params);

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
        public static extern void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] T1[] @params)
            where T1 : struct
        ;

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
        public static extern void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] T1[,] @params)
            where T1 : struct
        ;

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
        public static extern void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] T1[,,] @params)
            where T1 : struct
        ;

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
        public static extern void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] ref T1 @params)
            where T1 : struct
        ;

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
        public static extern String GetString(OpenTK.Graphics.ES11.All name);

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
        public static extern String GetString(OpenTK.Graphics.ES11.StringName name);

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
        public static extern void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params);

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
        public static extern void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        public static extern unsafe void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params);

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
        public static extern void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single[] @params);

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
        public static extern void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] out Single @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        public static extern unsafe void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single* @params);

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
        public static extern void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params);

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
        public static extern void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        public static extern unsafe void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);

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
        public static extern void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32[] @params);

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
        public static extern void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] out Int32 @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        public static extern unsafe void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvxv")]
        public static extern void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvxv")]
        public static extern void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvxv")]
        public static extern unsafe void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

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
        public static extern void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params);

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
        public static extern void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        public static extern unsafe void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params);

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
        public static extern void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single[] @params);

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
        public static extern void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] out Single @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        public static extern unsafe void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single* @params);

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
        public static extern void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params);

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
        public static extern void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        public static extern unsafe void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);

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
        public static extern void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32[] @params);

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
        public static extern void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] out Int32 @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        public static extern unsafe void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32* @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterxv")]
        public static extern void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterxv")]
        public static extern void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterxv")]
        public static extern unsafe void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

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
        public static extern void Hint(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All mode);

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
        public static extern void Hint(OpenTK.Graphics.ES11.HintTarget target, OpenTK.Graphics.ES11.HintMode mode);

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a buffer object
        /// </summary>
        /// <param name="buffer">
        /// <para>
        /// Specifies a value that may be the name of a buffer object.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsBuffer")]
        public static extern bool IsBuffer(Int32 buffer);

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a buffer object
        /// </summary>
        /// <param name="buffer">
        /// <para>
        /// Specifies a value that may be the name of a buffer object.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsBuffer")]
        public static extern bool IsBuffer(UInt32 buffer);

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
        public static extern bool IsEnabled(OpenTK.Graphics.ES11.All cap);

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
        public static extern bool IsEnabled(OpenTK.Graphics.ES11.EnableCap cap);

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a texture
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies a value that may be the name of a texture.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsTexture")]
        public static extern bool IsTexture(Int32 texture);

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a texture
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies a value that may be the name of a texture.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsTexture")]
        public static extern bool IsTexture(UInt32 texture);

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
        public static extern void Light(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, Single param);

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
        public static extern void Light(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single param);

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
        public static extern void Light(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, Single[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightfv")]
        public static extern unsafe void Light(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, Single* @params);

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
        public static extern void Light(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightfv")]
        public static extern unsafe void Light(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single* @params);

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
        public static extern void LightModel(OpenTK.Graphics.ES11.All pname, Single param);

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
        public static extern void LightModel(OpenTK.Graphics.ES11.LightModelParameter pname, Single param);

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
        public static extern void LightModel(OpenTK.Graphics.ES11.All pname, Single[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelfv")]
        public static extern unsafe void LightModel(OpenTK.Graphics.ES11.All pname, Single* @params);

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
        public static extern void LightModel(OpenTK.Graphics.ES11.LightModelParameter pname, Single[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelfv")]
        public static extern unsafe void LightModel(OpenTK.Graphics.ES11.LightModelParameter pname, Single* @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelx")]
        public static extern void LightModelx(OpenTK.Graphics.ES11.All pname, int param);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelxv")]
        public static extern void LightModelx(OpenTK.Graphics.ES11.All pname, int[] param);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelxv")]
        public static extern unsafe void LightModelx(OpenTK.Graphics.ES11.All pname, int* param);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightx")]
        public static extern void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightxv")]
        public static extern void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int[] @params);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightxv")]
        public static extern unsafe void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params);

        /// <summary>[requires: v1.0]
        /// Specify the width of rasterized lines
        /// </summary>
        /// <param name="width">
        /// <para>
        /// Specifies the width of rasterized lines. The initial value is 1.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLineWidth")]
        public static extern void LineWidth(Single width);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLineWidthx")]
        public static extern void LineWidthx(int width);

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the identity matrix
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadIdentity")]
        public static extern void LoadIdentity();

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixf")]
        public static extern void LoadMatrix(Single[] m);

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixf")]
        public static extern void LoadMatrix(ref Single m);

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixf")]
        public static extern unsafe void LoadMatrix(Single* m);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixx")]
        public static extern void LoadMatrixx(int[] m);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixx")]
        public static extern void LoadMatrixx(ref int m);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixx")]
        public static extern unsafe void LoadMatrixx(int* m);

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
        public static extern void LogicOp(OpenTK.Graphics.ES11.All opcode);

        /// <summary>[requires: v1.0]
        /// Specify a logical pixel operation for rendering
        /// </summary>
        /// <param name="opcode">
        /// <para>
        /// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: GL_CLEAR, GL_SET, GL_COPY, GL_COPY_INVERTED, GL_NOOP, GL_INVERT, GL_AND, GL_NAND, GL_OR, GL_NOR, GL_XOR, GL_EQUIV, GL_AND_REVERSE, GL_AND_INVERTED, GL_OR_REVERSE, and GL_OR_INVERTED. The initial value is GL_COPY.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLogicOp")]
        public static extern void LogicOp(OpenTK.Graphics.ES11.LogicOp opcode);

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
        public static extern void Material(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, Single param);

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
        public static extern void Material(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single param);

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
        public static extern void Material(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, Single[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialfv")]
        public static extern unsafe void Material(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, Single* @params);

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
        public static extern void Material(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialfv")]
        public static extern unsafe void Material(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single* @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialx")]
        public static extern void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialxv")]
        public static extern void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int[] param);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialxv")]
        public static extern unsafe void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param);

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
        public static extern void MatrixMode(OpenTK.Graphics.ES11.All mode);

        /// <summary>[requires: v1.0]
        /// Specify which matrix is the current matrix
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies which matrix stack is the target for subsequent matrix operations. Three values are accepted: GL_MODELVIEW, GL_PROJECTION, and GL_TEXTURE. The initial value is GL_MODELVIEW. Additionally, if the ARB_imaging extension is supported, GL_COLOR is also accepted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMatrixMode")]
        public static extern void MatrixMode(OpenTK.Graphics.ES11.MatrixMode mode);

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
        public static extern void MultiTexCoord4(OpenTK.Graphics.ES11.All target, Single s, Single t, Single r, Single q);

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
        public static extern void MultiTexCoord4(OpenTK.Graphics.ES11.TextureUnit target, Single s, Single t, Single r, Single q);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultiTexCoord4x")]
        public static extern void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q);

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Points to 16 consecutive values that are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixf")]
        public static extern void MultMatrix(Single[] m);

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Points to 16 consecutive values that are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixf")]
        public static extern void MultMatrix(ref Single m);

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Points to 16 consecutive values that are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixf")]
        public static extern unsafe void MultMatrix(Single* m);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixx")]
        public static extern void MultMatrixx(int[] m);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixx")]
        public static extern void MultMatrixx(ref int m);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixx")]
        public static extern unsafe void MultMatrixx(int* m);

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
        public static extern void Normal3(Single nx, Single ny, Single nz);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormal3x")]
        public static extern void Normal3x(int nx, int ny, int nz);

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
        public static extern void NormalPointer(OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);

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
        public static extern void NormalPointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[] pointer)
            where T2 : struct
        ;

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
        public static extern void NormalPointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,] pointer)
            where T2 : struct
        ;

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
        public static extern void NormalPointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,,] pointer)
            where T2 : struct
        ;

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
        public static extern void NormalPointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T2 pointer)
            where T2 : struct
        ;

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
        public static extern void NormalPointer(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, IntPtr pointer);

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
        public static extern void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[] pointer)
            where T2 : struct
        ;

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
        public static extern void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[,] pointer)
            where T2 : struct
        ;

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
        public static extern void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[,,] pointer)
            where T2 : struct
        ;

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
        public static extern void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T2 pointer)
            where T2 : struct
        ;

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
        public static extern void Ortho(Single l, Single r, Single b, Single t, Single n, Single f);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glOrthox")]
        public static extern void Orthox(int l, int r, int b, int t, int n, int f);

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelMapx")]
        public static extern void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, int[] values);

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelMapx")]
        public static extern void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, ref int values);

        /// <summary></summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelMapx")]
        public static extern unsafe void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, int* values);

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
        public static extern void PixelStore(OpenTK.Graphics.ES11.All pname, Int32 param);

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
        public static extern void PixelStore(OpenTK.Graphics.ES11.PixelStoreParameter pname, Int32 param);

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelStorex")]
        public static extern void PixelStorex(OpenTK.Graphics.ES11.All pname, int param);

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
        public static extern void PointParameter(OpenTK.Graphics.ES11.All pname, Single param);

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
        public static extern void PointParameter(OpenTK.Graphics.ES11.All pname, Single[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterfv")]
        public static extern unsafe void PointParameter(OpenTK.Graphics.ES11.All pname, Single* @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterx")]
        public static extern void PointParameterx(OpenTK.Graphics.ES11.All pname, int param);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterxv")]
        public static extern void PointParameterx(OpenTK.Graphics.ES11.All pname, int[] @params);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterxv")]
        public static extern unsafe void PointParameterx(OpenTK.Graphics.ES11.All pname, int* @params);

        /// <summary>[requires: v1.0]
        /// Specify the diameter of rasterized points
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the diameter of rasterized points. The initial value is 1.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointSize")]
        public static extern void PointSize(Single size);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointSizex")]
        public static extern void PointSizex(int size);

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
        public static extern void PolygonOffset(Single factor, Single units);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPolygonOffsetx")]
        public static extern void PolygonOffsetx(int factor, int units);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPopMatrix")]
        public static extern void PopMatrix();

        /// <summary>[requires: v1.0]
        /// Push and pop the current matrix stack
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPushMatrix")]
        public static extern void PushMatrix();

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
        public static extern void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [OutAttribute] IntPtr pixels);

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
        public static extern void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T6[] pixels)
            where T6 : struct
        ;

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
        public static extern void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T6[,] pixels)
            where T6 : struct
        ;

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
        public static extern void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T6[,,] pixels)
            where T6 : struct
        ;

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
        public static extern void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T6 pixels)
            where T6 : struct
        ;

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
        public static extern void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [OutAttribute] IntPtr pixels);

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
        public static extern void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T6[] pixels)
            where T6 : struct
        ;

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
        public static extern void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T6[,] pixels)
            where T6 : struct
        ;

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
        public static extern void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T6[,,] pixels)
            where T6 : struct
        ;

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
        public static extern void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] ref T6 pixels)
            where T6 : struct
        ;

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
        public static extern void Rotate(Single angle, Single x, Single y, Single z);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glRotatex")]
        public static extern void Rotatex(int angle, int x, int y, int z);

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
        public static extern void SampleCoverage(Single value, bool invert);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glSampleCoveragex")]
        public static extern void SampleCoveragex(int value, bool invert);

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a general scaling matrix
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify scale factors along the x, y, and z axes, respectively.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glScalef")]
        public static extern void Scale(Single x, Single y, Single z);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glScalex")]
        public static extern void Scalex(int x, int y, int z);

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
        public static extern void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);

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
        public static extern void ShadeModel(OpenTK.Graphics.ES11.All mode);

        /// <summary>[requires: v1.0]
        /// Select flat or smooth shading
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies a symbolic value representing a shading technique. Accepted values are GL_FLAT and GL_SMOOTH. The initial value is GL_SMOOTH.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glShadeModel")]
        public static extern void ShadeModel(OpenTK.Graphics.ES11.ShadingModel mode);

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
        public static extern void StencilFunc(OpenTK.Graphics.ES11.All func, Int32 @ref, Int32 mask);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilFunc")]
        public static extern void StencilFunc(OpenTK.Graphics.ES11.All func, Int32 @ref, UInt32 mask);

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
        public static extern void StencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, Int32 mask);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilFunc")]
        public static extern void StencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, UInt32 mask);

        /// <summary>[requires: v1.0]
        /// Control the front and back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilMask")]
        public static extern void StencilMask(Int32 mask);

        /// <summary>[requires: v1.0]
        /// Control the front and back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilMask")]
        public static extern void StencilMask(UInt32 mask);

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
        public static extern void StencilOp(OpenTK.Graphics.ES11.All fail, OpenTK.Graphics.ES11.All zfail, OpenTK.Graphics.ES11.All zpass);

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
        public static extern void StencilOp(OpenTK.Graphics.ES11.StencilOp fail, OpenTK.Graphics.ES11.StencilOp zfail, OpenTK.Graphics.ES11.StencilOp zpass);

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
        public static extern void TexCoordPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);

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
        public static extern void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
        ;

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
        public static extern void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
        ;

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
        public static extern void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
        ;

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
        public static extern void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
        ;

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
        public static extern void TexCoordPointer(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, IntPtr pointer);

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
        public static extern void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
        ;

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
        public static extern void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
        ;

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
        public static extern void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
        ;

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
        public static extern void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
        ;

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
        public static extern void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single param);

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
        public static extern void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single param);

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
        public static extern void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        public static extern unsafe void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single* @params);

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
        public static extern void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        public static extern unsafe void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single* @params);

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
        public static extern void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param);

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
        public static extern void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32 param);

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
        public static extern void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        public static extern unsafe void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32* @params);

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
        public static extern void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        public static extern unsafe void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32* @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvx")]
        public static extern void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvxv")]
        public static extern void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvxv")]
        public static extern unsafe void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);

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
        public static extern void TexImage2D(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, IntPtr pixels);

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
        public static extern void TexImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
        ;

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
        public static extern void TexImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
        ;

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
        public static extern void TexImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
        ;

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
        public static extern void TexImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
        ;

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
        public static extern void TexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels);

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
        public static extern void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
        ;

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
        public static extern void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
        ;

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
        public static extern void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
        ;

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
        public static extern void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
        ;

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
        public static extern void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single param);

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
        public static extern void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single param);

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
        public static extern void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        public static extern unsafe void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single* @params);

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
        public static extern void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        public static extern unsafe void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single* @params);

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
        public static extern void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param);

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
        public static extern void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32 param);

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
        public static extern void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        public static extern unsafe void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32* @params);

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
        public static extern void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32[] @params);

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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        public static extern unsafe void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32* @params);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterx")]
        public static extern void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterxv")]
        public static extern void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params);

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterxv")]
        public static extern unsafe void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);

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
        public static extern void TexSubImage2D(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, IntPtr pixels);

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
        public static extern void TexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
        ;

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
        public static extern void TexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
        ;

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
        public static extern void TexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
        ;

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
        public static extern void TexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
        ;

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
        public static extern void TexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels);

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
        public static extern void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
        ;

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
        public static extern void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
        ;

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
        public static extern void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
        ;

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
        public static extern void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
        ;

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a translation matrix
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the x, y, and z coordinates of a translation vector.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTranslatef")]
        public static extern void Translate(Single x, Single y, Single z);

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTranslatex")]
        public static extern void Translatex(int x, int y, int z);

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
        public static extern void VertexPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);

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
        public static extern void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
        ;

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
        public static extern void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
        ;

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
        public static extern void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
        ;

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
        public static extern void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
        ;

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
        public static extern void VertexPointer(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, IntPtr pointer);

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
        public static extern void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
        ;

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
        public static extern void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
        ;

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
        public static extern void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
        ;

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
        public static extern void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
        ;

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
        public static extern void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);

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
            [AutoGenerated(Category = "EXT_blend_minmax", Version = "", EntryPoint = "glBlendEquationEXT")]
            public static extern void BlendEquation(OpenTK.Graphics.ES11.All mode);

            /// <summary>[requires: EXT_discard_framebuffer]</summary>
            [AutoGenerated(Category = "EXT_discard_framebuffer", Version = "", EntryPoint = "glDiscardFramebufferEXT")]
            public static extern void DiscardFramebuffer(OpenTK.Graphics.ES11.All target, Int32 numAttachments, OpenTK.Graphics.ES11.All[] attachments);

            /// <summary>[requires: EXT_discard_framebuffer]</summary>
            [AutoGenerated(Category = "EXT_discard_framebuffer", Version = "", EntryPoint = "glDiscardFramebufferEXT")]
            public static extern void DiscardFramebuffer(OpenTK.Graphics.ES11.All target, Int32 numAttachments, ref OpenTK.Graphics.ES11.All attachments);

            /// <summary>[requires: EXT_discard_framebuffer]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_discard_framebuffer", Version = "", EntryPoint = "glDiscardFramebufferEXT")]
            public static extern unsafe void DiscardFramebuffer(OpenTK.Graphics.ES11.All target, Int32 numAttachments, OpenTK.Graphics.ES11.All* attachments);

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
            public static extern void FlushMappedBufferRange(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length);

            /// <summary>[requires: EXT_multisampled_render_to_texture]</summary>
            [AutoGenerated(Category = "EXT_multisampled_render_to_texture", Version = "", EntryPoint = "glFramebufferTexture2DMultisampleEXT")]
            public static extern void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, Int32 texture, Int32 level, Int32 samples);

            /// <summary>[requires: EXT_multisampled_render_to_texture]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multisampled_render_to_texture", Version = "", EntryPoint = "glFramebufferTexture2DMultisampleEXT")]
            public static extern void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples);

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetGraphicsResetStatusEXT")]
            public static extern OpenTK.Graphics.ES11.All GetGraphicsResetStatus();

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            public static extern void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Single[] @params);

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            public static extern void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] out Single @params);

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            public static extern unsafe void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            public static extern void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single[] @params);

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            public static extern void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] out Single @params);

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            public static extern unsafe void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            public static extern void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32[] @params);

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            public static extern void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] out Int32 @params);

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            public static extern unsafe void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            public static extern void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32[] @params);

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            public static extern void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] out Int32 @params);

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            public static extern unsafe void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);

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
            public static extern IntPtr MapBufferRange(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length, Int32 access);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_map_buffer_range", Version = "", EntryPoint = "glMapBufferRangeEXT")]
            public static extern IntPtr MapBufferRange(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length, UInt32 access);

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
            public static extern void MultiDrawArrays(OpenTK.Graphics.ES11.All mode, Int32[] first, Int32[] count, Int32 primcount);

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
            public static extern void MultiDrawArrays(OpenTK.Graphics.ES11.All mode, ref Int32 first, ref Int32 count, Int32 primcount);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawArraysEXT")]
            public static extern unsafe void MultiDrawArrays(OpenTK.Graphics.ES11.All mode, Int32* first, Int32* count, Int32 primcount);

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
            public static extern void MultiDrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] first, Int32[] count, Int32 primcount);

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
            public static extern void MultiDrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 first, ref Int32 count, Int32 primcount);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawArraysEXT")]
            public static extern unsafe void MultiDrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount);

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
            public static extern void MultiDrawElements(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount);

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount);

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
            ;

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            public static extern unsafe void MultiDrawElements(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            public static extern unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
            ;

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            public static extern unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
            ;

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            public static extern unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
            ;

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            public static extern unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount);

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount);

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
            ;

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
            public static extern void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
            ;

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            public static extern unsafe void MultiDrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            public static extern unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
            ;

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            public static extern unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
            ;

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            public static extern unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
            ;

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multi_draw_arrays", Version = "", EntryPoint = "glMultiDrawElementsEXT")]
            public static extern unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
            ;

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            public static extern void ReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [OutAttribute] IntPtr data);

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            public static extern void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] T7[] data)
                where T7 : struct
            ;

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            public static extern void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] T7[,] data)
                where T7 : struct
            ;

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            public static extern void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] T7[,,] data)
                where T7 : struct
            ;

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            public static extern void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] ref T7 data)
                where T7 : struct
            ;

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
            public static extern void RenderbufferStorageMultisample(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);

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
            public static extern void TexStorage1D(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width);

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
            public static extern void TexStorage2D(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);

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
            public static extern void TexStorage3D(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth);

            /// <summary>[requires: EXT_texture_storage]</summary>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage1DEXT")]
            public static extern void TextureStorage1D(Int32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width);

            /// <summary>[requires: EXT_texture_storage]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage1DEXT")]
            public static extern void TextureStorage1D(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width);

            /// <summary>[requires: EXT_texture_storage]</summary>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage2DEXT")]
            public static extern void TextureStorage2D(Int32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);

            /// <summary>[requires: EXT_texture_storage]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage2DEXT")]
            public static extern void TextureStorage2D(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);

            /// <summary>[requires: EXT_texture_storage]</summary>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage3DEXT")]
            public static extern void TextureStorage3D(Int32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth);

            /// <summary>[requires: EXT_texture_storage]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage3DEXT")]
            public static extern void TextureStorage3D(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth);

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
            public static extern void ClipPlane(OpenTK.Graphics.ES11.All p, Single[] eqn);

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
            public static extern void ClipPlane(OpenTK.Graphics.ES11.All p, ref Single eqn);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "IMG_user_clip_plane", Version = "", EntryPoint = "glClipPlanefIMG")]
            public static extern unsafe void ClipPlane(OpenTK.Graphics.ES11.All p, Single* eqn);

            /// <summary>[requires: IMG_user_clip_plane]</summary>
            [AutoGenerated(Category = "IMG_user_clip_plane", Version = "", EntryPoint = "glClipPlanexIMG")]
            public static extern void ClipPlanex(OpenTK.Graphics.ES11.All p, int[] eqn);

            /// <summary>[requires: IMG_user_clip_plane]</summary>
            [AutoGenerated(Category = "IMG_user_clip_plane", Version = "", EntryPoint = "glClipPlanexIMG")]
            public static extern void ClipPlanex(OpenTK.Graphics.ES11.All p, ref int eqn);

            /// <summary>[requires: IMG_user_clip_plane]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "IMG_user_clip_plane", Version = "", EntryPoint = "glClipPlanexIMG")]
            public static extern unsafe void ClipPlanex(OpenTK.Graphics.ES11.All p, int* eqn);

            /// <summary>[requires: IMG_multisampled_render_to_texture]</summary>
            [AutoGenerated(Category = "IMG_multisampled_render_to_texture", Version = "", EntryPoint = "glFramebufferTexture2DMultisampleIMG")]
            public static extern void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, Int32 texture, Int32 level, Int32 samples);

            /// <summary>[requires: IMG_multisampled_render_to_texture]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "IMG_multisampled_render_to_texture", Version = "", EntryPoint = "glFramebufferTexture2DMultisampleIMG")]
            public static extern void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples);

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
            public static extern void RenderbufferStorageMultisample(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);

        }

        public static partial class NV
        {
            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            public static extern void DeleteFence(Int32 fences);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            public static extern void DeleteFence(UInt32 fences);

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            public static extern void DeleteFences(Int32 n, Int32[] fences);

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            public static extern void DeleteFences(Int32 n, ref Int32 fences);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            public static extern unsafe void DeleteFences(Int32 n, Int32* fences);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            public static extern void DeleteFences(Int32 n, UInt32[] fences);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            public static extern void DeleteFences(Int32 n, ref UInt32 fences);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            public static extern unsafe void DeleteFences(Int32 n, UInt32* fences);

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glFinishFenceNV")]
            public static extern void FinishFence(Int32 fence);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glFinishFenceNV")]
            public static extern void FinishFence(UInt32 fence);

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            public static extern Int32 GenFence();

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            public static extern void GenFences(Int32 n, [OutAttribute] Int32[] fences);

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            public static extern void GenFences(Int32 n, [OutAttribute] out Int32 fences);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            public static extern unsafe void GenFences(Int32 n, [OutAttribute] Int32* fences);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            public static extern void GenFences(Int32 n, [OutAttribute] UInt32[] fences);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            public static extern void GenFences(Int32 n, [OutAttribute] out UInt32 fences);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            public static extern unsafe void GenFences(Int32 n, [OutAttribute] UInt32* fences);

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            public static extern void GetFence(Int32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params);

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            public static extern void GetFence(Int32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            public static extern unsafe void GetFence(Int32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            public static extern void GetFence(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            public static extern void GetFence(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            public static extern unsafe void GetFence(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glIsFenceNV")]
            public static extern bool IsFence(Int32 fence);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glIsFenceNV")]
            public static extern bool IsFence(UInt32 fence);

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glSetFenceNV")]
            public static extern void SetFence(Int32 fence, OpenTK.Graphics.ES11.All condition);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glSetFenceNV")]
            public static extern void SetFence(UInt32 fence, OpenTK.Graphics.ES11.All condition);

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glTestFenceNV")]
            public static extern bool TestFence(Int32 fence);

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glTestFenceNV")]
            public static extern bool TestFence(UInt32 fence);

        }

        public static partial class Oes
        {
            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glAccumxOES")]
            public static extern void Accumx(OpenTK.Graphics.ES11.All op, int value);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glAlphaFuncxOES")]
            public static extern void AlphaFuncx(OpenTK.Graphics.ES11.All func, int @ref);

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
            public static extern void BindFramebuffer(OpenTK.Graphics.ES11.All target, Int32 framebuffer);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glBindFramebufferOES")]
            public static extern void BindFramebuffer(OpenTK.Graphics.ES11.All target, UInt32 framebuffer);

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
            public static extern void BindRenderbuffer(OpenTK.Graphics.ES11.All target, Int32 renderbuffer);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glBindRenderbufferOES")]
            public static extern void BindRenderbuffer(OpenTK.Graphics.ES11.All target, UInt32 renderbuffer);

            /// <summary>[requires: OES_vertex_array_object]
            /// Bind a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies the name of the vertex array to bind.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glBindVertexArrayOES")]
            public static extern void BindVertexArray(Int32 array);

            /// <summary>[requires: OES_vertex_array_object]
            /// Bind a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies the name of the vertex array to bind.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glBindVertexArrayOES")]
            public static extern void BindVertexArray(UInt32 array);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glBitmapxOES")]
            public static extern void Bitmapx(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte[] bitmap);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glBitmapxOES")]
            public static extern void Bitmapx(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, ref Byte bitmap);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glBitmapxOES")]
            public static extern unsafe void Bitmapx(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte* bitmap);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glBlendColorxOES")]
            public static extern void BlendColorx(int red, int green, int blue, int alpha);

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
            public static extern void BlendEquation(OpenTK.Graphics.ES11.All mode);

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
            public static extern void BlendEquationSeparate(OpenTK.Graphics.ES11.All modeRGB, OpenTK.Graphics.ES11.All modeAlpha);

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
            public static extern void BlendFuncSeparate(OpenTK.Graphics.ES11.All srcRGB, OpenTK.Graphics.ES11.All dstRGB, OpenTK.Graphics.ES11.All srcAlpha, OpenTK.Graphics.ES11.All dstAlpha);

            /// <summary>[requires: OES_framebuffer_object]
            /// Check the completeness status of a framebuffer
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specify the target of the framebuffer completeness check.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glCheckFramebufferStatusOES")]
            public static extern OpenTK.Graphics.ES11.All CheckFramebufferStatus(OpenTK.Graphics.ES11.All target);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClearAccumxOES")]
            public static extern void ClearAccumx(int red, int green, int blue, int alpha);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClearColorxOES")]
            public static extern void ClearColorx(int red, int green, int blue, int alpha);

            /// <summary>[requires: OES_single_precision]
            /// Specify the clear value for the depth buffer
            /// </summary>
            /// <param name="depth">
            /// <para>
            /// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glClearDepthfOES")]
            public static extern void ClearDepth(Single depth);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClearDepthxOES")]
            public static extern void ClearDepthx(int depth);

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
            public static extern void ClipPlane(OpenTK.Graphics.ES11.All plane, Single[] equation);

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
            public static extern void ClipPlane(OpenTK.Graphics.ES11.All plane, ref Single equation);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glClipPlanefOES")]
            public static extern unsafe void ClipPlane(OpenTK.Graphics.ES11.All plane, Single* equation);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClipPlanexOES")]
            public static extern void ClipPlanex(OpenTK.Graphics.ES11.All plane, int[] equation);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClipPlanexOES")]
            public static extern void ClipPlanex(OpenTK.Graphics.ES11.All plane, ref int equation);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClipPlanexOES")]
            public static extern unsafe void ClipPlanex(OpenTK.Graphics.ES11.All plane, int* equation);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor3xOES")]
            public static extern void Color3x(int red, int green, int blue);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor3xvOES")]
            public static extern void Color3x(int[] components);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor3xvOES")]
            public static extern void Color3x(ref int components);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor3xvOES")]
            public static extern unsafe void Color3x(int* components);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor4xOES")]
            public static extern void Color4x(int red, int green, int blue, int alpha);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor4xvOES")]
            public static extern void Color4x(int[] components);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor4xvOES")]
            public static extern void Color4x(ref int components);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor4xvOES")]
            public static extern unsafe void Color4x(int* components);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glConvolutionParameterxOES")]
            public static extern void ConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glConvolutionParameterxvOES")]
            public static extern void ConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glConvolutionParameterxvOES")]
            public static extern unsafe void ConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glCurrentPaletteMatrixOES")]
            public static extern void CurrentPaletteMatrix(Int32 matrixpaletteindex);

            /// <summary>[requires: OES_matrix_palette]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glCurrentPaletteMatrixOES")]
            public static extern void CurrentPaletteMatrix(UInt32 matrixpaletteindex);

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            public static extern void DeleteFramebuffer(Int32 framebuffers);

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            public static extern void DeleteFramebuffer(UInt32 framebuffers);

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
            public static extern void DeleteFramebuffers(Int32 n, Int32[] framebuffers);

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
            public static extern void DeleteFramebuffers(Int32 n, ref Int32 framebuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            public static extern unsafe void DeleteFramebuffers(Int32 n, Int32* framebuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            public static extern void DeleteFramebuffers(Int32 n, UInt32[] framebuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            public static extern void DeleteFramebuffers(Int32 n, ref UInt32 framebuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            public static extern unsafe void DeleteFramebuffers(Int32 n, UInt32* framebuffers);

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            public static extern void DeleteRenderbuffer(Int32 renderbuffers);

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            public static extern void DeleteRenderbuffer(UInt32 renderbuffers);

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
            public static extern void DeleteRenderbuffers(Int32 n, Int32[] renderbuffers);

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
            public static extern void DeleteRenderbuffers(Int32 n, ref Int32 renderbuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            public static extern unsafe void DeleteRenderbuffers(Int32 n, Int32* renderbuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            public static extern void DeleteRenderbuffers(Int32 n, UInt32[] renderbuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            public static extern void DeleteRenderbuffers(Int32 n, ref UInt32 renderbuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            public static extern unsafe void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers);

            /// <summary>[requires: OES_vertex_array_object]</summary>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            public static extern void DeleteVertexArray(Int32 arrays);

            /// <summary>[requires: OES_vertex_array_object]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            public static extern void DeleteVertexArray(UInt32 arrays);

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
            public static extern void DeleteVertexArrays(Int32 n, Int32[] arrays);

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
            public static extern void DeleteVertexArrays(Int32 n, ref Int32 arrays);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            public static extern unsafe void DeleteVertexArrays(Int32 n, Int32* arrays);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            public static extern void DeleteVertexArrays(Int32 n, UInt32[] arrays);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            public static extern void DeleteVertexArrays(Int32 n, ref UInt32 arrays);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            public static extern unsafe void DeleteVertexArrays(Int32 n, UInt32* arrays);

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
            public static extern void DepthRange(Single n, Single f);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glDepthRangexOES")]
            public static extern void DepthRangex(int n, int f);

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexfOES")]
            public static extern void DrawTex(Single x, Single y, Single z, Single width, Single height);

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexfvOES")]
            public static extern void DrawTex(Single[] coords);

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexfvOES")]
            public static extern void DrawTex(ref Single coords);

            /// <summary>[requires: OES_draw_texture]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexfvOES")]
            public static extern unsafe void DrawTex(Single* coords);

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexiOES")]
            public static extern void DrawTex(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height);

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexivOES")]
            public static extern void DrawTex(Int32[] coords);

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexivOES")]
            public static extern void DrawTex(ref Int32 coords);

            /// <summary>[requires: OES_draw_texture]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexivOES")]
            public static extern unsafe void DrawTex(Int32* coords);

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexsOES")]
            public static extern void DrawTex(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height);

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexsvOES")]
            public static extern void DrawTex(Int16[] coords);

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexsvOES")]
            public static extern void DrawTex(ref Int16 coords);

            /// <summary>[requires: OES_draw_texture]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexsvOES")]
            public static extern unsafe void DrawTex(Int16* coords);

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexxOES")]
            public static extern void DrawTexx(int x, int y, int z, int width, int height);

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexxvOES")]
            public static extern void DrawTexx(int[] coords);

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexxvOES")]
            public static extern void DrawTexx(ref int coords);

            /// <summary>[requires: OES_draw_texture]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexxvOES")]
            public static extern unsafe void DrawTexx(int* coords);

            /// <summary>[requires: OES_EGL_image]</summary>
            [AutoGenerated(Category = "OES_EGL_image", Version = "", EntryPoint = "glEGLImageTargetRenderbufferStorageOES")]
            public static extern void EGLImageTargetRenderbufferStorage(OpenTK.Graphics.ES11.All target, IntPtr image);

            /// <summary>[requires: OES_EGL_image]</summary>
            [AutoGenerated(Category = "OES_EGL_image", Version = "", EntryPoint = "glEGLImageTargetTexture2DOES")]
            public static extern void EGLImageTargetTexture2D(OpenTK.Graphics.ES11.All target, IntPtr image);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord1xOES")]
            public static extern void EvalCoord1x(int u);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord1xvOES")]
            public static extern unsafe void EvalCoord1x(int* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord2xOES")]
            public static extern void EvalCoord2x(int u, int v);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord2xvOES")]
            public static extern void EvalCoord2x(int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord2xvOES")]
            public static extern void EvalCoord2x(ref int coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord2xvOES")]
            public static extern unsafe void EvalCoord2x(int* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFeedbackBufferxOES")]
            public static extern void FeedbackBufferx(Int32 n, OpenTK.Graphics.ES11.All type, int[] buffer);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFeedbackBufferxOES")]
            public static extern void FeedbackBufferx(Int32 n, OpenTK.Graphics.ES11.All type, ref int buffer);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFeedbackBufferxOES")]
            public static extern unsafe void FeedbackBufferx(Int32 n, OpenTK.Graphics.ES11.All type, int* buffer);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFogxOES")]
            public static extern void Fogx(OpenTK.Graphics.ES11.All pname, int param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFogxvOES")]
            public static extern void Fogx(OpenTK.Graphics.ES11.All pname, int[] param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFogxvOES")]
            public static extern unsafe void Fogx(OpenTK.Graphics.ES11.All pname, int* param);

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
            public static extern void FramebufferRenderbuffer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All renderbuffertarget, Int32 renderbuffer);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glFramebufferRenderbufferOES")]
            public static extern void FramebufferRenderbuffer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All renderbuffertarget, UInt32 renderbuffer);

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glFramebufferTexture2DOES")]
            public static extern void FramebufferTexture2D(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, Int32 texture, Int32 level);

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glFramebufferTexture2DOES")]
            public static extern void FramebufferTexture2D(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level);

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
            public static extern void Frustum(Single l, Single r, Single b, Single t, Single n, Single f);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFrustumxOES")]
            public static extern void Frustumx(int l, int r, int b, int t, int n, int f);

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate mipmaps for a specified texture target
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target to which the texture whose mimaps to generate is bound. target must be GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY or GL_TEXTURE_CUBE_MAP.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenerateMipmapOES")]
            public static extern void GenerateMipmap(OpenTK.Graphics.ES11.All target);

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenFramebuffersOES")]
            public static extern Int32 GenFramebuffer();

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
            public static extern void GenFramebuffers(Int32 n, [OutAttribute] Int32[] framebuffers);

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
            public static extern void GenFramebuffers(Int32 n, [OutAttribute] out Int32 framebuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenFramebuffersOES")]
            public static extern unsafe void GenFramebuffers(Int32 n, [OutAttribute] Int32* framebuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenFramebuffersOES")]
            public static extern void GenFramebuffers(Int32 n, [OutAttribute] UInt32[] framebuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenFramebuffersOES")]
            public static extern void GenFramebuffers(Int32 n, [OutAttribute] out UInt32 framebuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenFramebuffersOES")]
            public static extern unsafe void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers);

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenRenderbuffersOES")]
            public static extern Int32 GenRenderbuffer();

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
            public static extern void GenRenderbuffers(Int32 n, [OutAttribute] Int32[] renderbuffers);

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
            public static extern void GenRenderbuffers(Int32 n, [OutAttribute] out Int32 renderbuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenRenderbuffersOES")]
            public static extern unsafe void GenRenderbuffers(Int32 n, [OutAttribute] Int32* renderbuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenRenderbuffersOES")]
            public static extern void GenRenderbuffers(Int32 n, [OutAttribute] UInt32[] renderbuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenRenderbuffersOES")]
            public static extern void GenRenderbuffers(Int32 n, [OutAttribute] out UInt32 renderbuffers);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenRenderbuffersOES")]
            public static extern unsafe void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers);

            /// <summary>[requires: OES_vertex_array_object]</summary>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glGenVertexArraysOES")]
            public static extern Int32 GenVertexArray();

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
            public static extern void GenVertexArrays(Int32 n, [OutAttribute] Int32[] arrays);

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
            public static extern void GenVertexArrays(Int32 n, [OutAttribute] out Int32 arrays);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glGenVertexArraysOES")]
            public static extern unsafe void GenVertexArrays(Int32 n, [OutAttribute] Int32* arrays);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glGenVertexArraysOES")]
            public static extern void GenVertexArrays(Int32 n, [OutAttribute] UInt32[] arrays);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glGenVertexArraysOES")]
            public static extern void GenVertexArrays(Int32 n, [OutAttribute] out UInt32 arrays);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glGenVertexArraysOES")]
            public static extern unsafe void GenVertexArrays(Int32 n, [OutAttribute] UInt32* arrays);

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            public static extern void GetBufferPointer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] IntPtr @params);

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            public static extern void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T2[] @params)
                where T2 : struct
            ;

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            public static extern void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T2[,] @params)
                where T2 : struct
            ;

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            public static extern void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T2[,,] @params)
                where T2 : struct
            ;

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            public static extern void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] ref T2 @params)
                where T2 : struct
            ;

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
            public static extern void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single[] equation);

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
            public static extern void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] out Single equation);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glGetClipPlanefOES")]
            public static extern unsafe void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetClipPlanexOES")]
            public static extern void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int[] equation);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetClipPlanexOES")]
            public static extern void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] out int equation);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetClipPlanexOES")]
            public static extern unsafe void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetConvolutionParameterxvOES")]
            public static extern void GetConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetConvolutionParameterxvOES")]
            public static extern void GetConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetConvolutionParameterxvOES")]
            public static extern unsafe void GetConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetFixedvOES")]
            public static extern int GetFixed(OpenTK.Graphics.ES11.All pname);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetFixedvOES")]
            public static extern void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetFixedvOES")]
            public static extern void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetFixedvOES")]
            public static extern unsafe void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

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
            public static extern void GetFramebufferAttachmentParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params);

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
            public static extern void GetFramebufferAttachmentParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGetFramebufferAttachmentParameterivOES")]
            public static extern unsafe void GetFramebufferAttachmentParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetHistogramParameterxvOES")]
            public static extern void GetHistogramParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetHistogramParameterxvOES")]
            public static extern void GetHistogramParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetHistogramParameterxvOES")]
            public static extern unsafe void GetHistogramParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetLightxOES")]
            public static extern void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetLightxOES")]
            public static extern void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetLightxOES")]
            public static extern unsafe void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMapxvOES")]
            public static extern void GetMapx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] int[] v);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMapxvOES")]
            public static extern void GetMapx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] out int v);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMapxvOES")]
            public static extern unsafe void GetMapx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] int* v);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMaterialxOES")]
            public static extern void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMaterialxvOES")]
            public static extern void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMaterialxvOES")]
            public static extern unsafe void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

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
            public static extern void GetRenderbufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params);

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
            public static extern void GetRenderbufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGetRenderbufferParameterivOES")]
            public static extern unsafe void GetRenderbufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexEnvxvOES")]
            public static extern void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexEnvxvOES")]
            public static extern void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexEnvxvOES")]
            public static extern unsafe void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

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
            public static extern void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params);

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
            public static extern void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenfvOES")]
            public static extern unsafe void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params);

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
            public static extern void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params);

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
            public static extern void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenivOES")]
            public static extern unsafe void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenxvOES")]
            public static extern void GetTexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenxvOES")]
            public static extern void GetTexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params);

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenxvOES")]
            public static extern unsafe void GetTexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexLevelParameterxvOES")]
            public static extern void GetTexLevelParameterx(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexLevelParameterxvOES")]
            public static extern void GetTexLevelParameterx(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexLevelParameterxvOES")]
            public static extern unsafe void GetTexLevelParameterx(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexParameterxvOES")]
            public static extern void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexParameterxvOES")]
            public static extern void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexParameterxvOES")]
            public static extern unsafe void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glIndexxOES")]
            public static extern void Indexx(int component);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glIndexxvOES")]
            public static extern unsafe void Indexx(int* component);

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a framebuffer object
            /// </summary>
            /// <param name="framebuffer">
            /// <para>
            /// Specifies a value that may be the name of a framebuffer object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glIsFramebufferOES")]
            public static extern bool IsFramebuffer(Int32 framebuffer);

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a framebuffer object
            /// </summary>
            /// <param name="framebuffer">
            /// <para>
            /// Specifies a value that may be the name of a framebuffer object.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glIsFramebufferOES")]
            public static extern bool IsFramebuffer(UInt32 framebuffer);

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a renderbuffer object
            /// </summary>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies a value that may be the name of a renderbuffer object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glIsRenderbufferOES")]
            public static extern bool IsRenderbuffer(Int32 renderbuffer);

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a renderbuffer object
            /// </summary>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies a value that may be the name of a renderbuffer object.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glIsRenderbufferOES")]
            public static extern bool IsRenderbuffer(UInt32 renderbuffer);

            /// <summary>[requires: OES_vertex_array_object]
            /// Determine if a name corresponds to a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies a value that may be the name of a vertex array object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glIsVertexArrayOES")]
            public static extern bool IsVertexArray(Int32 array);

            /// <summary>[requires: OES_vertex_array_object]
            /// Determine if a name corresponds to a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies a value that may be the name of a vertex array object.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glIsVertexArrayOES")]
            public static extern bool IsVertexArray(UInt32 array);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightModelxOES")]
            public static extern void LightModelx(OpenTK.Graphics.ES11.All pname, int param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightModelxvOES")]
            public static extern void LightModelx(OpenTK.Graphics.ES11.All pname, int[] param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightModelxvOES")]
            public static extern unsafe void LightModelx(OpenTK.Graphics.ES11.All pname, int* param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightxOES")]
            public static extern void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightxvOES")]
            public static extern void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int[] @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightxvOES")]
            public static extern unsafe void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLineWidthxOES")]
            public static extern void LineWidthx(int width);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadMatrixxOES")]
            public static extern void LoadMatrixx(int[] m);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadMatrixxOES")]
            public static extern void LoadMatrixx(ref int m);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadMatrixxOES")]
            public static extern unsafe void LoadMatrixx(int* m);

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glLoadPaletteFromModelViewMatrixOES")]
            public static extern void LoadPaletteFromModelViewMatrix();

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadTransposeMatrixxOES")]
            public static extern void LoadTransposeMatrixx(int[] m);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadTransposeMatrixxOES")]
            public static extern void LoadTransposeMatrixx(ref int m);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadTransposeMatrixxOES")]
            public static extern unsafe void LoadTransposeMatrixx(int* m);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMap1xOES")]
            public static extern void Map1x(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 stride, Int32 order, int points);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMap2xOES")]
            public static extern void Map2x(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 ustride, Int32 uorder, int v1, int v2, Int32 vstride, Int32 vorder, int points);

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
            public static extern IntPtr MapBuffer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All access);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMapGrid1xOES")]
            public static extern void MapGrid1x(Int32 n, int u1, int u2);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMapGrid2xOES")]
            public static extern void MapGrid2x(Int32 n, int u1, int u2, int v1, int v2);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMaterialxOES")]
            public static extern void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMaterialxvOES")]
            public static extern void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int[] param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMaterialxvOES")]
            public static extern unsafe void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param);

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            public static extern void MatrixIndexPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            public static extern void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
                where T3 : struct
            ;

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            public static extern void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
                where T3 : struct
            ;

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            public static extern void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
                where T3 : struct
            ;

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            public static extern void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
                where T3 : struct
            ;

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
            public static extern void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, Byte s);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord1bOES")]
            public static extern void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, SByte s);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord1bvOES")]
            public static extern unsafe void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, Byte* coords);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord1bvOES")]
            public static extern unsafe void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, SByte* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord1xOES")]
            public static extern void MultiTexCoord1x(OpenTK.Graphics.ES11.All texture, int s);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord1xvOES")]
            public static extern unsafe void MultiTexCoord1x(OpenTK.Graphics.ES11.All texture, int* coords);

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
            public static extern void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, Byte s, Byte t);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bOES")]
            public static extern void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, SByte s, SByte t);

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
            public static extern void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, Byte[] coords);

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
            public static extern void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, ref Byte coords);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            public static extern unsafe void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, Byte* coords);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            public static extern void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, SByte[] coords);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            public static extern void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, ref SByte coords);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            public static extern unsafe void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, SByte* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord2xOES")]
            public static extern void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, int s, int t);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord2xvOES")]
            public static extern void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord2xvOES")]
            public static extern void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, ref int coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord2xvOES")]
            public static extern unsafe void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, int* coords);

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
            public static extern void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, Byte s, Byte t, Byte r);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bOES")]
            public static extern void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r);

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
            public static extern void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, Byte[] coords);

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
            public static extern void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, ref Byte coords);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            public static extern unsafe void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, Byte* coords);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            public static extern void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, SByte[] coords);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            public static extern void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, ref SByte coords);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            public static extern unsafe void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, SByte* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord3xOES")]
            public static extern void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, int s, int t, int r);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord3xvOES")]
            public static extern void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord3xvOES")]
            public static extern void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, ref int coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord3xvOES")]
            public static extern unsafe void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, int* coords);

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
            public static extern void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, Byte s, Byte t, Byte r, Byte q);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bOES")]
            public static extern void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r, SByte q);

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
            public static extern void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, Byte[] coords);

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
            public static extern void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, ref Byte coords);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            public static extern unsafe void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, Byte* coords);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            public static extern void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, SByte[] coords);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            public static extern void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, ref SByte coords);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            public static extern unsafe void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, SByte* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord4xOES")]
            public static extern void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord4xvOES")]
            public static extern void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord4xvOES")]
            public static extern void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, ref int coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord4xvOES")]
            public static extern unsafe void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultMatrixxOES")]
            public static extern void MultMatrixx(int[] m);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultMatrixxOES")]
            public static extern void MultMatrixx(ref int m);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultMatrixxOES")]
            public static extern unsafe void MultMatrixx(int* m);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultTransposeMatrixxOES")]
            public static extern void MultTransposeMatrixx(int[] m);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultTransposeMatrixxOES")]
            public static extern void MultTransposeMatrixx(ref int m);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultTransposeMatrixxOES")]
            public static extern unsafe void MultTransposeMatrixx(int* m);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glNormal3xOES")]
            public static extern void Normal3x(int nx, int ny, int nz);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glNormal3xvOES")]
            public static extern void Normal3x(int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glNormal3xvOES")]
            public static extern void Normal3x(ref int coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glNormal3xvOES")]
            public static extern unsafe void Normal3x(int* coords);

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
            public static extern void Ortho(Single l, Single r, Single b, Single t, Single n, Single f);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glOrthoxOES")]
            public static extern void Orthox(int l, int r, int b, int t, int n, int f);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPassThroughxOES")]
            public static extern void PassThroughx(int token);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelTransferxOES")]
            public static extern void PixelTransferx(OpenTK.Graphics.ES11.All pname, int param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelZoomxOES")]
            public static extern void PixelZoomx(int xfactor, int yfactor);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPointParameterxOES")]
            public static extern void PointParameterx(OpenTK.Graphics.ES11.All pname, int param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPointParameterxvOES")]
            public static extern void PointParameterx(OpenTK.Graphics.ES11.All pname, int[] @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPointParameterxvOES")]
            public static extern unsafe void PointParameterx(OpenTK.Graphics.ES11.All pname, int* @params);

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            public static extern void PointSizePointer(OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            public static extern void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[] pointer)
                where T2 : struct
            ;

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            public static extern void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,] pointer)
                where T2 : struct
            ;

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            public static extern void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,,] pointer)
                where T2 : struct
            ;

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            public static extern void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T2 pointer)
                where T2 : struct
            ;

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPointSizexOES")]
            public static extern void PointSizex(int size);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPolygonOffsetxOES")]
            public static extern void PolygonOffsetx(int factor, int units);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            public static extern void PrioritizeTexturesx(Int32 n, Int32[] textures, int[] priorities);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            public static extern void PrioritizeTexturesx(Int32 n, ref Int32 textures, ref int priorities);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            public static extern unsafe void PrioritizeTexturesx(Int32 n, Int32* textures, int* priorities);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            public static extern void PrioritizeTexturesx(Int32 n, UInt32[] textures, int[] priorities);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            public static extern void PrioritizeTexturesx(Int32 n, ref UInt32 textures, ref int priorities);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            public static extern unsafe void PrioritizeTexturesx(Int32 n, UInt32* textures, int* priorities);

            /// <summary>[requires: OES_query_matrix]</summary>
            [AutoGenerated(Category = "OES_query_matrix", Version = "", EntryPoint = "glQueryMatrixxOES")]
            public static extern Int32 QueryMatrixx([OutAttribute] int[] mantissa, [OutAttribute] Int32[] exponent);

            /// <summary>[requires: OES_query_matrix]</summary>
            [AutoGenerated(Category = "OES_query_matrix", Version = "", EntryPoint = "glQueryMatrixxOES")]
            public static extern Int32 QueryMatrixx([OutAttribute] out int mantissa, [OutAttribute] out Int32 exponent);

            /// <summary>[requires: OES_query_matrix]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_query_matrix", Version = "", EntryPoint = "glQueryMatrixxOES")]
            public static extern unsafe Int32 QueryMatrixx([OutAttribute] int* mantissa, [OutAttribute] Int32* exponent);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos2xOES")]
            public static extern void RasterPos2x(int x, int y);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos2xvOES")]
            public static extern void RasterPos2x(int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos2xvOES")]
            public static extern void RasterPos2x(ref int coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos2xvOES")]
            public static extern unsafe void RasterPos2x(int* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos3xOES")]
            public static extern void RasterPos3x(int x, int y, int z);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos3xvOES")]
            public static extern void RasterPos3x(int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos3xvOES")]
            public static extern void RasterPos3x(ref int coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos3xvOES")]
            public static extern unsafe void RasterPos3x(int* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos4xOES")]
            public static extern void RasterPos4x(int x, int y, int z, int w);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos4xvOES")]
            public static extern void RasterPos4x(int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos4xvOES")]
            public static extern void RasterPos4x(ref int coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos4xvOES")]
            public static extern unsafe void RasterPos4x(int* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRectxOES")]
            public static extern void Rectx(int x1, int y1, int x2, int y2);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRectxvOES")]
            public static extern void Rectx(int[] v1, int[] v2);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRectxvOES")]
            public static extern void Rectx(ref int v1, ref int v2);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRectxvOES")]
            public static extern unsafe void Rectx(int* v1, int* v2);

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
            public static extern void RenderbufferStorage(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRotatexOES")]
            public static extern void Rotatex(int angle, int x, int y, int z);

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
            public static extern void SampleCoverage(int value, bool invert);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glSampleCoveragexOES")]
            public static extern void SampleCoveragex(int value, bool invert);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glScalexOES")]
            public static extern void Scalex(int x, int y, int z);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord1bOES")]
            public static extern void TexCoord1(Byte s);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord1bOES")]
            public static extern void TexCoord1(SByte s);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord1bvOES")]
            public static extern unsafe void TexCoord1(Byte* coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord1bvOES")]
            public static extern unsafe void TexCoord1(SByte* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord1xOES")]
            public static extern void TexCoord1x(int s);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord1xvOES")]
            public static extern unsafe void TexCoord1x(int* coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bOES")]
            public static extern void TexCoord2(Byte s, Byte t);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bOES")]
            public static extern void TexCoord2(SByte s, SByte t);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            public static extern void TexCoord2(Byte[] coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            public static extern void TexCoord2(ref Byte coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            public static extern unsafe void TexCoord2(Byte* coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            public static extern void TexCoord2(SByte[] coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            public static extern void TexCoord2(ref SByte coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            public static extern unsafe void TexCoord2(SByte* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord2xOES")]
            public static extern void TexCoord2x(int s, int t);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord2xvOES")]
            public static extern void TexCoord2x(int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord2xvOES")]
            public static extern void TexCoord2x(ref int coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord2xvOES")]
            public static extern unsafe void TexCoord2x(int* coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bOES")]
            public static extern void TexCoord3(Byte s, Byte t, Byte r);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bOES")]
            public static extern void TexCoord3(SByte s, SByte t, SByte r);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            public static extern void TexCoord3(Byte[] coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            public static extern void TexCoord3(ref Byte coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            public static extern unsafe void TexCoord3(Byte* coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            public static extern void TexCoord3(SByte[] coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            public static extern void TexCoord3(ref SByte coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            public static extern unsafe void TexCoord3(SByte* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord3xOES")]
            public static extern void TexCoord3x(int s, int t, int r);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord3xvOES")]
            public static extern void TexCoord3x(int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord3xvOES")]
            public static extern void TexCoord3x(ref int coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord3xvOES")]
            public static extern unsafe void TexCoord3x(int* coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bOES")]
            public static extern void TexCoord4(Byte s, Byte t, Byte r, Byte q);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bOES")]
            public static extern void TexCoord4(SByte s, SByte t, SByte r, SByte q);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            public static extern void TexCoord4(Byte[] coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            public static extern void TexCoord4(ref Byte coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            public static extern unsafe void TexCoord4(Byte* coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            public static extern void TexCoord4(SByte[] coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            public static extern void TexCoord4(ref SByte coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            public static extern unsafe void TexCoord4(SByte* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord4xOES")]
            public static extern void TexCoord4x(int s, int t, int r, int q);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord4xvOES")]
            public static extern void TexCoord4x(int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord4xvOES")]
            public static extern void TexCoord4x(ref int coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord4xvOES")]
            public static extern unsafe void TexCoord4x(int* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexEnvxOES")]
            public static extern void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexEnvxvOES")]
            public static extern void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexEnvxvOES")]
            public static extern unsafe void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);

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
            public static extern void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single param);

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
            public static extern void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single[] @params);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenfvOES")]
            public static extern unsafe void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single* @params);

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
            public static extern void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32 param);

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
            public static extern void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32[] @params);

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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_texture_cube_map", Version = "", EntryPoint = "glTexGenivOES")]
            public static extern unsafe void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32* @params);

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glTexGenxOES")]
            public static extern void TexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int param);

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glTexGenxvOES")]
            public static extern void TexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int[] @params);

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glTexGenxvOES")]
            public static extern unsafe void TexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int* @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexParameterxOES")]
            public static extern void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexParameterxvOES")]
            public static extern void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexParameterxvOES")]
            public static extern unsafe void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTranslatexOES")]
            public static extern void Translatex(int x, int y, int z);

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glUnmapBufferOES")]
            public static extern bool UnmapBuffer(OpenTK.Graphics.ES11.All target);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bOES")]
            public static extern void Vertex2(Byte x);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bOES")]
            public static extern void Vertex2(SByte x);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bvOES")]
            public static extern void Vertex2(Byte[] coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bvOES")]
            public static extern unsafe void Vertex2(Byte* coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bvOES")]
            public static extern void Vertex2(SByte[] coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bvOES")]
            public static extern unsafe void Vertex2(SByte* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex2xOES")]
            public static extern void Vertex2x(int x);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex2xvOES")]
            public static extern void Vertex2x(int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex2xvOES")]
            public static extern unsafe void Vertex2x(int* coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bOES")]
            public static extern void Vertex3(Byte x, Byte y);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bOES")]
            public static extern void Vertex3(SByte x, SByte y);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            public static extern void Vertex3(Byte[] coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            public static extern void Vertex3(ref Byte coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            public static extern unsafe void Vertex3(Byte* coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            public static extern void Vertex3(SByte[] coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            public static extern void Vertex3(ref SByte coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            public static extern unsafe void Vertex3(SByte* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex3xOES")]
            public static extern void Vertex3x(int x, int y);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex3xvOES")]
            public static extern void Vertex3x(int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex3xvOES")]
            public static extern void Vertex3x(ref int coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex3xvOES")]
            public static extern unsafe void Vertex3x(int* coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bOES")]
            public static extern void Vertex4(Byte x, Byte y, Byte z);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bOES")]
            public static extern void Vertex4(SByte x, SByte y, SByte z);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            public static extern void Vertex4(Byte[] coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            public static extern void Vertex4(ref Byte coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            public static extern unsafe void Vertex4(Byte* coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            public static extern void Vertex4(SByte[] coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            public static extern void Vertex4(ref SByte coords);

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            public static extern unsafe void Vertex4(SByte* coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex4xOES")]
            public static extern void Vertex4x(int x, int y, int z);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex4xvOES")]
            public static extern void Vertex4x(int[] coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex4xvOES")]
            public static extern void Vertex4x(ref int coords);

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex4xvOES")]
            public static extern unsafe void Vertex4x(int* coords);

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            public static extern void WeightPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            public static extern void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
                where T3 : struct
            ;

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            public static extern void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
                where T3 : struct
            ;

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            public static extern void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
                where T3 : struct
            ;

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            public static extern void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
                where T3 : struct
            ;

        }

        public static partial class Qcom
        {
            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glDisableDriverControlQCOM")]
            public static extern void DisableDriverControl(Int32 driverControl);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glDisableDriverControlQCOM")]
            public static extern void DisableDriverControl(UInt32 driverControl);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glEnableDriverControlQCOM")]
            public static extern void EnableDriverControl(Int32 driverControl);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glEnableDriverControlQCOM")]
            public static extern void EnableDriverControl(UInt32 driverControl);

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glEndTilingQCOM")]
            public static extern void EndTiling(Int32 preserveMask);

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glEndTilingQCOM")]
            public static extern void EndTiling(UInt32 preserveMask);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            public static extern void ExtGetBufferPointer(OpenTK.Graphics.ES11.All target, [OutAttribute] IntPtr @params);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            public static extern void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] T1[] @params)
                where T1 : struct
            ;

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            public static extern void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] T1[,] @params)
                where T1 : struct
            ;

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            public static extern void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] T1[,,] @params)
                where T1 : struct
            ;

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            public static extern void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] ref T1 @params)
                where T1 : struct
            ;

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            public static extern void ExtGetBuffers([OutAttribute] Int32[] buffers, Int32 maxBuffers, [OutAttribute] Int32[] numBuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            public static extern void ExtGetBuffers([OutAttribute] out Int32 buffers, Int32 maxBuffers, [OutAttribute] out Int32 numBuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            public static extern unsafe void ExtGetBuffers([OutAttribute] Int32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            public static extern void ExtGetBuffers([OutAttribute] UInt32[] buffers, Int32 maxBuffers, [OutAttribute] Int32[] numBuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            public static extern void ExtGetBuffers([OutAttribute] out UInt32 buffers, Int32 maxBuffers, [OutAttribute] out Int32 numBuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            public static extern unsafe void ExtGetBuffers([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            public static extern void ExtGetFramebuffers([OutAttribute] Int32[] framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32[] numFramebuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            public static extern void ExtGetFramebuffers([OutAttribute] out Int32 framebuffers, Int32 maxFramebuffers, [OutAttribute] out Int32 numFramebuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            public static extern unsafe void ExtGetFramebuffers([OutAttribute] Int32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            public static extern void ExtGetFramebuffers([OutAttribute] UInt32[] framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32[] numFramebuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            public static extern void ExtGetFramebuffers([OutAttribute] out UInt32 framebuffers, Int32 maxFramebuffers, [OutAttribute] out Int32 numFramebuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            public static extern unsafe void ExtGetFramebuffers([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            public static extern void ExtGetProgramBinarySource(Int32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32[] length);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            public static extern void ExtGetProgramBinarySource(Int32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] out Int32 length);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            public static extern unsafe void ExtGetProgramBinarySource(Int32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            public static extern void ExtGetProgramBinarySource(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32[] length);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            public static extern void ExtGetProgramBinarySource(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] out Int32 length);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            public static extern unsafe void ExtGetProgramBinarySource(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            public static extern void ExtGetProgram([OutAttribute] Int32[] programs, Int32 maxPrograms, [OutAttribute] Int32[] numPrograms);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            public static extern void ExtGetProgram([OutAttribute] out Int32 programs, Int32 maxPrograms, [OutAttribute] out Int32 numPrograms);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            public static extern unsafe void ExtGetProgram([OutAttribute] Int32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            public static extern void ExtGetProgram([OutAttribute] UInt32[] programs, Int32 maxPrograms, [OutAttribute] Int32[] numPrograms);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            public static extern void ExtGetProgram([OutAttribute] out UInt32 programs, Int32 maxPrograms, [OutAttribute] out Int32 numPrograms);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            public static extern unsafe void ExtGetProgram([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            public static extern void ExtGetRenderbuffers([OutAttribute] Int32[] renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32[] numRenderbuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            public static extern void ExtGetRenderbuffers([OutAttribute] out Int32 renderbuffers, Int32 maxRenderbuffers, [OutAttribute] out Int32 numRenderbuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            public static extern unsafe void ExtGetRenderbuffers([OutAttribute] Int32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            public static extern void ExtGetRenderbuffers([OutAttribute] UInt32[] renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32[] numRenderbuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            public static extern void ExtGetRenderbuffers([OutAttribute] out UInt32 renderbuffers, Int32 maxRenderbuffers, [OutAttribute] out Int32 numRenderbuffers);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            public static extern unsafe void ExtGetRenderbuffers([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            public static extern void ExtGetShaders([OutAttribute] Int32[] shaders, Int32 maxShaders, [OutAttribute] Int32[] numShaders);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            public static extern void ExtGetShaders([OutAttribute] out Int32 shaders, Int32 maxShaders, [OutAttribute] out Int32 numShaders);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            public static extern unsafe void ExtGetShaders([OutAttribute] Int32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            public static extern void ExtGetShaders([OutAttribute] UInt32[] shaders, Int32 maxShaders, [OutAttribute] Int32[] numShaders);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            public static extern void ExtGetShaders([OutAttribute] out UInt32 shaders, Int32 maxShaders, [OutAttribute] out Int32 numShaders);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            public static extern unsafe void ExtGetShaders([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            public static extern void ExtGetTexLevelParameter(Int32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            public static extern void ExtGetTexLevelParameter(Int32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            public static extern unsafe void ExtGetTexLevelParameter(Int32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            public static extern void ExtGetTexLevelParameter(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            public static extern void ExtGetTexLevelParameter(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            public static extern unsafe void ExtGetTexLevelParameter(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            public static extern void ExtGetTexSubImage(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [OutAttribute] IntPtr texels);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            public static extern void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T10[] texels)
                where T10 : struct
            ;

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            public static extern void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T10[,] texels)
                where T10 : struct
            ;

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            public static extern void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T10[,,] texels)
                where T10 : struct
            ;

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            public static extern void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T10 texels)
                where T10 : struct
            ;

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            public static extern void ExtGetTextures([OutAttribute] Int32[] textures, Int32 maxTextures, [OutAttribute] Int32[] numTextures);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            public static extern void ExtGetTextures([OutAttribute] out Int32 textures, Int32 maxTextures, [OutAttribute] out Int32 numTextures);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            public static extern unsafe void ExtGetTextures([OutAttribute] Int32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            public static extern void ExtGetTextures([OutAttribute] UInt32[] textures, Int32 maxTextures, [OutAttribute] Int32[] numTextures);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            public static extern void ExtGetTextures([OutAttribute] out UInt32 textures, Int32 maxTextures, [OutAttribute] out Int32 numTextures);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            public static extern unsafe void ExtGetTextures([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtIsProgramBinaryQCOM")]
            public static extern bool ExtIsProgramBinary(Int32 program);

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtIsProgramBinaryQCOM")]
            public static extern bool ExtIsProgramBinary(UInt32 program);

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtTexObjectStateOverrideiQCOM")]
            public static extern void ExtTexObjectStateOverride(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            public static extern void GetDriverControl([OutAttribute] Int32[] num, Int32 size, [OutAttribute] Int32[] driverControls);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            public static extern void GetDriverControl([OutAttribute] Int32[] num, Int32 size, [OutAttribute] UInt32[] driverControls);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            public static extern void GetDriverControl([OutAttribute] out Int32 num, Int32 size, [OutAttribute] out Int32 driverControls);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            public static extern void GetDriverControl([OutAttribute] out Int32 num, Int32 size, [OutAttribute] out UInt32 driverControls);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            public static extern unsafe void GetDriverControl([OutAttribute] Int32* num, Int32 size, [OutAttribute] Int32* driverControls);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            public static extern unsafe void GetDriverControl([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            public static extern void GetDriverControlString(Int32 driverControl, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] StringBuilder driverControlString);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            public static extern void GetDriverControlString(Int32 driverControl, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder driverControlString);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            public static extern unsafe void GetDriverControlString(Int32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            public static extern void GetDriverControlString(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] StringBuilder driverControlString);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            public static extern void GetDriverControlString(UInt32 driverControl, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder driverControlString);

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            public static extern unsafe void GetDriverControlString(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString);

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glStartTilingQCOM")]
            public static extern void StartTiling(Int32 x, Int32 y, Int32 width, Int32 height, Int32 preserveMask);

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glStartTilingQCOM")]
            public static extern void StartTiling(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);

        }

        [Slot(31)]
        static extern OpenTK.Graphics.ES11.All glClientWaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
        [Slot(53)]
        static extern void glCopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);
        [Slot(60)]
        static extern void glDeleteSyncAPPLE(IntPtr sync);
        [Slot(106)]
        static extern IntPtr glFenceSyncAPPLE(OpenTK.Graphics.ES11.All condition, UInt32 flags);
        [Slot(151)]
        static extern unsafe void glGetInteger64vAPPLE(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int64* @params);
        [Slot(168)]
        static extern unsafe void glGetSyncivAPPLE(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
        [Slot(189)]
        static extern bool glIsSyncAPPLE(IntPtr sync);
        [Slot(294)]
        static extern void glRenderbufferStorageMultisampleAPPLE(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
        [Slot(298)]
        static extern void glResolveMultisampleFramebufferAPPLE();
        [Slot(382)]
        static extern void glWaitSyncAPPLE(IntPtr sync, UInt32 flags, UInt64 timeout);
        [Slot(1)]
        static extern void glActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture);
        [Slot(2)]
        static extern void glAlphaFunc(OpenTK.Graphics.ES11.AlphaFunction func, Single @ref);
        [Slot(3)]
        static extern void glAlphaFuncx(OpenTK.Graphics.ES11.All func, int @ref);
        [Slot(5)]
        static extern void glBindBuffer(OpenTK.Graphics.ES11.All target, UInt32 buffer);
        [Slot(8)]
        static extern void glBindTexture(OpenTK.Graphics.ES11.TextureTarget target, UInt32 texture);
        [Slot(15)]
        static extern void glBlendFunc(OpenTK.Graphics.ES11.BlendingFactorSrc sfactor, OpenTK.Graphics.ES11.BlendingFactorDest dfactor);
        [Slot(17)]
        static extern void glBufferData(OpenTK.Graphics.ES11.All target, IntPtr size, IntPtr data, OpenTK.Graphics.ES11.All usage);
        [Slot(18)]
        static extern void glBufferSubData(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, IntPtr data);
        [Slot(20)]
        static extern void glClear(OpenTK.Graphics.ES11.ClearBufferMask mask);
        [Slot(22)]
        static extern void glClearColor(Single red, Single green, Single blue, Single alpha);
        [Slot(23)]
        static extern void glClearColorx(int red, int green, int blue, int alpha);
        [Slot(25)]
        static extern void glClearDepthf(Single d);
        [Slot(27)]
        static extern void glClearDepthx(int depth);
        [Slot(29)]
        static extern void glClearStencil(Int32 s);
        [Slot(30)]
        static extern void glClientActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture);
        [Slot(32)]
        static extern unsafe void glClipPlanef(OpenTK.Graphics.ES11.All p, Single* eqn);
        [Slot(35)]
        static extern unsafe void glClipPlanex(OpenTK.Graphics.ES11.All plane, int* equation);
        [Slot(40)]
        static extern void glColor4f(Single red, Single green, Single blue, Single alpha);
        [Slot(41)]
        static extern void glColor4ub(Byte red, Byte green, Byte blue, Byte alpha);
        [Slot(42)]
        static extern void glColor4x(int red, int green, int blue, int alpha);
        [Slot(45)]
        static extern void glColorMask(bool red, bool green, bool blue, bool alpha);
        [Slot(46)]
        static extern void glColorPointer(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, IntPtr pointer);
        [Slot(47)]
        static extern void glCompressedTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
        [Slot(48)]
        static extern void glCompressedTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, IntPtr data);
        [Slot(51)]
        static extern void glCopyTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
        [Slot(52)]
        static extern void glCopyTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        [Slot(54)]
        static extern void glCullFace(OpenTK.Graphics.ES11.CullFaceMode mode);
        [Slot(56)]
        static extern unsafe void glDeleteBuffers(Int32 n, UInt32* buffers);
        [Slot(61)]
        static extern unsafe void glDeleteTextures(Int32 n, UInt32* textures);
        [Slot(63)]
        static extern void glDepthFunc(OpenTK.Graphics.ES11.DepthFunction func);
        [Slot(64)]
        static extern void glDepthMask(bool flag);
        [Slot(65)]
        static extern void glDepthRangef(Single n, Single f);
        [Slot(67)]
        static extern void glDepthRangex(int n, int f);
        [Slot(69)]
        static extern void glDisable(OpenTK.Graphics.ES11.EnableCap cap);
        [Slot(70)]
        static extern void glDisableClientState(OpenTK.Graphics.ES11.EnableCap array);
        [Slot(73)]
        static extern void glDrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 first, Int32 count);
        [Slot(74)]
        static extern void glDrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices);
        [Slot(85)]
        static extern void glEnable(OpenTK.Graphics.ES11.EnableCap cap);
        [Slot(86)]
        static extern void glEnableClientState(OpenTK.Graphics.ES11.EnableCap array);
        [Slot(107)]
        static extern void glFinish();
        [Slot(109)]
        static extern void glFlush();
        [Slot(111)]
        static extern void glFogf(OpenTK.Graphics.ES11.FogParameter pname, Single param);
        [Slot(112)]
        static extern unsafe void glFogfv(OpenTK.Graphics.ES11.FogParameter pname, Single* @params);
        [Slot(113)]
        static extern void glFogx(OpenTK.Graphics.ES11.All pname, int param);
        [Slot(115)]
        static extern unsafe void glFogxv(OpenTK.Graphics.ES11.All pname, int* param);
        [Slot(121)]
        static extern void glFrontFace(OpenTK.Graphics.ES11.FrontFaceDirection mode);
        [Slot(122)]
        static extern void glFrustumf(Single l, Single r, Single b, Single t, Single n, Single f);
        [Slot(124)]
        static extern void glFrustumx(int l, int r, int b, int t, int n, int f);
        [Slot(126)]
        static extern unsafe void glGenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
        [Slot(131)]
        static extern unsafe void glGenTextures(Int32 n, [OutAttribute] UInt32* textures);
        [Slot(133)]
        static extern unsafe void glGetBooleanv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool* data);
        [Slot(134)]
        static extern unsafe void glGetBufferParameteriv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
        [Slot(136)]
        static extern unsafe void glGetClipPlanef(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation);
        [Slot(138)]
        static extern unsafe void glGetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation);
        [Slot(143)]
        static extern OpenTK.Graphics.ES11.ErrorCode glGetError();
        [Slot(145)]
        static extern unsafe void glGetFixedv(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(147)]
        static extern unsafe void glGetFloatv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single* data);
        [Slot(152)]
        static extern unsafe void glGetIntegerv(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32* data);
        [Slot(153)]
        static extern unsafe void glGetLightfv(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single* @params);
        [Slot(155)]
        static extern unsafe void glGetLightxv(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(158)]
        static extern unsafe void glGetMaterialfv(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single* @params);
        [Slot(160)]
        static extern unsafe void glGetMaterialxv(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(164)]
        static extern unsafe void glGetPixelMapxv(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] int* values);
        [Slot(165)]
        static extern void glGetPointerv(OpenTK.Graphics.ES11.GetPointervPName pname, [OutAttribute] IntPtr @params);
        [Slot(167)]
        static extern IntPtr glGetString(OpenTK.Graphics.ES11.StringName name);
        [Slot(169)]
        static extern unsafe void glGetTexEnvfv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single* @params);
        [Slot(170)]
        static extern unsafe void glGetTexEnviv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32* @params);
        [Slot(171)]
        static extern unsafe void glGetTexEnvxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(177)]
        static extern unsafe void glGetTexParameterfv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single* @params);
        [Slot(178)]
        static extern unsafe void glGetTexParameteriv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32* @params);
        [Slot(179)]
        static extern unsafe void glGetTexParameterxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(181)]
        static extern void glHint(OpenTK.Graphics.ES11.HintTarget target, OpenTK.Graphics.ES11.HintMode mode);
        [Slot(184)]
        static extern bool glIsBuffer(UInt32 buffer);
        [Slot(185)]
        static extern bool glIsEnabled(OpenTK.Graphics.ES11.EnableCap cap);
        [Slot(190)]
        static extern bool glIsTexture(UInt32 texture);
        [Slot(192)]
        static extern void glLightf(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single param);
        [Slot(193)]
        static extern unsafe void glLightfv(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single* @params);
        [Slot(194)]
        static extern void glLightModelf(OpenTK.Graphics.ES11.LightModelParameter pname, Single param);
        [Slot(195)]
        static extern unsafe void glLightModelfv(OpenTK.Graphics.ES11.LightModelParameter pname, Single* @params);
        [Slot(196)]
        static extern void glLightModelx(OpenTK.Graphics.ES11.All pname, int param);
        [Slot(198)]
        static extern unsafe void glLightModelxv(OpenTK.Graphics.ES11.All pname, int* param);
        [Slot(200)]
        static extern void glLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param);
        [Slot(202)]
        static extern unsafe void glLightxv(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params);
        [Slot(204)]
        static extern void glLineWidth(Single width);
        [Slot(205)]
        static extern void glLineWidthx(int width);
        [Slot(207)]
        static extern void glLoadIdentity();
        [Slot(208)]
        static extern unsafe void glLoadMatrixf(Single* m);
        [Slot(209)]
        static extern unsafe void glLoadMatrixx(int* m);
        [Slot(213)]
        static extern void glLogicOp(OpenTK.Graphics.ES11.LogicOp opcode);
        [Slot(220)]
        static extern void glMaterialf(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single param);
        [Slot(221)]
        static extern unsafe void glMaterialfv(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single* @params);
        [Slot(222)]
        static extern void glMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);
        [Slot(224)]
        static extern unsafe void glMaterialxv(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param);
        [Slot(227)]
        static extern void glMatrixMode(OpenTK.Graphics.ES11.MatrixMode mode);
        [Slot(244)]
        static extern void glMultiTexCoord4f(OpenTK.Graphics.ES11.TextureUnit target, Single s, Single t, Single r, Single q);
        [Slot(245)]
        static extern void glMultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q);
        [Slot(248)]
        static extern unsafe void glMultMatrixf(Single* m);
        [Slot(249)]
        static extern unsafe void glMultMatrixx(int* m);
        [Slot(252)]
        static extern void glNormal3f(Single nx, Single ny, Single nz);
        [Slot(253)]
        static extern void glNormal3x(int nx, int ny, int nz);
        [Slot(256)]
        static extern void glNormalPointer(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, IntPtr pointer);
        [Slot(257)]
        static extern void glOrthof(Single l, Single r, Single b, Single t, Single n, Single f);
        [Slot(259)]
        static extern void glOrthox(int l, int r, int b, int t, int n, int f);
        [Slot(262)]
        static extern unsafe void glPixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, int* values);
        [Slot(263)]
        static extern void glPixelStorei(OpenTK.Graphics.ES11.PixelStoreParameter pname, Int32 param);
        [Slot(264)]
        static extern void glPixelStorex(OpenTK.Graphics.ES11.All pname, int param);
        [Slot(267)]
        static extern void glPointParameterf(OpenTK.Graphics.ES11.All pname, Single param);
        [Slot(268)]
        static extern unsafe void glPointParameterfv(OpenTK.Graphics.ES11.All pname, Single* @params);
        [Slot(269)]
        static extern void glPointParameterx(OpenTK.Graphics.ES11.All pname, int param);
        [Slot(271)]
        static extern unsafe void glPointParameterxv(OpenTK.Graphics.ES11.All pname, int* @params);
        [Slot(273)]
        static extern void glPointSize(Single size);
        [Slot(275)]
        static extern void glPointSizex(int size);
        [Slot(277)]
        static extern void glPolygonOffset(Single factor, Single units);
        [Slot(278)]
        static extern void glPolygonOffsetx(int factor, int units);
        [Slot(280)]
        static extern void glPopMatrix();
        [Slot(282)]
        static extern void glPushMatrix();
        [Slot(291)]
        static extern void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [OutAttribute] IntPtr pixels);
        [Slot(299)]
        static extern void glRotatef(Single angle, Single x, Single y, Single z);
        [Slot(300)]
        static extern void glRotatex(int angle, int x, int y, int z);
        [Slot(302)]
        static extern void glSampleCoverage(Single value, bool invert);
        [Slot(304)]
        static extern void glSampleCoveragex(int value, bool invert);
        [Slot(306)]
        static extern void glScalef(Single x, Single y, Single z);
        [Slot(307)]
        static extern void glScalex(int x, int y, int z);
        [Slot(309)]
        static extern void glScissor(Int32 x, Int32 y, Int32 width, Int32 height);
        [Slot(311)]
        static extern void glShadeModel(OpenTK.Graphics.ES11.ShadingModel mode);
        [Slot(313)]
        static extern void glStencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, UInt32 mask);
        [Slot(314)]
        static extern void glStencilMask(UInt32 mask);
        [Slot(315)]
        static extern void glStencilOp(OpenTK.Graphics.ES11.StencilOp fail, OpenTK.Graphics.ES11.StencilOp zfail, OpenTK.Graphics.ES11.StencilOp zpass);
        [Slot(333)]
        static extern void glTexCoordPointer(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, IntPtr pointer);
        [Slot(334)]
        static extern void glTexEnvf(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single param);
        [Slot(335)]
        static extern unsafe void glTexEnvfv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single* @params);
        [Slot(336)]
        static extern void glTexEnvi(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32 param);
        [Slot(337)]
        static extern unsafe void glTexEnviv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32* @params);
        [Slot(338)]
        static extern void glTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
        [Slot(340)]
        static extern unsafe void glTexEnvxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
        [Slot(348)]
        static extern void glTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels);
        [Slot(349)]
        static extern void glTexParameterf(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single param);
        [Slot(350)]
        static extern unsafe void glTexParameterfv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single* @params);
        [Slot(351)]
        static extern void glTexParameteri(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32 param);
        [Slot(352)]
        static extern unsafe void glTexParameteriv(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32* @params);
        [Slot(353)]
        static extern void glTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
        [Slot(355)]
        static extern unsafe void glTexParameterxv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
        [Slot(360)]
        static extern void glTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels);
        [Slot(364)]
        static extern void glTranslatef(Single x, Single y, Single z);
        [Slot(365)]
        static extern void glTranslatex(int x, int y, int z);
        [Slot(380)]
        static extern void glVertexPointer(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, IntPtr pointer);
        [Slot(381)]
        static extern void glViewport(Int32 x, Int32 y, Int32 width, Int32 height);
        [Slot(12)]
        static extern void glBlendEquationEXT(OpenTK.Graphics.ES11.All mode);
        [Slot(72)]
        static extern unsafe void glDiscardFramebufferEXT(OpenTK.Graphics.ES11.All target, Int32 numAttachments, OpenTK.Graphics.ES11.All* attachments);
        [Slot(110)]
        static extern void glFlushMappedBufferRangeEXT(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length);
        [Slot(118)]
        static extern void glFramebufferTexture2DMultisampleEXT(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples);
        [Slot(149)]
        static extern OpenTK.Graphics.ES11.All glGetGraphicsResetStatusEXT();
        [Slot(162)]
        static extern unsafe void glGetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
        [Slot(163)]
        static extern unsafe void glGetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
        [Slot(217)]
        static extern IntPtr glMapBufferRangeEXT(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length, UInt32 access);
        [Slot(228)]
        static extern unsafe void glMultiDrawArraysEXT(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount);
        [Slot(229)]
        static extern unsafe void glMultiDrawElementsEXT(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount);
        [Slot(290)]
        static extern void glReadnPixelsEXT(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [OutAttribute] IntPtr data);
        [Slot(295)]
        static extern void glRenderbufferStorageMultisampleEXT(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
        [Slot(357)]
        static extern void glTexStorage1DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width);
        [Slot(358)]
        static extern void glTexStorage2DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
        [Slot(359)]
        static extern void glTexStorage3DEXT(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth);
        [Slot(361)]
        static extern void glTextureStorage1DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width);
        [Slot(362)]
        static extern void glTextureStorage2DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
        [Slot(363)]
        static extern void glTextureStorage3DEXT(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth);
        [Slot(33)]
        static extern unsafe void glClipPlanefIMG(OpenTK.Graphics.ES11.All p, Single* eqn);
        [Slot(36)]
        static extern unsafe void glClipPlanexIMG(OpenTK.Graphics.ES11.All p, int* eqn);
        [Slot(119)]
        static extern void glFramebufferTexture2DMultisampleIMG(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples);
        [Slot(296)]
        static extern void glRenderbufferStorageMultisampleIMG(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
        [Slot(57)]
        static extern unsafe void glDeleteFencesNV(Int32 n, UInt32* fences);
        [Slot(108)]
        static extern void glFinishFenceNV(UInt32 fence);
        [Slot(128)]
        static extern unsafe void glGenFencesNV(Int32 n, [OutAttribute] UInt32* fences);
        [Slot(144)]
        static extern unsafe void glGetFenceivNV(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
        [Slot(186)]
        static extern bool glIsFenceNV(UInt32 fence);
        [Slot(310)]
        static extern void glSetFenceNV(UInt32 fence, OpenTK.Graphics.ES11.All condition);
        [Slot(316)]
        static extern bool glTestFenceNV(UInt32 fence);
        [Slot(0)]
        static extern void glAccumxOES(OpenTK.Graphics.ES11.All op, int value);
        [Slot(4)]
        static extern void glAlphaFuncxOES(OpenTK.Graphics.ES11.All func, int @ref);
        [Slot(6)]
        static extern void glBindFramebufferOES(OpenTK.Graphics.ES11.All target, UInt32 framebuffer);
        [Slot(7)]
        static extern void glBindRenderbufferOES(OpenTK.Graphics.ES11.All target, UInt32 renderbuffer);
        [Slot(9)]
        static extern void glBindVertexArrayOES(UInt32 array);
        [Slot(10)]
        static extern unsafe void glBitmapxOES(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte* bitmap);
        [Slot(11)]
        static extern void glBlendColorxOES(int red, int green, int blue, int alpha);
        [Slot(13)]
        static extern void glBlendEquationOES(OpenTK.Graphics.ES11.All mode);
        [Slot(14)]
        static extern void glBlendEquationSeparateOES(OpenTK.Graphics.ES11.All modeRGB, OpenTK.Graphics.ES11.All modeAlpha);
        [Slot(16)]
        static extern void glBlendFuncSeparateOES(OpenTK.Graphics.ES11.All srcRGB, OpenTK.Graphics.ES11.All dstRGB, OpenTK.Graphics.ES11.All srcAlpha, OpenTK.Graphics.ES11.All dstAlpha);
        [Slot(19)]
        static extern OpenTK.Graphics.ES11.All glCheckFramebufferStatusOES(OpenTK.Graphics.ES11.All target);
        [Slot(21)]
        static extern void glClearAccumxOES(int red, int green, int blue, int alpha);
        [Slot(24)]
        static extern void glClearColorxOES(int red, int green, int blue, int alpha);
        [Slot(26)]
        static extern void glClearDepthfOES(Single depth);
        [Slot(28)]
        static extern void glClearDepthxOES(int depth);
        [Slot(34)]
        static extern unsafe void glClipPlanefOES(OpenTK.Graphics.ES11.All plane, Single* equation);
        [Slot(37)]
        static extern unsafe void glClipPlanexOES(OpenTK.Graphics.ES11.All plane, int* equation);
        [Slot(38)]
        static extern void glColor3xOES(int red, int green, int blue);
        [Slot(39)]
        static extern unsafe void glColor3xvOES(int* components);
        [Slot(43)]
        static extern void glColor4xOES(int red, int green, int blue, int alpha);
        [Slot(44)]
        static extern unsafe void glColor4xvOES(int* components);
        [Slot(49)]
        static extern void glConvolutionParameterxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
        [Slot(50)]
        static extern unsafe void glConvolutionParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
        [Slot(55)]
        static extern void glCurrentPaletteMatrixOES(UInt32 matrixpaletteindex);
        [Slot(58)]
        static extern unsafe void glDeleteFramebuffersOES(Int32 n, UInt32* framebuffers);
        [Slot(59)]
        static extern unsafe void glDeleteRenderbuffersOES(Int32 n, UInt32* renderbuffers);
        [Slot(62)]
        static extern unsafe void glDeleteVertexArraysOES(Int32 n, UInt32* arrays);
        [Slot(66)]
        static extern void glDepthRangefOES(Single n, Single f);
        [Slot(68)]
        static extern void glDepthRangexOES(int n, int f);
        [Slot(75)]
        static extern void glDrawTexfOES(Single x, Single y, Single z, Single width, Single height);
        [Slot(76)]
        static extern unsafe void glDrawTexfvOES(Single* coords);
        [Slot(77)]
        static extern void glDrawTexiOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height);
        [Slot(78)]
        static extern unsafe void glDrawTexivOES(Int32* coords);
        [Slot(79)]
        static extern void glDrawTexsOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height);
        [Slot(80)]
        static extern unsafe void glDrawTexsvOES(Int16* coords);
        [Slot(81)]
        static extern void glDrawTexxOES(int x, int y, int z, int width, int height);
        [Slot(82)]
        static extern unsafe void glDrawTexxvOES(int* coords);
        [Slot(83)]
        static extern void glEGLImageTargetRenderbufferStorageOES(OpenTK.Graphics.ES11.All target, IntPtr image);
        [Slot(84)]
        static extern void glEGLImageTargetTexture2DOES(OpenTK.Graphics.ES11.All target, IntPtr image);
        [Slot(89)]
        static extern void glEvalCoord1xOES(int u);
        [Slot(90)]
        static extern unsafe void glEvalCoord1xvOES(int* coords);
        [Slot(91)]
        static extern void glEvalCoord2xOES(int u, int v);
        [Slot(92)]
        static extern unsafe void glEvalCoord2xvOES(int* coords);
        [Slot(105)]
        static extern unsafe void glFeedbackBufferxOES(Int32 n, OpenTK.Graphics.ES11.All type, int* buffer);
        [Slot(114)]
        static extern void glFogxOES(OpenTK.Graphics.ES11.All pname, int param);
        [Slot(116)]
        static extern unsafe void glFogxvOES(OpenTK.Graphics.ES11.All pname, int* param);
        [Slot(117)]
        static extern void glFramebufferRenderbufferOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All renderbuffertarget, UInt32 renderbuffer);
        [Slot(120)]
        static extern void glFramebufferTexture2DOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level);
        [Slot(123)]
        static extern void glFrustumfOES(Single l, Single r, Single b, Single t, Single n, Single f);
        [Slot(125)]
        static extern void glFrustumxOES(int l, int r, int b, int t, int n, int f);
        [Slot(127)]
        static extern void glGenerateMipmapOES(OpenTK.Graphics.ES11.All target);
        [Slot(129)]
        static extern unsafe void glGenFramebuffersOES(Int32 n, [OutAttribute] UInt32* framebuffers);
        [Slot(130)]
        static extern unsafe void glGenRenderbuffersOES(Int32 n, [OutAttribute] UInt32* renderbuffers);
        [Slot(132)]
        static extern unsafe void glGenVertexArraysOES(Int32 n, [OutAttribute] UInt32* arrays);
        [Slot(135)]
        static extern void glGetBufferPointervOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] IntPtr @params);
        [Slot(137)]
        static extern unsafe void glGetClipPlanefOES(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation);
        [Slot(139)]
        static extern unsafe void glGetClipPlanexOES(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation);
        [Slot(140)]
        static extern unsafe void glGetConvolutionParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(146)]
        static extern unsafe void glGetFixedvOES(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(148)]
        static extern unsafe void glGetFramebufferAttachmentParameterivOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
        [Slot(150)]
        static extern unsafe void glGetHistogramParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(154)]
        static extern unsafe void glGetLightxOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(157)]
        static extern unsafe void glGetMapxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] int* v);
        [Slot(159)]
        static extern void glGetMaterialxOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);
        [Slot(161)]
        static extern unsafe void glGetMaterialxvOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(166)]
        static extern unsafe void glGetRenderbufferParameterivOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
        [Slot(172)]
        static extern unsafe void glGetTexEnvxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(173)]
        static extern unsafe void glGetTexGenfvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params);
        [Slot(174)]
        static extern unsafe void glGetTexGenivOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
        [Slot(175)]
        static extern unsafe void glGetTexGenxvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(176)]
        static extern unsafe void glGetTexLevelParameterxvOES(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(180)]
        static extern unsafe void glGetTexParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params);
        [Slot(182)]
        static extern void glIndexxOES(int component);
        [Slot(183)]
        static extern unsafe void glIndexxvOES(int* component);
        [Slot(187)]
        static extern bool glIsFramebufferOES(UInt32 framebuffer);
        [Slot(188)]
        static extern bool glIsRenderbufferOES(UInt32 renderbuffer);
        [Slot(191)]
        static extern bool glIsVertexArrayOES(UInt32 array);
        [Slot(197)]
        static extern void glLightModelxOES(OpenTK.Graphics.ES11.All pname, int param);
        [Slot(199)]
        static extern unsafe void glLightModelxvOES(OpenTK.Graphics.ES11.All pname, int* param);
        [Slot(201)]
        static extern void glLightxOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param);
        [Slot(203)]
        static extern unsafe void glLightxvOES(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params);
        [Slot(206)]
        static extern void glLineWidthxOES(int width);
        [Slot(210)]
        static extern unsafe void glLoadMatrixxOES(int* m);
        [Slot(211)]
        static extern void glLoadPaletteFromModelViewMatrixOES();
        [Slot(212)]
        static extern unsafe void glLoadTransposeMatrixxOES(int* m);
        [Slot(214)]
        static extern void glMap1xOES(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 stride, Int32 order, int points);
        [Slot(215)]
        static extern void glMap2xOES(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 ustride, Int32 uorder, int v1, int v2, Int32 vstride, Int32 vorder, int points);
        [Slot(216)]
        static extern IntPtr glMapBufferOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All access);
        [Slot(218)]
        static extern void glMapGrid1xOES(Int32 n, int u1, int u2);
        [Slot(219)]
        static extern void glMapGrid2xOES(Int32 n, int u1, int u2, int v1, int v2);
        [Slot(223)]
        static extern void glMaterialxOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param);
        [Slot(225)]
        static extern unsafe void glMaterialxvOES(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param);
        [Slot(226)]
        static extern void glMatrixIndexPointerOES(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);
        [Slot(230)]
        static extern void glMultiTexCoord1bOES(OpenTK.Graphics.ES11.All texture, SByte s);
        [Slot(231)]
        static extern unsafe void glMultiTexCoord1bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
        [Slot(232)]
        static extern void glMultiTexCoord1xOES(OpenTK.Graphics.ES11.All texture, int s);
        [Slot(233)]
        static extern unsafe void glMultiTexCoord1xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
        [Slot(234)]
        static extern void glMultiTexCoord2bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t);
        [Slot(235)]
        static extern unsafe void glMultiTexCoord2bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
        [Slot(236)]
        static extern void glMultiTexCoord2xOES(OpenTK.Graphics.ES11.All texture, int s, int t);
        [Slot(237)]
        static extern unsafe void glMultiTexCoord2xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
        [Slot(238)]
        static extern void glMultiTexCoord3bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r);
        [Slot(239)]
        static extern unsafe void glMultiTexCoord3bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
        [Slot(240)]
        static extern void glMultiTexCoord3xOES(OpenTK.Graphics.ES11.All texture, int s, int t, int r);
        [Slot(241)]
        static extern unsafe void glMultiTexCoord3xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
        [Slot(242)]
        static extern void glMultiTexCoord4bOES(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r, SByte q);
        [Slot(243)]
        static extern unsafe void glMultiTexCoord4bvOES(OpenTK.Graphics.ES11.All texture, SByte* coords);
        [Slot(246)]
        static extern void glMultiTexCoord4xOES(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q);
        [Slot(247)]
        static extern unsafe void glMultiTexCoord4xvOES(OpenTK.Graphics.ES11.All texture, int* coords);
        [Slot(250)]
        static extern unsafe void glMultMatrixxOES(int* m);
        [Slot(251)]
        static extern unsafe void glMultTransposeMatrixxOES(int* m);
        [Slot(254)]
        static extern void glNormal3xOES(int nx, int ny, int nz);
        [Slot(255)]
        static extern unsafe void glNormal3xvOES(int* coords);
        [Slot(258)]
        static extern void glOrthofOES(Single l, Single r, Single b, Single t, Single n, Single f);
        [Slot(260)]
        static extern void glOrthoxOES(int l, int r, int b, int t, int n, int f);
        [Slot(261)]
        static extern void glPassThroughxOES(int token);
        [Slot(265)]
        static extern void glPixelTransferxOES(OpenTK.Graphics.ES11.All pname, int param);
        [Slot(266)]
        static extern void glPixelZoomxOES(int xfactor, int yfactor);
        [Slot(270)]
        static extern void glPointParameterxOES(OpenTK.Graphics.ES11.All pname, int param);
        [Slot(272)]
        static extern unsafe void glPointParameterxvOES(OpenTK.Graphics.ES11.All pname, int* @params);
        [Slot(274)]
        static extern void glPointSizePointerOES(OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);
        [Slot(276)]
        static extern void glPointSizexOES(int size);
        [Slot(279)]
        static extern void glPolygonOffsetxOES(int factor, int units);
        [Slot(281)]
        static extern unsafe void glPrioritizeTexturesxOES(Int32 n, UInt32* textures, int* priorities);
        [Slot(283)]
        static extern unsafe Int32 glQueryMatrixxOES([OutAttribute] int* mantissa, [OutAttribute] Int32* exponent);
        [Slot(284)]
        static extern void glRasterPos2xOES(int x, int y);
        [Slot(285)]
        static extern unsafe void glRasterPos2xvOES(int* coords);
        [Slot(286)]
        static extern void glRasterPos3xOES(int x, int y, int z);
        [Slot(287)]
        static extern unsafe void glRasterPos3xvOES(int* coords);
        [Slot(288)]
        static extern void glRasterPos4xOES(int x, int y, int z, int w);
        [Slot(289)]
        static extern unsafe void glRasterPos4xvOES(int* coords);
        [Slot(292)]
        static extern void glRectxOES(int x1, int y1, int x2, int y2);
        [Slot(293)]
        static extern unsafe void glRectxvOES(int* v1, int* v2);
        [Slot(297)]
        static extern void glRenderbufferStorageOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height);
        [Slot(301)]
        static extern void glRotatexOES(int angle, int x, int y, int z);
        [Slot(303)]
        static extern void glSampleCoverageOES(int value, bool invert);
        [Slot(305)]
        static extern void glSampleCoveragexOES(int value, bool invert);
        [Slot(308)]
        static extern void glScalexOES(int x, int y, int z);
        [Slot(317)]
        static extern void glTexCoord1bOES(SByte s);
        [Slot(318)]
        static extern unsafe void glTexCoord1bvOES(SByte* coords);
        [Slot(319)]
        static extern void glTexCoord1xOES(int s);
        [Slot(320)]
        static extern unsafe void glTexCoord1xvOES(int* coords);
        [Slot(321)]
        static extern void glTexCoord2bOES(SByte s, SByte t);
        [Slot(322)]
        static extern unsafe void glTexCoord2bvOES(SByte* coords);
        [Slot(323)]
        static extern void glTexCoord2xOES(int s, int t);
        [Slot(324)]
        static extern unsafe void glTexCoord2xvOES(int* coords);
        [Slot(325)]
        static extern void glTexCoord3bOES(SByte s, SByte t, SByte r);
        [Slot(326)]
        static extern unsafe void glTexCoord3bvOES(SByte* coords);
        [Slot(327)]
        static extern void glTexCoord3xOES(int s, int t, int r);
        [Slot(328)]
        static extern unsafe void glTexCoord3xvOES(int* coords);
        [Slot(329)]
        static extern void glTexCoord4bOES(SByte s, SByte t, SByte r, SByte q);
        [Slot(330)]
        static extern unsafe void glTexCoord4bvOES(SByte* coords);
        [Slot(331)]
        static extern void glTexCoord4xOES(int s, int t, int r, int q);
        [Slot(332)]
        static extern unsafe void glTexCoord4xvOES(int* coords);
        [Slot(339)]
        static extern void glTexEnvxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
        [Slot(341)]
        static extern unsafe void glTexEnvxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
        [Slot(342)]
        static extern void glTexGenfOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single param);
        [Slot(343)]
        static extern unsafe void glTexGenfvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single* @params);
        [Slot(344)]
        static extern void glTexGeniOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32 param);
        [Slot(345)]
        static extern unsafe void glTexGenivOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32* @params);
        [Slot(346)]
        static extern void glTexGenxOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int param);
        [Slot(347)]
        static extern unsafe void glTexGenxvOES(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int* @params);
        [Slot(354)]
        static extern void glTexParameterxOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param);
        [Slot(356)]
        static extern unsafe void glTexParameterxvOES(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params);
        [Slot(366)]
        static extern void glTranslatexOES(int x, int y, int z);
        [Slot(367)]
        static extern bool glUnmapBufferOES(OpenTK.Graphics.ES11.All target);
        [Slot(368)]
        static extern void glVertex2bOES(SByte x);
        [Slot(369)]
        static extern unsafe void glVertex2bvOES(SByte* coords);
        [Slot(370)]
        static extern void glVertex2xOES(int x);
        [Slot(371)]
        static extern unsafe void glVertex2xvOES(int* coords);
        [Slot(372)]
        static extern void glVertex3bOES(SByte x, SByte y);
        [Slot(373)]
        static extern unsafe void glVertex3bvOES(SByte* coords);
        [Slot(374)]
        static extern void glVertex3xOES(int x, int y);
        [Slot(375)]
        static extern unsafe void glVertex3xvOES(int* coords);
        [Slot(376)]
        static extern void glVertex4bOES(SByte x, SByte y, SByte z);
        [Slot(377)]
        static extern unsafe void glVertex4bvOES(SByte* coords);
        [Slot(378)]
        static extern void glVertex4xOES(int x, int y, int z);
        [Slot(379)]
        static extern unsafe void glVertex4xvOES(int* coords);
        [Slot(383)]
        static extern void glWeightPointerOES(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer);
        [Slot(71)]
        static extern void glDisableDriverControlQCOM(UInt32 driverControl);
        [Slot(87)]
        static extern void glEnableDriverControlQCOM(UInt32 driverControl);
        [Slot(88)]
        static extern void glEndTilingQCOM(UInt32 preserveMask);
        [Slot(93)]
        static extern void glExtGetBufferPointervQCOM(OpenTK.Graphics.ES11.All target, [OutAttribute] IntPtr @params);
        [Slot(94)]
        static extern unsafe void glExtGetBuffersQCOM([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers);
        [Slot(95)]
        static extern unsafe void glExtGetFramebuffersQCOM([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers);
        [Slot(96)]
        static extern unsafe void glExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length);
        [Slot(97)]
        static extern unsafe void glExtGetProgramsQCOM([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms);
        [Slot(98)]
        static extern unsafe void glExtGetRenderbuffersQCOM([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers);
        [Slot(99)]
        static extern unsafe void glExtGetShadersQCOM([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders);
        [Slot(100)]
        static extern unsafe void glExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params);
        [Slot(101)]
        static extern void glExtGetTexSubImageQCOM(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [OutAttribute] IntPtr texels);
        [Slot(102)]
        static extern unsafe void glExtGetTexturesQCOM([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures);
        [Slot(103)]
        static extern bool glExtIsProgramBinaryQCOM(UInt32 program);
        [Slot(104)]
        static extern void glExtTexObjectStateOverrideiQCOM(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param);
        [Slot(141)]
        static extern unsafe void glGetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls);
        [Slot(142)]
        static extern unsafe void glGetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString);
        [Slot(312)]
        static extern void glStartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);
    }
}
