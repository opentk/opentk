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
            [Slot(31)]
            public static extern 
            OpenTK.Graphics.ES11.All ClientWaitSync(IntPtr sync, Int32 flags, Int64 timeout)
            ;
            

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
            [Slot(31)]
            public static extern 
            OpenTK.Graphics.ES11.All ClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout)
            ;
            

            /// <summary>[requires: APPLE_copy_texture_levels]</summary>
            [AutoGenerated(Category = "APPLE_copy_texture_levels", Version = "", EntryPoint = "glCopyTextureLevelsAPPLE")]
            [Slot(53)]
            public static extern 
            void CopyTextureLevel(Int32 destinationTexture, Int32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount)
            ;
            

            /// <summary>[requires: APPLE_copy_texture_levels]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "APPLE_copy_texture_levels", Version = "", EntryPoint = "glCopyTextureLevelsAPPLE")]
            [Slot(53)]
            public static extern 
            void CopyTextureLevel(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount)
            ;
            

            /// <summary>[requires: APPLE_sync]
            /// Delete a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// The sync object to be deleted.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glDeleteSyncAPPLE")]
            [Slot(60)]
            public static extern 
            void DeleteSync(IntPtr sync)
            ;
            

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
            [Slot(106)]
            public static extern 
            IntPtr FenceSync(OpenTK.Graphics.ES11.All condition, Int32 flags)
            ;
            

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
            [Slot(106)]
            public static extern 
            IntPtr FenceSync(OpenTK.Graphics.ES11.All condition, UInt32 flags)
            ;
            

            /// <summary>[requires: APPLE_sync]</summary>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetInteger64vAPPLE")]
            [Slot(151)]
            public static extern 
            Int64 GetInteger64(OpenTK.Graphics.ES11.All pname)
            ;
            

            /// <summary>[requires: APPLE_sync]</summary>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetInteger64vAPPLE")]
            [Slot(151)]
            public static extern 
            void GetInteger64(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int64[] @params)
            ;
            

            /// <summary>[requires: APPLE_sync]</summary>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetInteger64vAPPLE")]
            [Slot(151)]
            public static extern 
            void GetInteger64(OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int64 @params)
            ;
            

            /// <summary>[requires: APPLE_sync]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glGetInteger64vAPPLE")]
            [Slot(151)]
            public static extern 
            unsafe void GetInteger64(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int64* @params)
            ;
            

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
            [Slot(168)]
            public static extern 
            void GetSync(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] values)
            ;
            

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
            [Slot(168)]
            public static extern 
            void GetSync(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out Int32 values)
            ;
            

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
            [Slot(168)]
            public static extern 
            unsafe void GetSync(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values)
            ;
            

            /// <summary>[requires: APPLE_sync]
            /// Determine if a name corresponds to a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies a value that may be the name of a sync object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "APPLE_sync", Version = "", EntryPoint = "glIsSyncAPPLE")]
            [Slot(189)]
            public static extern 
            bool IsSync(IntPtr sync)
            ;
            

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
            [Slot(294)]
            public static extern 
            void RenderbufferStorageMultisample(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            ;
            

            /// <summary>[requires: APPLE_framebuffer_multisample]</summary>
            [AutoGenerated(Category = "APPLE_framebuffer_multisample", Version = "", EntryPoint = "glResolveMultisampleFramebufferAPPLE")]
            [Slot(298)]
            public static extern 
            void ResolveMultisampleFramebuffer()
            ;
            

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
            [Slot(382)]
            public static extern 
            void WaitSync(IntPtr sync, Int32 flags, Int64 timeout)
            ;
            

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
            [Slot(382)]
            public static extern 
            void WaitSync(IntPtr sync, UInt32 flags, UInt64 timeout)
            ;
            

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
        [Slot(1)]
        public static extern 
        void ActiveTexture(OpenTK.Graphics.ES11.All texture)
        ;
        

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least 80. texture must be one of GL_TEXTUREi, where i ranges from 0 (GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS - 1). The initial value is GL_TEXTURE0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glActiveTexture")]
        [Slot(1)]
        public static extern 
        void ActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture)
        ;
        

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
        [Slot(2)]
        public static extern 
        void AlphaFunc(OpenTK.Graphics.ES11.All func, Single @ref)
        ;
        

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
        [Slot(2)]
        public static extern 
        void AlphaFunc(OpenTK.Graphics.ES11.AlphaFunction func, Single @ref)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glAlphaFuncx")]
        [Slot(3)]
        public static extern 
        void AlphaFuncx(OpenTK.Graphics.ES11.All func, int @ref)
        ;
        

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
        [Slot(5)]
        public static extern 
        void BindBuffer(OpenTK.Graphics.ES11.All target, Int32 buffer)
        ;
        

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
        [Slot(5)]
        public static extern 
        void BindBuffer(OpenTK.Graphics.ES11.All target, UInt32 buffer)
        ;
        

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
        [Slot(8)]
        public static extern 
        void BindTexture(OpenTK.Graphics.ES11.All target, Int32 texture)
        ;
        

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
        [Slot(8)]
        public static extern 
        void BindTexture(OpenTK.Graphics.ES11.All target, UInt32 texture)
        ;
        

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
        [Slot(8)]
        public static extern 
        void BindTexture(OpenTK.Graphics.ES11.TextureTarget target, Int32 texture)
        ;
        

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
        [Slot(8)]
        public static extern 
        void BindTexture(OpenTK.Graphics.ES11.TextureTarget target, UInt32 texture)
        ;
        

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
        [Slot(15)]
        public static extern 
        void BlendFunc(OpenTK.Graphics.ES11.All sfactor, OpenTK.Graphics.ES11.All dfactor)
        ;
        

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
        [Slot(15)]
        public static extern 
        void BlendFunc(OpenTK.Graphics.ES11.BlendingFactorSrc sfactor, OpenTK.Graphics.ES11.BlendingFactorDest dfactor)
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
        [Slot(17)]
        public static extern 
        void BufferData(OpenTK.Graphics.ES11.All target, IntPtr size, IntPtr data, OpenTK.Graphics.ES11.All usage)
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
        [Slot(17)]
        public static extern 
        void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] T2[] data, OpenTK.Graphics.ES11.All usage)
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
        [Slot(17)]
        public static extern 
        void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] T2[,] data, OpenTK.Graphics.ES11.All usage)
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
        [Slot(17)]
        public static extern 
        void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] T2[,,] data, OpenTK.Graphics.ES11.All usage)
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
        [Slot(17)]
        public static extern 
        void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] ref T2 data, OpenTK.Graphics.ES11.All usage)
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
        [Slot(18)]
        public static extern 
        void BufferSubData(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, IntPtr data)
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
        [Slot(18)]
        public static extern 
        void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[] data)
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
        [Slot(18)]
        public static extern 
        void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[,] data)
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
        [Slot(18)]
        public static extern 
        void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[,,] data)
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
        [Slot(18)]
        public static extern 
        void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] ref T3 data)
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
        [Slot(20)]
        public static extern 
        void Clear(OpenTK.Graphics.ES11.All mask)
        ;
        

        /// <summary>[requires: v1.0]
        /// Clear buffers to preset values
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClear")]
        [Slot(20)]
        public static extern 
        void Clear(OpenTK.Graphics.ES11.ClearBufferMask mask)
        ;
        

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
        [Slot(20)]
        public static extern 
        void Clear(Int32 mask)
        ;
        

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
        [Slot(20)]
        public static extern 
        void Clear(UInt32 mask)
        ;
        

        /// <summary>[requires: v1.0]
        /// Specify clear values for the color buffers
        /// </summary>
        /// <param name="red">
        /// <para>
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearColor")]
        [Slot(22)]
        public static extern 
        void ClearColor(Single red, Single green, Single blue, Single alpha)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearColorx")]
        [Slot(23)]
        public static extern 
        void ClearColorx(int red, int green, int blue, int alpha)
        ;
        

        /// <summary>[requires: v1.0]
        /// Specify the clear value for the depth buffer
        /// </summary>
        /// <param name="depth">
        /// <para>
        /// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearDepthf")]
        [Slot(25)]
        public static extern 
        void ClearDepth(Single d)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearDepthx")]
        [Slot(27)]
        public static extern 
        void ClearDepthx(int depth)
        ;
        

        /// <summary>[requires: v1.0]
        /// Specify the clear value for the stencil buffer
        /// </summary>
        /// <param name="s">
        /// <para>
        /// Specifies the index used when the stencil buffer is cleared. The initial value is 0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearStencil")]
        [Slot(29)]
        public static extern 
        void ClearStencil(Int32 s)
        ;
        

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
        [Slot(30)]
        public static extern 
        void ClientActiveTexture(OpenTK.Graphics.ES11.All texture)
        ;
        

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least two. texture must be one of GL_TEXTURE, where i ranges from 0 to the value of GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value. The initial value is GL_TEXTURE0.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClientActiveTexture")]
        [Slot(30)]
        public static extern 
        void ClientActiveTexture(OpenTK.Graphics.ES11.TextureUnit texture)
        ;
        

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
        [Slot(32)]
        public static extern 
        void ClipPlane(OpenTK.Graphics.ES11.All p, Single[] eqn)
        ;
        

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
        [Slot(32)]
        public static extern 
        void ClipPlane(OpenTK.Graphics.ES11.All p, ref Single eqn)
        ;
        

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
        [Slot(32)]
        public static extern 
        unsafe void ClipPlane(OpenTK.Graphics.ES11.All p, Single* eqn)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanex")]
        [Slot(35)]
        public static extern 
        void ClipPlanex(OpenTK.Graphics.ES11.All plane, int[] equation)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanex")]
        [Slot(35)]
        public static extern 
        void ClipPlanex(OpenTK.Graphics.ES11.All plane, ref int equation)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanex")]
        [Slot(35)]
        public static extern 
        unsafe void ClipPlanex(OpenTK.Graphics.ES11.All plane, int* equation)
        ;
        

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
        [Slot(40)]
        public static extern 
        void Color4(Single red, Single green, Single blue, Single alpha)
        ;
        

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
        [Slot(41)]
        public static extern 
        void Color4(Byte red, Byte green, Byte blue, Byte alpha)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColor4x")]
        [Slot(42)]
        public static extern 
        void Color4x(int red, int green, int blue, int alpha)
        ;
        

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
        [Slot(45)]
        public static extern 
        void ColorMask(bool red, bool green, bool blue, bool alpha)
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
        [Slot(46)]
        public static extern 
        void ColorPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer)
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
        [Slot(46)]
        public static extern 
        void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
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
        [Slot(46)]
        public static extern 
        void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
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
        [Slot(46)]
        public static extern 
        void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
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
        [Slot(46)]
        public static extern 
        void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
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
        [Slot(46)]
        public static extern 
        void ColorPointer(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, IntPtr pointer)
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
        [Slot(46)]
        public static extern 
        void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
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
        [Slot(46)]
        public static extern 
        void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
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
        [Slot(46)]
        public static extern 
        void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
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
        [Slot(46)]
        public static extern 
        void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
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
        [Slot(47)]
        public static extern 
        void CompressedTexImage2D(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
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
        [Slot(47)]
        public static extern 
        void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[] data)
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
        [Slot(47)]
        public static extern 
        void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,] data)
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
        [Slot(47)]
        public static extern 
        void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,,] data)
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
        [Slot(47)]
        public static extern 
        void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] ref T7 data)
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
        [Slot(47)]
        public static extern 
        void CompressedTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
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
        [Slot(47)]
        public static extern 
        void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[] data)
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
        [Slot(47)]
        public static extern 
        void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,] data)
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
        [Slot(47)]
        public static extern 
        void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,,] data)
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
        [Slot(47)]
        public static extern 
        void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] ref T7 data)
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
        [Slot(48)]
        public static extern 
        void CompressedTexSubImage2D(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, IntPtr data)
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
        [Slot(48)]
        public static extern 
        void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, [InAttribute, OutAttribute] T8[] data)
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
        [Slot(48)]
        public static extern 
        void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, [InAttribute, OutAttribute] T8[,] data)
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
        [Slot(48)]
        public static extern 
        void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, [InAttribute, OutAttribute] T8[,,] data)
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
        [Slot(48)]
        public static extern 
        void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, Int32 imageSize, [InAttribute, OutAttribute] ref T8 data)
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
        [Slot(48)]
        public static extern 
        void CompressedTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, IntPtr data)
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
        [Slot(48)]
        public static extern 
        void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[] data)
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
        [Slot(48)]
        public static extern 
        void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[,] data)
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
        [Slot(48)]
        public static extern 
        void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[,,] data)
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
        [Slot(48)]
        public static extern 
        void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] ref T8 data)
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
        [Slot(51)]
        public static extern 
        void CopyTexImage2D(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCopyTexImage2D")]
        [Slot(51)]
        public static extern 
        void CopyTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
        ;
        

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
        [Slot(52)]
        public static extern 
        void CopyTexSubImage2D(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
        ;
        

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
        [Slot(52)]
        public static extern 
        void CopyTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
        ;
        

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
        [Slot(54)]
        public static extern 
        void CullFace(OpenTK.Graphics.ES11.All mode)
        ;
        

        /// <summary>[requires: v1.0]
        /// Specify whether front- or back-facing facets can be culled
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies whether front- or back-facing facets are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCullFace")]
        [Slot(54)]
        public static extern 
        void CullFace(OpenTK.Graphics.ES11.CullFaceMode mode)
        ;
        

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
        [Slot(56)]
        public static extern 
        void DeleteBuffer(Int32 buffers)
        ;
        

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
        [Slot(56)]
        public static extern 
        void DeleteBuffer(UInt32 buffers)
        ;
        

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
        [Slot(56)]
        public static extern 
        void DeleteBuffers(Int32 n, Int32[] buffers)
        ;
        

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
        [Slot(56)]
        public static extern 
        void DeleteBuffers(Int32 n, ref Int32 buffers)
        ;
        

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
        [Slot(56)]
        public static extern 
        unsafe void DeleteBuffers(Int32 n, Int32* buffers)
        ;
        

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
        [Slot(56)]
        public static extern 
        void DeleteBuffers(Int32 n, UInt32[] buffers)
        ;
        

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
        [Slot(56)]
        public static extern 
        void DeleteBuffers(Int32 n, ref UInt32 buffers)
        ;
        

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
        [Slot(56)]
        public static extern 
        unsafe void DeleteBuffers(Int32 n, UInt32* buffers)
        ;
        

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
        [Slot(61)]
        public static extern 
        void DeleteTexture(Int32 textures)
        ;
        

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
        [Slot(61)]
        public static extern 
        void DeleteTexture(UInt32 textures)
        ;
        

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
        [Slot(61)]
        public static extern 
        void DeleteTextures(Int32 n, Int32[] textures)
        ;
        

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
        [Slot(61)]
        public static extern 
        void DeleteTextures(Int32 n, ref Int32 textures)
        ;
        

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
        [Slot(61)]
        public static extern 
        unsafe void DeleteTextures(Int32 n, Int32* textures)
        ;
        

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
        [Slot(61)]
        public static extern 
        void DeleteTextures(Int32 n, UInt32[] textures)
        ;
        

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
        [Slot(61)]
        public static extern 
        void DeleteTextures(Int32 n, ref UInt32 textures)
        ;
        

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
        [Slot(61)]
        public static extern 
        unsafe void DeleteTextures(Int32 n, UInt32* textures)
        ;
        

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
        [Slot(63)]
        public static extern 
        void DepthFunc(OpenTK.Graphics.ES11.All func)
        ;
        

        /// <summary>[requires: v1.0]
        /// Specify the value used for depth buffer comparisons
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthFunc")]
        [Slot(63)]
        public static extern 
        void DepthFunc(OpenTK.Graphics.ES11.DepthFunction func)
        ;
        

        /// <summary>[requires: v1.0]
        /// Enable or disable writing into the depth buffer
        /// </summary>
        /// <param name="flag">
        /// <para>
        /// Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthMask")]
        [Slot(64)]
        public static extern 
        void DepthMask(bool flag)
        ;
        

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
        [Slot(65)]
        public static extern 
        void DepthRange(Single n, Single f)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthRangex")]
        [Slot(67)]
        public static extern 
        void DepthRangex(int n, int f)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisable")]
        [Slot(69)]
        public static extern 
        void Disable(OpenTK.Graphics.ES11.All cap)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisable")]
        [Slot(69)]
        public static extern 
        void Disable(OpenTK.Graphics.ES11.EnableCap cap)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisableClientState")]
        [Slot(70)]
        public static extern 
        void DisableClientState(OpenTK.Graphics.ES11.All array)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisableClientState")]
        [Slot(70)]
        public static extern 
        void DisableClientState(OpenTK.Graphics.ES11.EnableCap array)
        ;
        

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
        [Slot(73)]
        public static extern 
        void DrawArrays(OpenTK.Graphics.ES11.All mode, Int32 first, Int32 count)
        ;
        

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
        [Slot(73)]
        public static extern 
        void DrawArrays(OpenTK.Graphics.ES11.BeginMode mode, Int32 first, Int32 count)
        ;
        

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
        [Slot(73)]
        public static extern 
        void DrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 first, Int32 count)
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
        [Slot(74)]
        public static extern 
        void DrawElements(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices)
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
        [Slot(74)]
        public static extern 
        void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices)
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
        [Slot(85)]
        public static extern 
        void Enable(OpenTK.Graphics.ES11.All cap)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glEnable")]
        [Slot(85)]
        public static extern 
        void Enable(OpenTK.Graphics.ES11.EnableCap cap)
        ;
        

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
        [Slot(86)]
        public static extern 
        void EnableClientState(OpenTK.Graphics.ES11.All array)
        ;
        

        /// <summary>[requires: v1.0]
        /// Enable or disable client-side capability
        /// </summary>
        /// <param name="cap">
        /// <para>
        /// Specifies the capability to enable. Symbolic constants GL_COLOR_ARRAY, GL_EDGE_FLAG_ARRAY, GL_FOG_COORD_ARRAY, GL_INDEX_ARRAY, GL_NORMAL_ARRAY, GL_SECONDARY_COLOR_ARRAY, GL_TEXTURE_COORD_ARRAY, and GL_VERTEX_ARRAY are accepted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glEnableClientState")]
        [Slot(86)]
        public static extern 
        void EnableClientState(OpenTK.Graphics.ES11.EnableCap array)
        ;
        

        /// <summary>[requires: v1.0]
        /// Block until all GL execution is complete
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFinish")]
        [Slot(107)]
        public static extern 
        void Finish()
        ;
        

        /// <summary>[requires: v1.0]
        /// Force execution of GL commands in finite time
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFlush")]
        [Slot(109)]
        public static extern 
        void Flush()
        ;
        

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
        [Slot(111)]
        public static extern 
        void Fog(OpenTK.Graphics.ES11.All pname, Single param)
        ;
        

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
        [Slot(111)]
        public static extern 
        void Fog(OpenTK.Graphics.ES11.FogParameter pname, Single param)
        ;
        

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
        [Slot(112)]
        public static extern 
        void Fog(OpenTK.Graphics.ES11.All pname, Single[] @params)
        ;
        

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
        [Slot(112)]
        public static extern 
        unsafe void Fog(OpenTK.Graphics.ES11.All pname, Single* @params)
        ;
        

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
        [Slot(112)]
        public static extern 
        void Fog(OpenTK.Graphics.ES11.FogParameter pname, Single[] @params)
        ;
        

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
        [Slot(112)]
        public static extern 
        unsafe void Fog(OpenTK.Graphics.ES11.FogParameter pname, Single* @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogx")]
        [Slot(113)]
        public static extern 
        void Fogx(OpenTK.Graphics.ES11.All pname, int param)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogxv")]
        [Slot(115)]
        public static extern 
        void Fogx(OpenTK.Graphics.ES11.All pname, int[] param)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogxv")]
        [Slot(115)]
        public static extern 
        unsafe void Fogx(OpenTK.Graphics.ES11.All pname, int* param)
        ;
        

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
        [Slot(121)]
        public static extern 
        void FrontFace(OpenTK.Graphics.ES11.All mode)
        ;
        

        /// <summary>[requires: v1.0]
        /// Define front- and back-facing polygons
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFrontFace")]
        [Slot(121)]
        public static extern 
        void FrontFace(OpenTK.Graphics.ES11.FrontFaceDirection mode)
        ;
        

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
        [Slot(122)]
        public static extern 
        void Frustum(Single l, Single r, Single b, Single t, Single n, Single f)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFrustumx")]
        [Slot(124)]
        public static extern 
        void Frustumx(int l, int r, int b, int t, int n, int f)
        ;
        

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
        [Slot(126)]
        public static extern 
        Int32 GenBuffer()
        ;
        

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
        [Slot(126)]
        public static extern 
        void GenBuffers(Int32 n, [OutAttribute] Int32[] buffers)
        ;
        

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
        [Slot(126)]
        public static extern 
        void GenBuffers(Int32 n, [OutAttribute] out Int32 buffers)
        ;
        

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
        [Slot(126)]
        public static extern 
        unsafe void GenBuffers(Int32 n, [OutAttribute] Int32* buffers)
        ;
        

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
        [Slot(126)]
        public static extern 
        void GenBuffers(Int32 n, [OutAttribute] UInt32[] buffers)
        ;
        

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
        [Slot(126)]
        public static extern 
        void GenBuffers(Int32 n, [OutAttribute] out UInt32 buffers)
        ;
        

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
        [Slot(126)]
        public static extern 
        unsafe void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers)
        ;
        

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
        [Slot(131)]
        public static extern 
        Int32 GenTexture()
        ;
        

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
        [Slot(131)]
        public static extern 
        void GenTextures(Int32 n, [OutAttribute] Int32[] textures)
        ;
        

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
        [Slot(131)]
        public static extern 
        void GenTextures(Int32 n, [OutAttribute] out Int32 textures)
        ;
        

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
        [Slot(131)]
        public static extern 
        unsafe void GenTextures(Int32 n, [OutAttribute] Int32* textures)
        ;
        

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
        [Slot(131)]
        public static extern 
        void GenTextures(Int32 n, [OutAttribute] UInt32[] textures)
        ;
        

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
        [Slot(131)]
        public static extern 
        void GenTextures(Int32 n, [OutAttribute] out UInt32 textures)
        ;
        

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
        [Slot(131)]
        public static extern 
        unsafe void GenTextures(Int32 n, [OutAttribute] UInt32* textures)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [Slot(133)]
        public static extern 
        bool GetBoolean(OpenTK.Graphics.ES11.All pname)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [Slot(133)]
        public static extern 
        bool GetBoolean(OpenTK.Graphics.ES11.GetPName pname)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [Slot(133)]
        public static extern 
        void GetBoolean(OpenTK.Graphics.ES11.All pname, [OutAttribute] bool[] data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [Slot(133)]
        public static extern 
        void GetBoolean(OpenTK.Graphics.ES11.All pname, [OutAttribute] out bool data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [Slot(133)]
        public static extern 
        unsafe void GetBoolean(OpenTK.Graphics.ES11.All pname, [OutAttribute] bool* data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [Slot(133)]
        public static extern 
        void GetBoolean(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool[] data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [Slot(133)]
        public static extern 
        void GetBoolean(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] out bool data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [Slot(133)]
        public static extern 
        unsafe void GetBoolean(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool* data)
        ;
        

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
        [Slot(134)]
        public static extern 
        void GetBufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
        ;
        

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
        [Slot(134)]
        public static extern 
        void GetBufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
        ;
        

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
        [Slot(134)]
        public static extern 
        unsafe void GetBufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
        ;
        

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
        [Slot(136)]
        public static extern 
        Single GetClipPlane(OpenTK.Graphics.ES11.All plane)
        ;
        

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
        [Slot(136)]
        public static extern 
        void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single[] equation)
        ;
        

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
        [Slot(136)]
        public static extern 
        void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] out Single equation)
        ;
        

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
        [Slot(136)]
        public static extern 
        unsafe void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        [Slot(138)]
        public static extern 
        int GetClipPlanex(OpenTK.Graphics.ES11.All plane)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        [Slot(138)]
        public static extern 
        void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int[] equation)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        [Slot(138)]
        public static extern 
        void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] out int equation)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        [Slot(138)]
        public static extern 
        unsafe void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation)
        ;
        

        /// <summary>[requires: v1.0]
        /// Return error information
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetError")]
        [Slot(143)]
        public static extern 
        OpenTK.Graphics.ES11.ErrorCode GetError()
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        [Slot(145)]
        public static extern 
        int GetFixed(OpenTK.Graphics.ES11.All pname)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        [Slot(145)]
        public static extern 
        void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        [Slot(145)]
        public static extern 
        void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        [Slot(145)]
        public static extern 
        unsafe void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [Slot(147)]
        public static extern 
        Single GetFloat(OpenTK.Graphics.ES11.All pname)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [Slot(147)]
        public static extern 
        Single GetFloat(OpenTK.Graphics.ES11.GetPName pname)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [Slot(147)]
        public static extern 
        void GetFloat(OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [Slot(147)]
        public static extern 
        void GetFloat(OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [Slot(147)]
        public static extern 
        unsafe void GetFloat(OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [Slot(147)]
        public static extern 
        void GetFloat(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single[] data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [Slot(147)]
        public static extern 
        void GetFloat(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] out Single data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [Slot(147)]
        public static extern 
        unsafe void GetFloat(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single* data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [Slot(152)]
        public static extern 
        Int32 GetInteger(OpenTK.Graphics.ES11.All pname)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [Slot(152)]
        public static extern 
        Int32 GetInteger(OpenTK.Graphics.ES11.GetPName pname)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [Slot(152)]
        public static extern 
        void GetInteger(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [Slot(152)]
        public static extern 
        void GetInteger(OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [Obsolete("Use strongly-typed overload instead")]
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [Slot(152)]
        public static extern 
        unsafe void GetInteger(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [Slot(152)]
        public static extern 
        void GetInteger(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32[] data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [Slot(152)]
        public static extern 
        void GetInteger(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] out Int32 data)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [Slot(152)]
        public static extern 
        unsafe void GetInteger(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32* data)
        ;
        

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
        [Slot(153)]
        public static extern 
        void GetLight(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params)
        ;
        

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
        [Slot(153)]
        public static extern 
        void GetLight(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params)
        ;
        

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
        [Slot(153)]
        public static extern 
        unsafe void GetLight(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params)
        ;
        

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
        [Slot(153)]
        public static extern 
        void GetLight(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single[] @params)
        ;
        

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
        [Slot(153)]
        public static extern 
        void GetLight(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] out Single @params)
        ;
        

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
        [Slot(153)]
        public static extern 
        unsafe void GetLight(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single* @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightxv")]
        [Slot(155)]
        public static extern 
        void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightxv")]
        [Slot(155)]
        public static extern 
        void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightxv")]
        [Slot(155)]
        public static extern 
        unsafe void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
        ;
        

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
        [Slot(158)]
        public static extern 
        void GetMaterial(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params)
        ;
        

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
        [Slot(158)]
        public static extern 
        void GetMaterial(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params)
        ;
        

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
        [Slot(158)]
        public static extern 
        unsafe void GetMaterial(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params)
        ;
        

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
        [Slot(158)]
        public static extern 
        void GetMaterial(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single[] @params)
        ;
        

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
        [Slot(158)]
        public static extern 
        void GetMaterial(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] out Single @params)
        ;
        

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
        [Slot(158)]
        public static extern 
        unsafe void GetMaterial(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single* @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialxv")]
        [Slot(160)]
        public static extern 
        void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialxv")]
        [Slot(160)]
        public static extern 
        void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialxv")]
        [Slot(160)]
        public static extern 
        unsafe void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
        ;
        

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetPixelMapxv")]
        [Slot(164)]
        public static extern 
        void GetPixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] int[] values)
        ;
        

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetPixelMapxv")]
        [Slot(164)]
        public static extern 
        void GetPixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] out int values)
        ;
        

        /// <summary></summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetPixelMapxv")]
        [Slot(164)]
        public static extern 
        unsafe void GetPixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] int* values)
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
        [Slot(165)]
        public static extern 
        void GetPointer(OpenTK.Graphics.ES11.All pname, [OutAttribute] IntPtr @params)
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
        [Slot(165)]
        public static extern 
        void GetPointer<T1>(OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T1[] @params)
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
        [Slot(165)]
        public static extern 
        void GetPointer<T1>(OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T1[,] @params)
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
        [Slot(165)]
        public static extern 
        void GetPointer<T1>(OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T1[,,] @params)
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
        [Slot(165)]
        public static extern 
        void GetPointer<T1>(OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] ref T1 @params)
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
        [Slot(165)]
        public static extern 
        void GetPointer(OpenTK.Graphics.ES11.GetPointervPName pname, [OutAttribute] IntPtr @params)
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
        [Slot(165)]
        public static extern 
        void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] T1[] @params)
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
        [Slot(165)]
        public static extern 
        void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] T1[,] @params)
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
        [Slot(165)]
        public static extern 
        void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] T1[,,] @params)
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
        [Slot(165)]
        public static extern 
        void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] ref T1 @params)
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
        [Slot(167)]
        public static extern 
        String GetString(OpenTK.Graphics.ES11.All name)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetString")]
        [Slot(167)]
        public static extern 
        String GetString(OpenTK.Graphics.ES11.StringName name)
        ;
        

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
        [Slot(169)]
        public static extern 
        void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params)
        ;
        

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
        [Slot(169)]
        public static extern 
        void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params)
        ;
        

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
        [Slot(169)]
        public static extern 
        unsafe void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params)
        ;
        

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
        [Slot(169)]
        public static extern 
        void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single[] @params)
        ;
        

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
        [Slot(169)]
        public static extern 
        void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] out Single @params)
        ;
        

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
        [Slot(169)]
        public static extern 
        unsafe void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single* @params)
        ;
        

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
        [Slot(170)]
        public static extern 
        void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
        ;
        

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
        [Slot(170)]
        public static extern 
        void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
        ;
        

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
        [Slot(170)]
        public static extern 
        unsafe void GetTexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
        ;
        

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
        [Slot(170)]
        public static extern 
        void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32[] @params)
        ;
        

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
        [Slot(170)]
        public static extern 
        void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] out Int32 @params)
        ;
        

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
        [Slot(170)]
        public static extern 
        unsafe void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32* @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvxv")]
        [Slot(171)]
        public static extern 
        void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvxv")]
        [Slot(171)]
        public static extern 
        void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvxv")]
        [Slot(171)]
        public static extern 
        unsafe void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
        ;
        

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
        [Slot(177)]
        public static extern 
        void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params)
        ;
        

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
        [Slot(177)]
        public static extern 
        void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params)
        ;
        

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
        [Slot(177)]
        public static extern 
        unsafe void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params)
        ;
        

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
        [Slot(177)]
        public static extern 
        void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single[] @params)
        ;
        

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
        [Slot(177)]
        public static extern 
        void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] out Single @params)
        ;
        

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
        [Slot(177)]
        public static extern 
        unsafe void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single* @params)
        ;
        

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
        [Slot(178)]
        public static extern 
        void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
        ;
        

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
        [Slot(178)]
        public static extern 
        void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
        ;
        

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
        [Slot(178)]
        public static extern 
        unsafe void GetTexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
        ;
        

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
        [Slot(178)]
        public static extern 
        void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32[] @params)
        ;
        

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
        [Slot(178)]
        public static extern 
        void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] out Int32 @params)
        ;
        

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
        [Slot(178)]
        public static extern 
        unsafe void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32* @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterxv")]
        [Slot(179)]
        public static extern 
        void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterxv")]
        [Slot(179)]
        public static extern 
        void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterxv")]
        [Slot(179)]
        public static extern 
        unsafe void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
        ;
        

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
        [Slot(181)]
        public static extern 
        void Hint(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All mode)
        ;
        

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
        [Slot(181)]
        public static extern 
        void Hint(OpenTK.Graphics.ES11.HintTarget target, OpenTK.Graphics.ES11.HintMode mode)
        ;
        

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a buffer object
        /// </summary>
        /// <param name="buffer">
        /// <para>
        /// Specifies a value that may be the name of a buffer object.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsBuffer")]
        [Slot(184)]
        public static extern 
        bool IsBuffer(Int32 buffer)
        ;
        

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
        [Slot(184)]
        public static extern 
        bool IsBuffer(UInt32 buffer)
        ;
        

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
        [Slot(185)]
        public static extern 
        bool IsEnabled(OpenTK.Graphics.ES11.All cap)
        ;
        

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
        [Slot(185)]
        public static extern 
        bool IsEnabled(OpenTK.Graphics.ES11.EnableCap cap)
        ;
        

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a texture
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies a value that may be the name of a texture.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsTexture")]
        [Slot(190)]
        public static extern 
        bool IsTexture(Int32 texture)
        ;
        

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
        [Slot(190)]
        public static extern 
        bool IsTexture(UInt32 texture)
        ;
        

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
        [Slot(192)]
        public static extern 
        void Light(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, Single param)
        ;
        

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
        [Slot(192)]
        public static extern 
        void Light(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single param)
        ;
        

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
        [Slot(193)]
        public static extern 
        void Light(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, Single[] @params)
        ;
        

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
        [Slot(193)]
        public static extern 
        unsafe void Light(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, Single* @params)
        ;
        

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
        [Slot(193)]
        public static extern 
        void Light(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single[] @params)
        ;
        

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
        [Slot(193)]
        public static extern 
        unsafe void Light(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single* @params)
        ;
        

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
        [Slot(194)]
        public static extern 
        void LightModel(OpenTK.Graphics.ES11.All pname, Single param)
        ;
        

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
        [Slot(194)]
        public static extern 
        void LightModel(OpenTK.Graphics.ES11.LightModelParameter pname, Single param)
        ;
        

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
        [Slot(195)]
        public static extern 
        void LightModel(OpenTK.Graphics.ES11.All pname, Single[] @params)
        ;
        

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
        [Slot(195)]
        public static extern 
        unsafe void LightModel(OpenTK.Graphics.ES11.All pname, Single* @params)
        ;
        

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
        [Slot(195)]
        public static extern 
        void LightModel(OpenTK.Graphics.ES11.LightModelParameter pname, Single[] @params)
        ;
        

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
        [Slot(195)]
        public static extern 
        unsafe void LightModel(OpenTK.Graphics.ES11.LightModelParameter pname, Single* @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelx")]
        [Slot(196)]
        public static extern 
        void LightModelx(OpenTK.Graphics.ES11.All pname, int param)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelxv")]
        [Slot(198)]
        public static extern 
        void LightModelx(OpenTK.Graphics.ES11.All pname, int[] param)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelxv")]
        [Slot(198)]
        public static extern 
        unsafe void LightModelx(OpenTK.Graphics.ES11.All pname, int* param)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightx")]
        [Slot(200)]
        public static extern 
        void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightxv")]
        [Slot(202)]
        public static extern 
        void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int[] @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightxv")]
        [Slot(202)]
        public static extern 
        unsafe void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params)
        ;
        

        /// <summary>[requires: v1.0]
        /// Specify the width of rasterized lines
        /// </summary>
        /// <param name="width">
        /// <para>
        /// Specifies the width of rasterized lines. The initial value is 1.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLineWidth")]
        [Slot(204)]
        public static extern 
        void LineWidth(Single width)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLineWidthx")]
        [Slot(205)]
        public static extern 
        void LineWidthx(int width)
        ;
        

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the identity matrix
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadIdentity")]
        [Slot(207)]
        public static extern 
        void LoadIdentity()
        ;
        

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixf")]
        [Slot(208)]
        public static extern 
        void LoadMatrix(Single[] m)
        ;
        

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixf")]
        [Slot(208)]
        public static extern 
        void LoadMatrix(ref Single m)
        ;
        

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
        [Slot(208)]
        public static extern 
        unsafe void LoadMatrix(Single* m)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixx")]
        [Slot(209)]
        public static extern 
        void LoadMatrixx(int[] m)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixx")]
        [Slot(209)]
        public static extern 
        void LoadMatrixx(ref int m)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixx")]
        [Slot(209)]
        public static extern 
        unsafe void LoadMatrixx(int* m)
        ;
        

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
        [Slot(213)]
        public static extern 
        void LogicOp(OpenTK.Graphics.ES11.All opcode)
        ;
        

        /// <summary>[requires: v1.0]
        /// Specify a logical pixel operation for rendering
        /// </summary>
        /// <param name="opcode">
        /// <para>
        /// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: GL_CLEAR, GL_SET, GL_COPY, GL_COPY_INVERTED, GL_NOOP, GL_INVERT, GL_AND, GL_NAND, GL_OR, GL_NOR, GL_XOR, GL_EQUIV, GL_AND_REVERSE, GL_AND_INVERTED, GL_OR_REVERSE, and GL_OR_INVERTED. The initial value is GL_COPY.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLogicOp")]
        [Slot(213)]
        public static extern 
        void LogicOp(OpenTK.Graphics.ES11.LogicOp opcode)
        ;
        

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
        [Slot(220)]
        public static extern 
        void Material(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, Single param)
        ;
        

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
        [Slot(220)]
        public static extern 
        void Material(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single param)
        ;
        

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
        [Slot(221)]
        public static extern 
        void Material(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, Single[] @params)
        ;
        

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
        [Slot(221)]
        public static extern 
        unsafe void Material(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, Single* @params)
        ;
        

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
        [Slot(221)]
        public static extern 
        void Material(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single[] @params)
        ;
        

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
        [Slot(221)]
        public static extern 
        unsafe void Material(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single* @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialx")]
        [Slot(222)]
        public static extern 
        void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialxv")]
        [Slot(224)]
        public static extern 
        void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int[] param)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialxv")]
        [Slot(224)]
        public static extern 
        unsafe void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param)
        ;
        

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
        [Slot(227)]
        public static extern 
        void MatrixMode(OpenTK.Graphics.ES11.All mode)
        ;
        

        /// <summary>[requires: v1.0]
        /// Specify which matrix is the current matrix
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies which matrix stack is the target for subsequent matrix operations. Three values are accepted: GL_MODELVIEW, GL_PROJECTION, and GL_TEXTURE. The initial value is GL_MODELVIEW. Additionally, if the ARB_imaging extension is supported, GL_COLOR is also accepted.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMatrixMode")]
        [Slot(227)]
        public static extern 
        void MatrixMode(OpenTK.Graphics.ES11.MatrixMode mode)
        ;
        

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
        [Slot(244)]
        public static extern 
        void MultiTexCoord4(OpenTK.Graphics.ES11.All target, Single s, Single t, Single r, Single q)
        ;
        

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
        [Slot(244)]
        public static extern 
        void MultiTexCoord4(OpenTK.Graphics.ES11.TextureUnit target, Single s, Single t, Single r, Single q)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultiTexCoord4x")]
        [Slot(245)]
        public static extern 
        void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q)
        ;
        

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Points to 16 consecutive values that are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixf")]
        [Slot(248)]
        public static extern 
        void MultMatrix(Single[] m)
        ;
        

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Points to 16 consecutive values that are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixf")]
        [Slot(248)]
        public static extern 
        void MultMatrix(ref Single m)
        ;
        

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
        [Slot(248)]
        public static extern 
        unsafe void MultMatrix(Single* m)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixx")]
        [Slot(249)]
        public static extern 
        void MultMatrixx(int[] m)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixx")]
        [Slot(249)]
        public static extern 
        void MultMatrixx(ref int m)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixx")]
        [Slot(249)]
        public static extern 
        unsafe void MultMatrixx(int* m)
        ;
        

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
        [Slot(252)]
        public static extern 
        void Normal3(Single nx, Single ny, Single nz)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormal3x")]
        [Slot(253)]
        public static extern 
        void Normal3x(int nx, int ny, int nz)
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
        [Slot(256)]
        public static extern 
        void NormalPointer(OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer)
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
        [Slot(256)]
        public static extern 
        void NormalPointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[] pointer)
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
        [Slot(256)]
        public static extern 
        void NormalPointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,] pointer)
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
        [Slot(256)]
        public static extern 
        void NormalPointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,,] pointer)
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
        [Slot(256)]
        public static extern 
        void NormalPointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T2 pointer)
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
        [Slot(256)]
        public static extern 
        void NormalPointer(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, IntPtr pointer)
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
        [Slot(256)]
        public static extern 
        void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[] pointer)
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
        [Slot(256)]
        public static extern 
        void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[,] pointer)
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
        [Slot(256)]
        public static extern 
        void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[,,] pointer)
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
        [Slot(256)]
        public static extern 
        void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T2 pointer)
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
        [Slot(257)]
        public static extern 
        void Ortho(Single l, Single r, Single b, Single t, Single n, Single f)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glOrthox")]
        [Slot(259)]
        public static extern 
        void Orthox(int l, int r, int b, int t, int n, int f)
        ;
        

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelMapx")]
        [Slot(262)]
        public static extern 
        void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, int[] values)
        ;
        

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelMapx")]
        [Slot(262)]
        public static extern 
        void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, ref int values)
        ;
        

        /// <summary></summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelMapx")]
        [Slot(262)]
        public static extern 
        unsafe void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, int* values)
        ;
        

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
        [Slot(263)]
        public static extern 
        void PixelStore(OpenTK.Graphics.ES11.All pname, Int32 param)
        ;
        

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
        [Slot(263)]
        public static extern 
        void PixelStore(OpenTK.Graphics.ES11.PixelStoreParameter pname, Int32 param)
        ;
        

        /// <summary></summary>
        [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelStorex")]
        [Slot(264)]
        public static extern 
        void PixelStorex(OpenTK.Graphics.ES11.All pname, int param)
        ;
        

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
        [Slot(267)]
        public static extern 
        void PointParameter(OpenTK.Graphics.ES11.All pname, Single param)
        ;
        

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
        [Slot(268)]
        public static extern 
        void PointParameter(OpenTK.Graphics.ES11.All pname, Single[] @params)
        ;
        

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
        [Slot(268)]
        public static extern 
        unsafe void PointParameter(OpenTK.Graphics.ES11.All pname, Single* @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterx")]
        [Slot(269)]
        public static extern 
        void PointParameterx(OpenTK.Graphics.ES11.All pname, int param)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterxv")]
        [Slot(271)]
        public static extern 
        void PointParameterx(OpenTK.Graphics.ES11.All pname, int[] @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterxv")]
        [Slot(271)]
        public static extern 
        unsafe void PointParameterx(OpenTK.Graphics.ES11.All pname, int* @params)
        ;
        

        /// <summary>[requires: v1.0]
        /// Specify the diameter of rasterized points
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the diameter of rasterized points. The initial value is 1.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointSize")]
        [Slot(273)]
        public static extern 
        void PointSize(Single size)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointSizex")]
        [Slot(275)]
        public static extern 
        void PointSizex(int size)
        ;
        

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
        [Slot(277)]
        public static extern 
        void PolygonOffset(Single factor, Single units)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPolygonOffsetx")]
        [Slot(278)]
        public static extern 
        void PolygonOffsetx(int factor, int units)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPopMatrix")]
        [Slot(280)]
        public static extern 
        void PopMatrix()
        ;
        

        /// <summary>[requires: v1.0]
        /// Push and pop the current matrix stack
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPushMatrix")]
        [Slot(282)]
        public static extern 
        void PushMatrix()
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
        [Slot(291)]
        public static extern 
        void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [OutAttribute] IntPtr pixels)
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
        [Slot(291)]
        public static extern 
        void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T6[] pixels)
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
        [Slot(291)]
        public static extern 
        void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T6[,] pixels)
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
        [Slot(291)]
        public static extern 
        void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T6[,,] pixels)
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
        [Slot(291)]
        public static extern 
        void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T6 pixels)
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
        [Slot(291)]
        public static extern 
        void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [OutAttribute] IntPtr pixels)
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
        [Slot(291)]
        public static extern 
        void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T6[] pixels)
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
        [Slot(291)]
        public static extern 
        void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T6[,] pixels)
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
        [Slot(291)]
        public static extern 
        void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T6[,,] pixels)
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
        [Slot(291)]
        public static extern 
        void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] ref T6 pixels)
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
        [Slot(299)]
        public static extern 
        void Rotate(Single angle, Single x, Single y, Single z)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glRotatex")]
        [Slot(300)]
        public static extern 
        void Rotatex(int angle, int x, int y, int z)
        ;
        

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
        [Slot(302)]
        public static extern 
        void SampleCoverage(Single value, bool invert)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glSampleCoveragex")]
        [Slot(304)]
        public static extern 
        void SampleCoveragex(int value, bool invert)
        ;
        

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a general scaling matrix
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify scale factors along the x, y, and z axes, respectively.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glScalef")]
        [Slot(306)]
        public static extern 
        void Scale(Single x, Single y, Single z)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glScalex")]
        [Slot(307)]
        public static extern 
        void Scalex(int x, int y, int z)
        ;
        

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
        [Slot(309)]
        public static extern 
        void Scissor(Int32 x, Int32 y, Int32 width, Int32 height)
        ;
        

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
        [Slot(311)]
        public static extern 
        void ShadeModel(OpenTK.Graphics.ES11.All mode)
        ;
        

        /// <summary>[requires: v1.0]
        /// Select flat or smooth shading
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies a symbolic value representing a shading technique. Accepted values are GL_FLAT and GL_SMOOTH. The initial value is GL_SMOOTH.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glShadeModel")]
        [Slot(311)]
        public static extern 
        void ShadeModel(OpenTK.Graphics.ES11.ShadingModel mode)
        ;
        

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
        [Slot(313)]
        public static extern 
        void StencilFunc(OpenTK.Graphics.ES11.All func, Int32 @ref, Int32 mask)
        ;
        

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
        [Slot(313)]
        public static extern 
        void StencilFunc(OpenTK.Graphics.ES11.All func, Int32 @ref, UInt32 mask)
        ;
        

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
        [Slot(313)]
        public static extern 
        void StencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, Int32 mask)
        ;
        

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
        [Slot(313)]
        public static extern 
        void StencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, UInt32 mask)
        ;
        

        /// <summary>[requires: v1.0]
        /// Control the front and back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </para>
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilMask")]
        [Slot(314)]
        public static extern 
        void StencilMask(Int32 mask)
        ;
        

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
        [Slot(314)]
        public static extern 
        void StencilMask(UInt32 mask)
        ;
        

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
        [Slot(315)]
        public static extern 
        void StencilOp(OpenTK.Graphics.ES11.All fail, OpenTK.Graphics.ES11.All zfail, OpenTK.Graphics.ES11.All zpass)
        ;
        

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
        [Slot(315)]
        public static extern 
        void StencilOp(OpenTK.Graphics.ES11.StencilOp fail, OpenTK.Graphics.ES11.StencilOp zfail, OpenTK.Graphics.ES11.StencilOp zpass)
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
        [Slot(333)]
        public static extern 
        void TexCoordPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer)
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
        [Slot(333)]
        public static extern 
        void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
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
        [Slot(333)]
        public static extern 
        void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
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
        [Slot(333)]
        public static extern 
        void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
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
        [Slot(333)]
        public static extern 
        void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
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
        [Slot(333)]
        public static extern 
        void TexCoordPointer(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, IntPtr pointer)
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
        [Slot(333)]
        public static extern 
        void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
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
        [Slot(333)]
        public static extern 
        void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
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
        [Slot(333)]
        public static extern 
        void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
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
        [Slot(333)]
        public static extern 
        void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
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
        [Slot(334)]
        public static extern 
        void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single param)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvf")]
        [Slot(334)]
        public static extern 
        void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single param)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        [Slot(335)]
        public static extern 
        void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single[] @params)
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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        [Slot(335)]
        public static extern 
        unsafe void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single* @params)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        [Slot(335)]
        public static extern 
        void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single[] @params)
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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        [Slot(335)]
        public static extern 
        unsafe void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single* @params)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvi")]
        [Slot(336)]
        public static extern 
        void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvi")]
        [Slot(336)]
        public static extern 
        void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32 param)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        [Slot(337)]
        public static extern 
        void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32[] @params)
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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        [Slot(337)]
        public static extern 
        unsafe void TexEnv(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32* @params)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        [Slot(337)]
        public static extern 
        void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32[] @params)
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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        [Slot(337)]
        public static extern 
        unsafe void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32* @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvx")]
        [Slot(338)]
        public static extern 
        void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvxv")]
        [Slot(340)]
        public static extern 
        void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvxv")]
        [Slot(340)]
        public static extern 
        unsafe void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
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
        [Slot(348)]
        public static extern 
        void TexImage2D(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, IntPtr pixels)
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
        [Slot(348)]
        public static extern 
        void TexImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[] pixels)
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
        [Slot(348)]
        public static extern 
        void TexImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[,] pixels)
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
        [Slot(348)]
        public static extern 
        void TexImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[,,] pixels)
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
        [Slot(348)]
        public static extern 
        void TexImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T8 pixels)
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
        [Slot(348)]
        public static extern 
        void TexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels)
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
        [Slot(348)]
        public static extern 
        void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[] pixels)
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
        [Slot(348)]
        public static extern 
        void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,] pixels)
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
        [Slot(348)]
        public static extern 
        void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,,] pixels)
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
        [Slot(348)]
        public static extern 
        void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] ref T8 pixels)
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
        [Slot(349)]
        public static extern 
        void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single param)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterf")]
        [Slot(349)]
        public static extern 
        void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single param)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        [Slot(350)]
        public static extern 
        void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single[] @params)
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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        [Slot(350)]
        public static extern 
        unsafe void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Single* @params)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        [Slot(350)]
        public static extern 
        void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single[] @params)
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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        [Slot(350)]
        public static extern 
        unsafe void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single* @params)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteri")]
        [Slot(351)]
        public static extern 
        void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteri")]
        [Slot(351)]
        public static extern 
        void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32 param)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        [Slot(352)]
        public static extern 
        void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32[] @params)
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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        [Slot(352)]
        public static extern 
        unsafe void TexParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32* @params)
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
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        [Slot(352)]
        public static extern 
        void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32[] @params)
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
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        [Slot(352)]
        public static extern 
        unsafe void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32* @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterx")]
        [Slot(353)]
        public static extern 
        void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterxv")]
        [Slot(355)]
        public static extern 
        void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterxv")]
        [Slot(355)]
        public static extern 
        unsafe void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
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
        [Slot(360)]
        public static extern 
        void TexSubImage2D(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, IntPtr pixels)
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
        [Slot(360)]
        public static extern 
        void TexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[] pixels)
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
        [Slot(360)]
        public static extern 
        void TexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[,] pixels)
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
        [Slot(360)]
        public static extern 
        void TexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T8[,,] pixels)
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
        [Slot(360)]
        public static extern 
        void TexSubImage2D<T8>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T8 pixels)
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
        [Slot(360)]
        public static extern 
        void TexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels)
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
        [Slot(360)]
        public static extern 
        void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[] pixels)
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
        [Slot(360)]
        public static extern 
        void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,] pixels)
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
        [Slot(360)]
        public static extern 
        void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,,] pixels)
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
        [Slot(360)]
        public static extern 
        void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] ref T8 pixels)
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
        [Slot(364)]
        public static extern 
        void Translate(Single x, Single y, Single z)
        ;
        

        /// <summary>[requires: v1.0]</summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTranslatex")]
        [Slot(365)]
        public static extern 
        void Translatex(int x, int y, int z)
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
        [Slot(380)]
        public static extern 
        void VertexPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer)
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
        [Slot(380)]
        public static extern 
        void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
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
        [Slot(380)]
        public static extern 
        void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
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
        [Slot(380)]
        public static extern 
        void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
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
        [Slot(380)]
        public static extern 
        void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
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
        [Slot(380)]
        public static extern 
        void VertexPointer(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, IntPtr pointer)
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
        [Slot(380)]
        public static extern 
        void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
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
        [Slot(380)]
        public static extern 
        void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
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
        [Slot(380)]
        public static extern 
        void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
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
        [Slot(380)]
        public static extern 
        void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
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
        [Slot(381)]
        public static extern 
        void Viewport(Int32 x, Int32 y, Int32 width, Int32 height)
        ;
        

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
            [Slot(12)]
            public static extern 
            void BlendEquation(OpenTK.Graphics.ES11.All mode)
            ;
            

            /// <summary>[requires: EXT_discard_framebuffer]</summary>
            [AutoGenerated(Category = "EXT_discard_framebuffer", Version = "", EntryPoint = "glDiscardFramebufferEXT")]
            [Slot(72)]
            public static extern 
            void DiscardFramebuffer(OpenTK.Graphics.ES11.All target, Int32 numAttachments, OpenTK.Graphics.ES11.All[] attachments)
            ;
            

            /// <summary>[requires: EXT_discard_framebuffer]</summary>
            [AutoGenerated(Category = "EXT_discard_framebuffer", Version = "", EntryPoint = "glDiscardFramebufferEXT")]
            [Slot(72)]
            public static extern 
            void DiscardFramebuffer(OpenTK.Graphics.ES11.All target, Int32 numAttachments, ref OpenTK.Graphics.ES11.All attachments)
            ;
            

            /// <summary>[requires: EXT_discard_framebuffer]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_discard_framebuffer", Version = "", EntryPoint = "glDiscardFramebufferEXT")]
            [Slot(72)]
            public static extern 
            unsafe void DiscardFramebuffer(OpenTK.Graphics.ES11.All target, Int32 numAttachments, OpenTK.Graphics.ES11.All* attachments)
            ;
            

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
            [Slot(110)]
            public static extern 
            void FlushMappedBufferRange(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length)
            ;
            

            /// <summary>[requires: EXT_multisampled_render_to_texture]</summary>
            [AutoGenerated(Category = "EXT_multisampled_render_to_texture", Version = "", EntryPoint = "glFramebufferTexture2DMultisampleEXT")]
            [Slot(118)]
            public static extern 
            void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, Int32 texture, Int32 level, Int32 samples)
            ;
            

            /// <summary>[requires: EXT_multisampled_render_to_texture]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_multisampled_render_to_texture", Version = "", EntryPoint = "glFramebufferTexture2DMultisampleEXT")]
            [Slot(118)]
            public static extern 
            void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples)
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetGraphicsResetStatusEXT")]
            [Slot(149)]
            public static extern 
            OpenTK.Graphics.ES11.All GetGraphicsResetStatus()
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            [Slot(162)]
            public static extern 
            void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Single[] @params)
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            [Slot(162)]
            public static extern 
            void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] out Single @params)
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            [Slot(162)]
            public static extern 
            unsafe void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params)
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            [Slot(162)]
            public static extern 
            void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single[] @params)
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            [Slot(162)]
            public static extern 
            void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] out Single @params)
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformfvEXT")]
            [Slot(162)]
            public static extern 
            unsafe void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params)
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            [Slot(163)]
            public static extern 
            void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32[] @params)
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            [Slot(163)]
            public static extern 
            void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] out Int32 @params)
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            [Slot(163)]
            public static extern 
            unsafe void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params)
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            [Slot(163)]
            public static extern 
            void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32[] @params)
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            [Slot(163)]
            public static extern 
            void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] out Int32 @params)
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glGetnUniformivEXT")]
            [Slot(163)]
            public static extern 
            unsafe void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params)
            ;
            

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
            [Slot(217)]
            public static extern 
            IntPtr MapBufferRange(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length, Int32 access)
            ;
            

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
            [Slot(217)]
            public static extern 
            IntPtr MapBufferRange(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length, UInt32 access)
            ;
            

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
            [Slot(228)]
            public static extern 
            void MultiDrawArrays(OpenTK.Graphics.ES11.All mode, Int32[] first, Int32[] count, Int32 primcount)
            ;
            

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
            [Slot(228)]
            public static extern 
            void MultiDrawArrays(OpenTK.Graphics.ES11.All mode, ref Int32 first, ref Int32 count, Int32 primcount)
            ;
            

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
            [Slot(228)]
            public static extern 
            unsafe void MultiDrawArrays(OpenTK.Graphics.ES11.All mode, Int32* first, Int32* count, Int32 primcount)
            ;
            

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
            [Slot(228)]
            public static extern 
            void MultiDrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] first, Int32[] count, Int32 primcount)
            ;
            

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
            [Slot(228)]
            public static extern 
            void MultiDrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 first, ref Int32 count, Int32 primcount)
            ;
            

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
            [Slot(228)]
            public static extern 
            unsafe void MultiDrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            unsafe void MultiDrawElements(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.All mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            unsafe void MultiDrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
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
            [Slot(229)]
            public static extern 
            unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            [Slot(290)]
            public static extern 
            void ReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [OutAttribute] IntPtr data)
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            [Slot(290)]
            public static extern 
            void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] T7[] data)
                where T7 : struct
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            [Slot(290)]
            public static extern 
            void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] T7[,] data)
                where T7 : struct
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            [Slot(290)]
            public static extern 
            void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] T7[,,] data)
                where T7 : struct
            ;
            

            /// <summary>[requires: EXT_robustness]</summary>
            [AutoGenerated(Category = "EXT_robustness", Version = "", EntryPoint = "glReadnPixelsEXT")]
            [Slot(290)]
            public static extern 
            void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] ref T7 data)
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
            [Slot(295)]
            public static extern 
            void RenderbufferStorageMultisample(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            ;
            

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
            [Slot(357)]
            public static extern 
            void TexStorage1D(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width)
            ;
            

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
            [Slot(358)]
            public static extern 
            void TexStorage2D(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            ;
            

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
            [Slot(359)]
            public static extern 
            void TexStorage3D(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth)
            ;
            

            /// <summary>[requires: EXT_texture_storage]</summary>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage1DEXT")]
            [Slot(361)]
            public static extern 
            void TextureStorage1D(Int32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width)
            ;
            

            /// <summary>[requires: EXT_texture_storage]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage1DEXT")]
            [Slot(361)]
            public static extern 
            void TextureStorage1D(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width)
            ;
            

            /// <summary>[requires: EXT_texture_storage]</summary>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage2DEXT")]
            [Slot(362)]
            public static extern 
            void TextureStorage2D(Int32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            ;
            

            /// <summary>[requires: EXT_texture_storage]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage2DEXT")]
            [Slot(362)]
            public static extern 
            void TextureStorage2D(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            ;
            

            /// <summary>[requires: EXT_texture_storage]</summary>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage3DEXT")]
            [Slot(363)]
            public static extern 
            void TextureStorage3D(Int32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth)
            ;
            

            /// <summary>[requires: EXT_texture_storage]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage3DEXT")]
            [Slot(363)]
            public static extern 
            void TextureStorage3D(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth)
            ;
            

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
            [Slot(33)]
            public static extern 
            void ClipPlane(OpenTK.Graphics.ES11.All p, Single[] eqn)
            ;
            

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
            [Slot(33)]
            public static extern 
            void ClipPlane(OpenTK.Graphics.ES11.All p, ref Single eqn)
            ;
            

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
            [Slot(33)]
            public static extern 
            unsafe void ClipPlane(OpenTK.Graphics.ES11.All p, Single* eqn)
            ;
            

            /// <summary>[requires: IMG_user_clip_plane]</summary>
            [AutoGenerated(Category = "IMG_user_clip_plane", Version = "", EntryPoint = "glClipPlanexIMG")]
            [Slot(36)]
            public static extern 
            void ClipPlanex(OpenTK.Graphics.ES11.All p, int[] eqn)
            ;
            

            /// <summary>[requires: IMG_user_clip_plane]</summary>
            [AutoGenerated(Category = "IMG_user_clip_plane", Version = "", EntryPoint = "glClipPlanexIMG")]
            [Slot(36)]
            public static extern 
            void ClipPlanex(OpenTK.Graphics.ES11.All p, ref int eqn)
            ;
            

            /// <summary>[requires: IMG_user_clip_plane]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "IMG_user_clip_plane", Version = "", EntryPoint = "glClipPlanexIMG")]
            [Slot(36)]
            public static extern 
            unsafe void ClipPlanex(OpenTK.Graphics.ES11.All p, int* eqn)
            ;
            

            /// <summary>[requires: IMG_multisampled_render_to_texture]</summary>
            [AutoGenerated(Category = "IMG_multisampled_render_to_texture", Version = "", EntryPoint = "glFramebufferTexture2DMultisampleIMG")]
            [Slot(119)]
            public static extern 
            void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, Int32 texture, Int32 level, Int32 samples)
            ;
            

            /// <summary>[requires: IMG_multisampled_render_to_texture]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "IMG_multisampled_render_to_texture", Version = "", EntryPoint = "glFramebufferTexture2DMultisampleIMG")]
            [Slot(119)]
            public static extern 
            void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples)
            ;
            

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
            [Slot(296)]
            public static extern 
            void RenderbufferStorageMultisample(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            ;
            

        }

        public static partial class NV
        {
            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [Slot(57)]
            public static extern 
            void DeleteFence(Int32 fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [Slot(57)]
            public static extern 
            void DeleteFence(UInt32 fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [Slot(57)]
            public static extern 
            void DeleteFences(Int32 n, Int32[] fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [Slot(57)]
            public static extern 
            void DeleteFences(Int32 n, ref Int32 fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [Slot(57)]
            public static extern 
            unsafe void DeleteFences(Int32 n, Int32* fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [Slot(57)]
            public static extern 
            void DeleteFences(Int32 n, UInt32[] fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [Slot(57)]
            public static extern 
            void DeleteFences(Int32 n, ref UInt32 fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glDeleteFencesNV")]
            [Slot(57)]
            public static extern 
            unsafe void DeleteFences(Int32 n, UInt32* fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glFinishFenceNV")]
            [Slot(108)]
            public static extern 
            void FinishFence(Int32 fence)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glFinishFenceNV")]
            [Slot(108)]
            public static extern 
            void FinishFence(UInt32 fence)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [Slot(128)]
            public static extern 
            Int32 GenFence()
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [Slot(128)]
            public static extern 
            void GenFences(Int32 n, [OutAttribute] Int32[] fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [Slot(128)]
            public static extern 
            void GenFences(Int32 n, [OutAttribute] out Int32 fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [Slot(128)]
            public static extern 
            unsafe void GenFences(Int32 n, [OutAttribute] Int32* fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [Slot(128)]
            public static extern 
            void GenFences(Int32 n, [OutAttribute] UInt32[] fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [Slot(128)]
            public static extern 
            void GenFences(Int32 n, [OutAttribute] out UInt32 fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGenFencesNV")]
            [Slot(128)]
            public static extern 
            unsafe void GenFences(Int32 n, [OutAttribute] UInt32* fences)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            [Slot(144)]
            public static extern 
            void GetFence(Int32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            [Slot(144)]
            public static extern 
            void GetFence(Int32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            [Slot(144)]
            public static extern 
            unsafe void GetFence(Int32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            [Slot(144)]
            public static extern 
            void GetFence(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            [Slot(144)]
            public static extern 
            void GetFence(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glGetFenceivNV")]
            [Slot(144)]
            public static extern 
            unsafe void GetFence(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glIsFenceNV")]
            [Slot(186)]
            public static extern 
            bool IsFence(Int32 fence)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glIsFenceNV")]
            [Slot(186)]
            public static extern 
            bool IsFence(UInt32 fence)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glSetFenceNV")]
            [Slot(310)]
            public static extern 
            void SetFence(Int32 fence, OpenTK.Graphics.ES11.All condition)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glSetFenceNV")]
            [Slot(310)]
            public static extern 
            void SetFence(UInt32 fence, OpenTK.Graphics.ES11.All condition)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glTestFenceNV")]
            [Slot(316)]
            public static extern 
            bool TestFence(Int32 fence)
            ;
            

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "NV_fence", Version = "", EntryPoint = "glTestFenceNV")]
            [Slot(316)]
            public static extern 
            bool TestFence(UInt32 fence)
            ;
            

        }

        public static partial class Oes
        {
            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glAccumxOES")]
            [Slot(0)]
            public static extern 
            void Accumx(OpenTK.Graphics.ES11.All op, int value)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glAlphaFuncxOES")]
            [Slot(4)]
            public static extern 
            void AlphaFuncx(OpenTK.Graphics.ES11.All func, int @ref)
            ;
            

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
            [Slot(6)]
            public static extern 
            void BindFramebuffer(OpenTK.Graphics.ES11.All target, Int32 framebuffer)
            ;
            

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
            [Slot(6)]
            public static extern 
            void BindFramebuffer(OpenTK.Graphics.ES11.All target, UInt32 framebuffer)
            ;
            

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
            [Slot(7)]
            public static extern 
            void BindRenderbuffer(OpenTK.Graphics.ES11.All target, Int32 renderbuffer)
            ;
            

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
            [Slot(7)]
            public static extern 
            void BindRenderbuffer(OpenTK.Graphics.ES11.All target, UInt32 renderbuffer)
            ;
            

            /// <summary>[requires: OES_vertex_array_object]
            /// Bind a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies the name of the vertex array to bind.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glBindVertexArrayOES")]
            [Slot(9)]
            public static extern 
            void BindVertexArray(Int32 array)
            ;
            

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
            [Slot(9)]
            public static extern 
            void BindVertexArray(UInt32 array)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glBitmapxOES")]
            [Slot(10)]
            public static extern 
            void Bitmapx(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte[] bitmap)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glBitmapxOES")]
            [Slot(10)]
            public static extern 
            void Bitmapx(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, ref Byte bitmap)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glBitmapxOES")]
            [Slot(10)]
            public static extern 
            unsafe void Bitmapx(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte* bitmap)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glBlendColorxOES")]
            [Slot(11)]
            public static extern 
            void BlendColorx(int red, int green, int blue, int alpha)
            ;
            

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
            [Slot(13)]
            public static extern 
            void BlendEquation(OpenTK.Graphics.ES11.All mode)
            ;
            

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
            [Slot(14)]
            public static extern 
            void BlendEquationSeparate(OpenTK.Graphics.ES11.All modeRGB, OpenTK.Graphics.ES11.All modeAlpha)
            ;
            

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
            [Slot(16)]
            public static extern 
            void BlendFuncSeparate(OpenTK.Graphics.ES11.All srcRGB, OpenTK.Graphics.ES11.All dstRGB, OpenTK.Graphics.ES11.All srcAlpha, OpenTK.Graphics.ES11.All dstAlpha)
            ;
            

            /// <summary>[requires: OES_framebuffer_object]
            /// Check the completeness status of a framebuffer
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specify the target of the framebuffer completeness check.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glCheckFramebufferStatusOES")]
            [Slot(19)]
            public static extern 
            OpenTK.Graphics.ES11.All CheckFramebufferStatus(OpenTK.Graphics.ES11.All target)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClearAccumxOES")]
            [Slot(21)]
            public static extern 
            void ClearAccumx(int red, int green, int blue, int alpha)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClearColorxOES")]
            [Slot(24)]
            public static extern 
            void ClearColorx(int red, int green, int blue, int alpha)
            ;
            

            /// <summary>[requires: OES_single_precision]
            /// Specify the clear value for the depth buffer
            /// </summary>
            /// <param name="depth">
            /// <para>
            /// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glClearDepthfOES")]
            [Slot(26)]
            public static extern 
            void ClearDepth(Single depth)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClearDepthxOES")]
            [Slot(28)]
            public static extern 
            void ClearDepthx(int depth)
            ;
            

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
            [Slot(34)]
            public static extern 
            void ClipPlane(OpenTK.Graphics.ES11.All plane, Single[] equation)
            ;
            

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
            [Slot(34)]
            public static extern 
            void ClipPlane(OpenTK.Graphics.ES11.All plane, ref Single equation)
            ;
            

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
            [Slot(34)]
            public static extern 
            unsafe void ClipPlane(OpenTK.Graphics.ES11.All plane, Single* equation)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClipPlanexOES")]
            [Slot(37)]
            public static extern 
            void ClipPlanex(OpenTK.Graphics.ES11.All plane, int[] equation)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClipPlanexOES")]
            [Slot(37)]
            public static extern 
            void ClipPlanex(OpenTK.Graphics.ES11.All plane, ref int equation)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glClipPlanexOES")]
            [Slot(37)]
            public static extern 
            unsafe void ClipPlanex(OpenTK.Graphics.ES11.All plane, int* equation)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor3xOES")]
            [Slot(38)]
            public static extern 
            void Color3x(int red, int green, int blue)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor3xvOES")]
            [Slot(39)]
            public static extern 
            void Color3x(int[] components)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor3xvOES")]
            [Slot(39)]
            public static extern 
            void Color3x(ref int components)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor3xvOES")]
            [Slot(39)]
            public static extern 
            unsafe void Color3x(int* components)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor4xOES")]
            [Slot(43)]
            public static extern 
            void Color4x(int red, int green, int blue, int alpha)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor4xvOES")]
            [Slot(44)]
            public static extern 
            void Color4x(int[] components)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor4xvOES")]
            [Slot(44)]
            public static extern 
            void Color4x(ref int components)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glColor4xvOES")]
            [Slot(44)]
            public static extern 
            unsafe void Color4x(int* components)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glConvolutionParameterxOES")]
            [Slot(49)]
            public static extern 
            void ConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glConvolutionParameterxvOES")]
            [Slot(50)]
            public static extern 
            void ConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glConvolutionParameterxvOES")]
            [Slot(50)]
            public static extern 
            unsafe void ConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
            ;
            

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glCurrentPaletteMatrixOES")]
            [Slot(55)]
            public static extern 
            void CurrentPaletteMatrix(Int32 matrixpaletteindex)
            ;
            

            /// <summary>[requires: OES_matrix_palette]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glCurrentPaletteMatrixOES")]
            [Slot(55)]
            public static extern 
            void CurrentPaletteMatrix(UInt32 matrixpaletteindex)
            ;
            

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            [Slot(58)]
            public static extern 
            void DeleteFramebuffer(Int32 framebuffers)
            ;
            

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteFramebuffersOES")]
            [Slot(58)]
            public static extern 
            void DeleteFramebuffer(UInt32 framebuffers)
            ;
            

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
            [Slot(58)]
            public static extern 
            void DeleteFramebuffers(Int32 n, Int32[] framebuffers)
            ;
            

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
            [Slot(58)]
            public static extern 
            void DeleteFramebuffers(Int32 n, ref Int32 framebuffers)
            ;
            

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
            [Slot(58)]
            public static extern 
            unsafe void DeleteFramebuffers(Int32 n, Int32* framebuffers)
            ;
            

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
            [Slot(58)]
            public static extern 
            void DeleteFramebuffers(Int32 n, UInt32[] framebuffers)
            ;
            

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
            [Slot(58)]
            public static extern 
            void DeleteFramebuffers(Int32 n, ref UInt32 framebuffers)
            ;
            

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
            [Slot(58)]
            public static extern 
            unsafe void DeleteFramebuffers(Int32 n, UInt32* framebuffers)
            ;
            

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            [Slot(59)]
            public static extern 
            void DeleteRenderbuffer(Int32 renderbuffers)
            ;
            

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glDeleteRenderbuffersOES")]
            [Slot(59)]
            public static extern 
            void DeleteRenderbuffer(UInt32 renderbuffers)
            ;
            

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
            [Slot(59)]
            public static extern 
            void DeleteRenderbuffers(Int32 n, Int32[] renderbuffers)
            ;
            

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
            [Slot(59)]
            public static extern 
            void DeleteRenderbuffers(Int32 n, ref Int32 renderbuffers)
            ;
            

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
            [Slot(59)]
            public static extern 
            unsafe void DeleteRenderbuffers(Int32 n, Int32* renderbuffers)
            ;
            

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
            [Slot(59)]
            public static extern 
            void DeleteRenderbuffers(Int32 n, UInt32[] renderbuffers)
            ;
            

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
            [Slot(59)]
            public static extern 
            void DeleteRenderbuffers(Int32 n, ref UInt32 renderbuffers)
            ;
            

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
            [Slot(59)]
            public static extern 
            unsafe void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers)
            ;
            

            /// <summary>[requires: OES_vertex_array_object]</summary>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            [Slot(62)]
            public static extern 
            void DeleteVertexArray(Int32 arrays)
            ;
            

            /// <summary>[requires: OES_vertex_array_object]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glDeleteVertexArraysOES")]
            [Slot(62)]
            public static extern 
            void DeleteVertexArray(UInt32 arrays)
            ;
            

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
            [Slot(62)]
            public static extern 
            void DeleteVertexArrays(Int32 n, Int32[] arrays)
            ;
            

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
            [Slot(62)]
            public static extern 
            void DeleteVertexArrays(Int32 n, ref Int32 arrays)
            ;
            

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
            [Slot(62)]
            public static extern 
            unsafe void DeleteVertexArrays(Int32 n, Int32* arrays)
            ;
            

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
            [Slot(62)]
            public static extern 
            void DeleteVertexArrays(Int32 n, UInt32[] arrays)
            ;
            

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
            [Slot(62)]
            public static extern 
            void DeleteVertexArrays(Int32 n, ref UInt32 arrays)
            ;
            

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
            [Slot(62)]
            public static extern 
            unsafe void DeleteVertexArrays(Int32 n, UInt32* arrays)
            ;
            

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
            [Slot(66)]
            public static extern 
            void DepthRange(Single n, Single f)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glDepthRangexOES")]
            [Slot(68)]
            public static extern 
            void DepthRangex(int n, int f)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexfOES")]
            [Slot(75)]
            public static extern 
            void DrawTex(Single x, Single y, Single z, Single width, Single height)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexfvOES")]
            [Slot(76)]
            public static extern 
            void DrawTex(Single[] coords)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexfvOES")]
            [Slot(76)]
            public static extern 
            void DrawTex(ref Single coords)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexfvOES")]
            [Slot(76)]
            public static extern 
            unsafe void DrawTex(Single* coords)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexiOES")]
            [Slot(77)]
            public static extern 
            void DrawTex(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexivOES")]
            [Slot(78)]
            public static extern 
            void DrawTex(Int32[] coords)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexivOES")]
            [Slot(78)]
            public static extern 
            void DrawTex(ref Int32 coords)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexivOES")]
            [Slot(78)]
            public static extern 
            unsafe void DrawTex(Int32* coords)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexsOES")]
            [Slot(79)]
            public static extern 
            void DrawTex(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexsvOES")]
            [Slot(80)]
            public static extern 
            void DrawTex(Int16[] coords)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexsvOES")]
            [Slot(80)]
            public static extern 
            void DrawTex(ref Int16 coords)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexsvOES")]
            [Slot(80)]
            public static extern 
            unsafe void DrawTex(Int16* coords)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexxOES")]
            [Slot(81)]
            public static extern 
            void DrawTexx(int x, int y, int z, int width, int height)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexxvOES")]
            [Slot(82)]
            public static extern 
            void DrawTexx(int[] coords)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexxvOES")]
            [Slot(82)]
            public static extern 
            void DrawTexx(ref int coords)
            ;
            

            /// <summary>[requires: OES_draw_texture]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_draw_texture", Version = "", EntryPoint = "glDrawTexxvOES")]
            [Slot(82)]
            public static extern 
            unsafe void DrawTexx(int* coords)
            ;
            

            /// <summary>[requires: OES_EGL_image]</summary>
            [AutoGenerated(Category = "OES_EGL_image", Version = "", EntryPoint = "glEGLImageTargetRenderbufferStorageOES")]
            [Slot(83)]
            public static extern 
            void EGLImageTargetRenderbufferStorage(OpenTK.Graphics.ES11.All target, IntPtr image)
            ;
            

            /// <summary>[requires: OES_EGL_image]</summary>
            [AutoGenerated(Category = "OES_EGL_image", Version = "", EntryPoint = "glEGLImageTargetTexture2DOES")]
            [Slot(84)]
            public static extern 
            void EGLImageTargetTexture2D(OpenTK.Graphics.ES11.All target, IntPtr image)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord1xOES")]
            [Slot(89)]
            public static extern 
            void EvalCoord1x(int u)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord1xvOES")]
            [Slot(90)]
            public static extern 
            unsafe void EvalCoord1x(int* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord2xOES")]
            [Slot(91)]
            public static extern 
            void EvalCoord2x(int u, int v)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord2xvOES")]
            [Slot(92)]
            public static extern 
            void EvalCoord2x(int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord2xvOES")]
            [Slot(92)]
            public static extern 
            void EvalCoord2x(ref int coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glEvalCoord2xvOES")]
            [Slot(92)]
            public static extern 
            unsafe void EvalCoord2x(int* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFeedbackBufferxOES")]
            [Slot(105)]
            public static extern 
            void FeedbackBufferx(Int32 n, OpenTK.Graphics.ES11.All type, int[] buffer)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFeedbackBufferxOES")]
            [Slot(105)]
            public static extern 
            void FeedbackBufferx(Int32 n, OpenTK.Graphics.ES11.All type, ref int buffer)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFeedbackBufferxOES")]
            [Slot(105)]
            public static extern 
            unsafe void FeedbackBufferx(Int32 n, OpenTK.Graphics.ES11.All type, int* buffer)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFogxOES")]
            [Slot(114)]
            public static extern 
            void Fogx(OpenTK.Graphics.ES11.All pname, int param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFogxvOES")]
            [Slot(116)]
            public static extern 
            void Fogx(OpenTK.Graphics.ES11.All pname, int[] param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFogxvOES")]
            [Slot(116)]
            public static extern 
            unsafe void Fogx(OpenTK.Graphics.ES11.All pname, int* param)
            ;
            

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
            [Slot(117)]
            public static extern 
            void FramebufferRenderbuffer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All renderbuffertarget, Int32 renderbuffer)
            ;
            

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
            [Slot(117)]
            public static extern 
            void FramebufferRenderbuffer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All renderbuffertarget, UInt32 renderbuffer)
            ;
            

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glFramebufferTexture2DOES")]
            [Slot(120)]
            public static extern 
            void FramebufferTexture2D(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, Int32 texture, Int32 level)
            ;
            

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glFramebufferTexture2DOES")]
            [Slot(120)]
            public static extern 
            void FramebufferTexture2D(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level)
            ;
            

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
            [Slot(123)]
            public static extern 
            void Frustum(Single l, Single r, Single b, Single t, Single n, Single f)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glFrustumxOES")]
            [Slot(125)]
            public static extern 
            void Frustumx(int l, int r, int b, int t, int n, int f)
            ;
            

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate mipmaps for a specified texture target
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target to which the texture whose mimaps to generate is bound. target must be GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY or GL_TEXTURE_CUBE_MAP.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenerateMipmapOES")]
            [Slot(127)]
            public static extern 
            void GenerateMipmap(OpenTK.Graphics.ES11.All target)
            ;
            

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenFramebuffersOES")]
            [Slot(129)]
            public static extern 
            Int32 GenFramebuffer()
            ;
            

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
            [Slot(129)]
            public static extern 
            void GenFramebuffers(Int32 n, [OutAttribute] Int32[] framebuffers)
            ;
            

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
            [Slot(129)]
            public static extern 
            void GenFramebuffers(Int32 n, [OutAttribute] out Int32 framebuffers)
            ;
            

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
            [Slot(129)]
            public static extern 
            unsafe void GenFramebuffers(Int32 n, [OutAttribute] Int32* framebuffers)
            ;
            

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
            [Slot(129)]
            public static extern 
            void GenFramebuffers(Int32 n, [OutAttribute] UInt32[] framebuffers)
            ;
            

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
            [Slot(129)]
            public static extern 
            void GenFramebuffers(Int32 n, [OutAttribute] out UInt32 framebuffers)
            ;
            

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
            [Slot(129)]
            public static extern 
            unsafe void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers)
            ;
            

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glGenRenderbuffersOES")]
            [Slot(130)]
            public static extern 
            Int32 GenRenderbuffer()
            ;
            

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
            [Slot(130)]
            public static extern 
            void GenRenderbuffers(Int32 n, [OutAttribute] Int32[] renderbuffers)
            ;
            

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
            [Slot(130)]
            public static extern 
            void GenRenderbuffers(Int32 n, [OutAttribute] out Int32 renderbuffers)
            ;
            

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
            [Slot(130)]
            public static extern 
            unsafe void GenRenderbuffers(Int32 n, [OutAttribute] Int32* renderbuffers)
            ;
            

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
            [Slot(130)]
            public static extern 
            void GenRenderbuffers(Int32 n, [OutAttribute] UInt32[] renderbuffers)
            ;
            

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
            [Slot(130)]
            public static extern 
            void GenRenderbuffers(Int32 n, [OutAttribute] out UInt32 renderbuffers)
            ;
            

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
            [Slot(130)]
            public static extern 
            unsafe void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers)
            ;
            

            /// <summary>[requires: OES_vertex_array_object]</summary>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glGenVertexArraysOES")]
            [Slot(132)]
            public static extern 
            Int32 GenVertexArray()
            ;
            

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
            [Slot(132)]
            public static extern 
            void GenVertexArrays(Int32 n, [OutAttribute] Int32[] arrays)
            ;
            

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
            [Slot(132)]
            public static extern 
            void GenVertexArrays(Int32 n, [OutAttribute] out Int32 arrays)
            ;
            

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
            [Slot(132)]
            public static extern 
            unsafe void GenVertexArrays(Int32 n, [OutAttribute] Int32* arrays)
            ;
            

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
            [Slot(132)]
            public static extern 
            void GenVertexArrays(Int32 n, [OutAttribute] UInt32[] arrays)
            ;
            

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
            [Slot(132)]
            public static extern 
            void GenVertexArrays(Int32 n, [OutAttribute] out UInt32 arrays)
            ;
            

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
            [Slot(132)]
            public static extern 
            unsafe void GenVertexArrays(Int32 n, [OutAttribute] UInt32* arrays)
            ;
            

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            [Slot(135)]
            public static extern 
            void GetBufferPointer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] IntPtr @params)
            ;
            

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            [Slot(135)]
            public static extern 
            void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T2[] @params)
                where T2 : struct
            ;
            

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            [Slot(135)]
            public static extern 
            void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T2[,] @params)
                where T2 : struct
            ;
            

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            [Slot(135)]
            public static extern 
            void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T2[,,] @params)
                where T2 : struct
            ;
            

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glGetBufferPointervOES")]
            [Slot(135)]
            public static extern 
            void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] ref T2 @params)
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
            [Slot(137)]
            public static extern 
            void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single[] equation)
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
            [Slot(137)]
            public static extern 
            void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] out Single equation)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_single_precision", Version = "", EntryPoint = "glGetClipPlanefOES")]
            [Slot(137)]
            public static extern 
            unsafe void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetClipPlanexOES")]
            [Slot(139)]
            public static extern 
            void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int[] equation)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetClipPlanexOES")]
            [Slot(139)]
            public static extern 
            void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] out int equation)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetClipPlanexOES")]
            [Slot(139)]
            public static extern 
            unsafe void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetConvolutionParameterxvOES")]
            [Slot(140)]
            public static extern 
            void GetConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetConvolutionParameterxvOES")]
            [Slot(140)]
            public static extern 
            void GetConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetConvolutionParameterxvOES")]
            [Slot(140)]
            public static extern 
            unsafe void GetConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetFixedvOES")]
            [Slot(146)]
            public static extern 
            int GetFixed(OpenTK.Graphics.ES11.All pname)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetFixedvOES")]
            [Slot(146)]
            public static extern 
            void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetFixedvOES")]
            [Slot(146)]
            public static extern 
            void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetFixedvOES")]
            [Slot(146)]
            public static extern 
            unsafe void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            ;
            

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
            [Slot(148)]
            public static extern 
            void GetFramebufferAttachmentParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            ;
            

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
            [Slot(148)]
            public static extern 
            void GetFramebufferAttachmentParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            ;
            

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
            [Slot(148)]
            public static extern 
            unsafe void GetFramebufferAttachmentParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetHistogramParameterxvOES")]
            [Slot(150)]
            public static extern 
            void GetHistogramParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetHistogramParameterxvOES")]
            [Slot(150)]
            public static extern 
            void GetHistogramParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetHistogramParameterxvOES")]
            [Slot(150)]
            public static extern 
            unsafe void GetHistogramParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetLightxOES")]
            [Slot(154)]
            public static extern 
            void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetLightxOES")]
            [Slot(154)]
            public static extern 
            void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetLightxOES")]
            [Slot(154)]
            public static extern 
            unsafe void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMapxvOES")]
            [Slot(157)]
            public static extern 
            void GetMapx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] int[] v)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMapxvOES")]
            [Slot(157)]
            public static extern 
            void GetMapx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] out int v)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMapxvOES")]
            [Slot(157)]
            public static extern 
            unsafe void GetMapx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] int* v)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMaterialxOES")]
            [Slot(159)]
            public static extern 
            void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMaterialxvOES")]
            [Slot(161)]
            public static extern 
            void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetMaterialxvOES")]
            [Slot(161)]
            public static extern 
            unsafe void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            ;
            

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
            [Slot(166)]
            public static extern 
            void GetRenderbufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            ;
            

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
            [Slot(166)]
            public static extern 
            void GetRenderbufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            ;
            

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
            [Slot(166)]
            public static extern 
            unsafe void GetRenderbufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexEnvxvOES")]
            [Slot(172)]
            public static extern 
            void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexEnvxvOES")]
            [Slot(172)]
            public static extern 
            void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexEnvxvOES")]
            [Slot(172)]
            public static extern 
            unsafe void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            ;
            

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
            [Slot(173)]
            public static extern 
            void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params)
            ;
            

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
            [Slot(173)]
            public static extern 
            void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params)
            ;
            

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
            [Slot(173)]
            public static extern 
            unsafe void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params)
            ;
            

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
            [Slot(174)]
            public static extern 
            void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            ;
            

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
            [Slot(174)]
            public static extern 
            void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            ;
            

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
            [Slot(174)]
            public static extern 
            unsafe void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            ;
            

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenxvOES")]
            [Slot(175)]
            public static extern 
            void GetTexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenxvOES")]
            [Slot(175)]
            public static extern 
            void GetTexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            ;
            

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glGetTexGenxvOES")]
            [Slot(175)]
            public static extern 
            unsafe void GetTexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexLevelParameterxvOES")]
            [Slot(176)]
            public static extern 
            void GetTexLevelParameterx(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexLevelParameterxvOES")]
            [Slot(176)]
            public static extern 
            void GetTexLevelParameterx(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexLevelParameterxvOES")]
            [Slot(176)]
            public static extern 
            unsafe void GetTexLevelParameterx(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexParameterxvOES")]
            [Slot(180)]
            public static extern 
            void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexParameterxvOES")]
            [Slot(180)]
            public static extern 
            void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glGetTexParameterxvOES")]
            [Slot(180)]
            public static extern 
            unsafe void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glIndexxOES")]
            [Slot(182)]
            public static extern 
            void Indexx(int component)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glIndexxvOES")]
            [Slot(183)]
            public static extern 
            unsafe void Indexx(int* component)
            ;
            

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a framebuffer object
            /// </summary>
            /// <param name="framebuffer">
            /// <para>
            /// Specifies a value that may be the name of a framebuffer object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glIsFramebufferOES")]
            [Slot(187)]
            public static extern 
            bool IsFramebuffer(Int32 framebuffer)
            ;
            

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
            [Slot(187)]
            public static extern 
            bool IsFramebuffer(UInt32 framebuffer)
            ;
            

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a renderbuffer object
            /// </summary>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies a value that may be the name of a renderbuffer object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_framebuffer_object", Version = "", EntryPoint = "glIsRenderbufferOES")]
            [Slot(188)]
            public static extern 
            bool IsRenderbuffer(Int32 renderbuffer)
            ;
            

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
            [Slot(188)]
            public static extern 
            bool IsRenderbuffer(UInt32 renderbuffer)
            ;
            

            /// <summary>[requires: OES_vertex_array_object]
            /// Determine if a name corresponds to a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies a value that may be the name of a vertex array object.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_vertex_array_object", Version = "", EntryPoint = "glIsVertexArrayOES")]
            [Slot(191)]
            public static extern 
            bool IsVertexArray(Int32 array)
            ;
            

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
            [Slot(191)]
            public static extern 
            bool IsVertexArray(UInt32 array)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightModelxOES")]
            [Slot(197)]
            public static extern 
            void LightModelx(OpenTK.Graphics.ES11.All pname, int param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightModelxvOES")]
            [Slot(199)]
            public static extern 
            void LightModelx(OpenTK.Graphics.ES11.All pname, int[] param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightModelxvOES")]
            [Slot(199)]
            public static extern 
            unsafe void LightModelx(OpenTK.Graphics.ES11.All pname, int* param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightxOES")]
            [Slot(201)]
            public static extern 
            void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightxvOES")]
            [Slot(203)]
            public static extern 
            void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLightxvOES")]
            [Slot(203)]
            public static extern 
            unsafe void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLineWidthxOES")]
            [Slot(206)]
            public static extern 
            void LineWidthx(int width)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadMatrixxOES")]
            [Slot(210)]
            public static extern 
            void LoadMatrixx(int[] m)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadMatrixxOES")]
            [Slot(210)]
            public static extern 
            void LoadMatrixx(ref int m)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadMatrixxOES")]
            [Slot(210)]
            public static extern 
            unsafe void LoadMatrixx(int* m)
            ;
            

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glLoadPaletteFromModelViewMatrixOES")]
            [Slot(211)]
            public static extern 
            void LoadPaletteFromModelViewMatrix()
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadTransposeMatrixxOES")]
            [Slot(212)]
            public static extern 
            void LoadTransposeMatrixx(int[] m)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadTransposeMatrixxOES")]
            [Slot(212)]
            public static extern 
            void LoadTransposeMatrixx(ref int m)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glLoadTransposeMatrixxOES")]
            [Slot(212)]
            public static extern 
            unsafe void LoadTransposeMatrixx(int* m)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMap1xOES")]
            [Slot(214)]
            public static extern 
            void Map1x(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 stride, Int32 order, int points)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMap2xOES")]
            [Slot(215)]
            public static extern 
            void Map2x(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 ustride, Int32 uorder, int v1, int v2, Int32 vstride, Int32 vorder, int points)
            ;
            

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
            [Slot(216)]
            public static extern 
            IntPtr MapBuffer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All access)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMapGrid1xOES")]
            [Slot(218)]
            public static extern 
            void MapGrid1x(Int32 n, int u1, int u2)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMapGrid2xOES")]
            [Slot(219)]
            public static extern 
            void MapGrid2x(Int32 n, int u1, int u2, int v1, int v2)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMaterialxOES")]
            [Slot(223)]
            public static extern 
            void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMaterialxvOES")]
            [Slot(225)]
            public static extern 
            void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int[] param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMaterialxvOES")]
            [Slot(225)]
            public static extern 
            unsafe void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param)
            ;
            

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            [Slot(226)]
            public static extern 
            void MatrixIndexPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer)
            ;
            

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            [Slot(226)]
            public static extern 
            void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
                where T3 : struct
            ;
            

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            [Slot(226)]
            public static extern 
            void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
                where T3 : struct
            ;
            

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            [Slot(226)]
            public static extern 
            void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
                where T3 : struct
            ;
            

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glMatrixIndexPointerOES")]
            [Slot(226)]
            public static extern 
            void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
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
            [Slot(230)]
            public static extern 
            void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, Byte s)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord1bOES")]
            [Slot(230)]
            public static extern 
            void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, SByte s)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord1bvOES")]
            [Slot(231)]
            public static extern 
            unsafe void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, Byte* coords)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord1bvOES")]
            [Slot(231)]
            public static extern 
            unsafe void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, SByte* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord1xOES")]
            [Slot(232)]
            public static extern 
            void MultiTexCoord1x(OpenTK.Graphics.ES11.All texture, int s)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord1xvOES")]
            [Slot(233)]
            public static extern 
            unsafe void MultiTexCoord1x(OpenTK.Graphics.ES11.All texture, int* coords)
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
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bOES")]
            [Slot(234)]
            public static extern 
            void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, Byte s, Byte t)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bOES")]
            [Slot(234)]
            public static extern 
            void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, SByte s, SByte t)
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
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            [Slot(235)]
            public static extern 
            void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, Byte[] coords)
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
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            [Slot(235)]
            public static extern 
            void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, ref Byte coords)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            [Slot(235)]
            public static extern 
            unsafe void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, Byte* coords)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            [Slot(235)]
            public static extern 
            void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, SByte[] coords)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            [Slot(235)]
            public static extern 
            void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, ref SByte coords)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord2bvOES")]
            [Slot(235)]
            public static extern 
            unsafe void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, SByte* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord2xOES")]
            [Slot(236)]
            public static extern 
            void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, int s, int t)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord2xvOES")]
            [Slot(237)]
            public static extern 
            void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord2xvOES")]
            [Slot(237)]
            public static extern 
            void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, ref int coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord2xvOES")]
            [Slot(237)]
            public static extern 
            unsafe void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, int* coords)
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
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bOES")]
            [Slot(238)]
            public static extern 
            void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, Byte s, Byte t, Byte r)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bOES")]
            [Slot(238)]
            public static extern 
            void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r)
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
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            [Slot(239)]
            public static extern 
            void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, Byte[] coords)
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
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            [Slot(239)]
            public static extern 
            void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, ref Byte coords)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            [Slot(239)]
            public static extern 
            unsafe void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, Byte* coords)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            [Slot(239)]
            public static extern 
            void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, SByte[] coords)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            [Slot(239)]
            public static extern 
            void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, ref SByte coords)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord3bvOES")]
            [Slot(239)]
            public static extern 
            unsafe void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, SByte* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord3xOES")]
            [Slot(240)]
            public static extern 
            void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, int s, int t, int r)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord3xvOES")]
            [Slot(241)]
            public static extern 
            void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord3xvOES")]
            [Slot(241)]
            public static extern 
            void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, ref int coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord3xvOES")]
            [Slot(241)]
            public static extern 
            unsafe void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, int* coords)
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
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bOES")]
            [Slot(242)]
            public static extern 
            void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, Byte s, Byte t, Byte r, Byte q)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bOES")]
            [Slot(242)]
            public static extern 
            void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r, SByte q)
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
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            [Slot(243)]
            public static extern 
            void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, Byte[] coords)
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
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            [Slot(243)]
            public static extern 
            void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, ref Byte coords)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            [Slot(243)]
            public static extern 
            unsafe void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, Byte* coords)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            [Slot(243)]
            public static extern 
            void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, SByte[] coords)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            [Slot(243)]
            public static extern 
            void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, ref SByte coords)
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
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glMultiTexCoord4bvOES")]
            [Slot(243)]
            public static extern 
            unsafe void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, SByte* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord4xOES")]
            [Slot(246)]
            public static extern 
            void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord4xvOES")]
            [Slot(247)]
            public static extern 
            void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord4xvOES")]
            [Slot(247)]
            public static extern 
            void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, ref int coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultiTexCoord4xvOES")]
            [Slot(247)]
            public static extern 
            unsafe void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultMatrixxOES")]
            [Slot(250)]
            public static extern 
            void MultMatrixx(int[] m)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultMatrixxOES")]
            [Slot(250)]
            public static extern 
            void MultMatrixx(ref int m)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultMatrixxOES")]
            [Slot(250)]
            public static extern 
            unsafe void MultMatrixx(int* m)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultTransposeMatrixxOES")]
            [Slot(251)]
            public static extern 
            void MultTransposeMatrixx(int[] m)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultTransposeMatrixxOES")]
            [Slot(251)]
            public static extern 
            void MultTransposeMatrixx(ref int m)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glMultTransposeMatrixxOES")]
            [Slot(251)]
            public static extern 
            unsafe void MultTransposeMatrixx(int* m)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glNormal3xOES")]
            [Slot(254)]
            public static extern 
            void Normal3x(int nx, int ny, int nz)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glNormal3xvOES")]
            [Slot(255)]
            public static extern 
            void Normal3x(int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glNormal3xvOES")]
            [Slot(255)]
            public static extern 
            void Normal3x(ref int coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glNormal3xvOES")]
            [Slot(255)]
            public static extern 
            unsafe void Normal3x(int* coords)
            ;
            

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
            [Slot(258)]
            public static extern 
            void Ortho(Single l, Single r, Single b, Single t, Single n, Single f)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glOrthoxOES")]
            [Slot(260)]
            public static extern 
            void Orthox(int l, int r, int b, int t, int n, int f)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPassThroughxOES")]
            [Slot(261)]
            public static extern 
            void PassThroughx(int token)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelTransferxOES")]
            [Slot(265)]
            public static extern 
            void PixelTransferx(OpenTK.Graphics.ES11.All pname, int param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPixelZoomxOES")]
            [Slot(266)]
            public static extern 
            void PixelZoomx(int xfactor, int yfactor)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPointParameterxOES")]
            [Slot(270)]
            public static extern 
            void PointParameterx(OpenTK.Graphics.ES11.All pname, int param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPointParameterxvOES")]
            [Slot(272)]
            public static extern 
            void PointParameterx(OpenTK.Graphics.ES11.All pname, int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPointParameterxvOES")]
            [Slot(272)]
            public static extern 
            unsafe void PointParameterx(OpenTK.Graphics.ES11.All pname, int* @params)
            ;
            

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            [Slot(274)]
            public static extern 
            void PointSizePointer(OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer)
            ;
            

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            [Slot(274)]
            public static extern 
            void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[] pointer)
                where T2 : struct
            ;
            

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            [Slot(274)]
            public static extern 
            void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,] pointer)
                where T2 : struct
            ;
            

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            [Slot(274)]
            public static extern 
            void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,,] pointer)
                where T2 : struct
            ;
            

            /// <summary>[requires: OES_point_size_array]</summary>
            [AutoGenerated(Category = "OES_point_size_array", Version = "", EntryPoint = "glPointSizePointerOES")]
            [Slot(274)]
            public static extern 
            void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T2 pointer)
                where T2 : struct
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPointSizexOES")]
            [Slot(276)]
            public static extern 
            void PointSizex(int size)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPolygonOffsetxOES")]
            [Slot(279)]
            public static extern 
            void PolygonOffsetx(int factor, int units)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            [Slot(281)]
            public static extern 
            void PrioritizeTexturesx(Int32 n, Int32[] textures, int[] priorities)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            [Slot(281)]
            public static extern 
            void PrioritizeTexturesx(Int32 n, ref Int32 textures, ref int priorities)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            [Slot(281)]
            public static extern 
            unsafe void PrioritizeTexturesx(Int32 n, Int32* textures, int* priorities)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            [Slot(281)]
            public static extern 
            void PrioritizeTexturesx(Int32 n, UInt32[] textures, int[] priorities)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            [Slot(281)]
            public static extern 
            void PrioritizeTexturesx(Int32 n, ref UInt32 textures, ref int priorities)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glPrioritizeTexturesxOES")]
            [Slot(281)]
            public static extern 
            unsafe void PrioritizeTexturesx(Int32 n, UInt32* textures, int* priorities)
            ;
            

            /// <summary>[requires: OES_query_matrix]</summary>
            [AutoGenerated(Category = "OES_query_matrix", Version = "", EntryPoint = "glQueryMatrixxOES")]
            [Slot(283)]
            public static extern 
            Int32 QueryMatrixx([OutAttribute] int[] mantissa, [OutAttribute] Int32[] exponent)
            ;
            

            /// <summary>[requires: OES_query_matrix]</summary>
            [AutoGenerated(Category = "OES_query_matrix", Version = "", EntryPoint = "glQueryMatrixxOES")]
            [Slot(283)]
            public static extern 
            Int32 QueryMatrixx([OutAttribute] out int mantissa, [OutAttribute] out Int32 exponent)
            ;
            

            /// <summary>[requires: OES_query_matrix]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_query_matrix", Version = "", EntryPoint = "glQueryMatrixxOES")]
            [Slot(283)]
            public static extern 
            unsafe Int32 QueryMatrixx([OutAttribute] int* mantissa, [OutAttribute] Int32* exponent)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos2xOES")]
            [Slot(284)]
            public static extern 
            void RasterPos2x(int x, int y)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos2xvOES")]
            [Slot(285)]
            public static extern 
            void RasterPos2x(int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos2xvOES")]
            [Slot(285)]
            public static extern 
            void RasterPos2x(ref int coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos2xvOES")]
            [Slot(285)]
            public static extern 
            unsafe void RasterPos2x(int* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos3xOES")]
            [Slot(286)]
            public static extern 
            void RasterPos3x(int x, int y, int z)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos3xvOES")]
            [Slot(287)]
            public static extern 
            void RasterPos3x(int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos3xvOES")]
            [Slot(287)]
            public static extern 
            void RasterPos3x(ref int coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos3xvOES")]
            [Slot(287)]
            public static extern 
            unsafe void RasterPos3x(int* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos4xOES")]
            [Slot(288)]
            public static extern 
            void RasterPos4x(int x, int y, int z, int w)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos4xvOES")]
            [Slot(289)]
            public static extern 
            void RasterPos4x(int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos4xvOES")]
            [Slot(289)]
            public static extern 
            void RasterPos4x(ref int coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRasterPos4xvOES")]
            [Slot(289)]
            public static extern 
            unsafe void RasterPos4x(int* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRectxOES")]
            [Slot(292)]
            public static extern 
            void Rectx(int x1, int y1, int x2, int y2)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRectxvOES")]
            [Slot(293)]
            public static extern 
            void Rectx(int[] v1, int[] v2)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRectxvOES")]
            [Slot(293)]
            public static extern 
            void Rectx(ref int v1, ref int v2)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRectxvOES")]
            [Slot(293)]
            public static extern 
            unsafe void Rectx(int* v1, int* v2)
            ;
            

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
            [Slot(297)]
            public static extern 
            void RenderbufferStorage(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glRotatexOES")]
            [Slot(301)]
            public static extern 
            void Rotatex(int angle, int x, int y, int z)
            ;
            

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
            [Slot(303)]
            public static extern 
            void SampleCoverage(int value, bool invert)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glSampleCoveragexOES")]
            [Slot(305)]
            public static extern 
            void SampleCoveragex(int value, bool invert)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glScalexOES")]
            [Slot(308)]
            public static extern 
            void Scalex(int x, int y, int z)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord1bOES")]
            [Slot(317)]
            public static extern 
            void TexCoord1(Byte s)
            ;
            

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
            [Slot(317)]
            public static extern 
            void TexCoord1(SByte s)
            ;
            

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
            [Slot(318)]
            public static extern 
            unsafe void TexCoord1(Byte* coords)
            ;
            

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
            [Slot(318)]
            public static extern 
            unsafe void TexCoord1(SByte* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord1xOES")]
            [Slot(319)]
            public static extern 
            void TexCoord1x(int s)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord1xvOES")]
            [Slot(320)]
            public static extern 
            unsafe void TexCoord1x(int* coords)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bOES")]
            [Slot(321)]
            public static extern 
            void TexCoord2(Byte s, Byte t)
            ;
            

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
            [Slot(321)]
            public static extern 
            void TexCoord2(SByte s, SByte t)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            [Slot(322)]
            public static extern 
            void TexCoord2(Byte[] coords)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord2bvOES")]
            [Slot(322)]
            public static extern 
            void TexCoord2(ref Byte coords)
            ;
            

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
            [Slot(322)]
            public static extern 
            unsafe void TexCoord2(Byte* coords)
            ;
            

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
            [Slot(322)]
            public static extern 
            void TexCoord2(SByte[] coords)
            ;
            

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
            [Slot(322)]
            public static extern 
            void TexCoord2(ref SByte coords)
            ;
            

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
            [Slot(322)]
            public static extern 
            unsafe void TexCoord2(SByte* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord2xOES")]
            [Slot(323)]
            public static extern 
            void TexCoord2x(int s, int t)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord2xvOES")]
            [Slot(324)]
            public static extern 
            void TexCoord2x(int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord2xvOES")]
            [Slot(324)]
            public static extern 
            void TexCoord2x(ref int coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord2xvOES")]
            [Slot(324)]
            public static extern 
            unsafe void TexCoord2x(int* coords)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bOES")]
            [Slot(325)]
            public static extern 
            void TexCoord3(Byte s, Byte t, Byte r)
            ;
            

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
            [Slot(325)]
            public static extern 
            void TexCoord3(SByte s, SByte t, SByte r)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            [Slot(326)]
            public static extern 
            void TexCoord3(Byte[] coords)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord3bvOES")]
            [Slot(326)]
            public static extern 
            void TexCoord3(ref Byte coords)
            ;
            

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
            [Slot(326)]
            public static extern 
            unsafe void TexCoord3(Byte* coords)
            ;
            

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
            [Slot(326)]
            public static extern 
            void TexCoord3(SByte[] coords)
            ;
            

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
            [Slot(326)]
            public static extern 
            void TexCoord3(ref SByte coords)
            ;
            

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
            [Slot(326)]
            public static extern 
            unsafe void TexCoord3(SByte* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord3xOES")]
            [Slot(327)]
            public static extern 
            void TexCoord3x(int s, int t, int r)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord3xvOES")]
            [Slot(328)]
            public static extern 
            void TexCoord3x(int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord3xvOES")]
            [Slot(328)]
            public static extern 
            void TexCoord3x(ref int coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord3xvOES")]
            [Slot(328)]
            public static extern 
            unsafe void TexCoord3x(int* coords)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bOES")]
            [Slot(329)]
            public static extern 
            void TexCoord4(Byte s, Byte t, Byte r, Byte q)
            ;
            

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
            [Slot(329)]
            public static extern 
            void TexCoord4(SByte s, SByte t, SByte r, SByte q)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            [Slot(330)]
            public static extern 
            void TexCoord4(Byte[] coords)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glTexCoord4bvOES")]
            [Slot(330)]
            public static extern 
            void TexCoord4(ref Byte coords)
            ;
            

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
            [Slot(330)]
            public static extern 
            unsafe void TexCoord4(Byte* coords)
            ;
            

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
            [Slot(330)]
            public static extern 
            void TexCoord4(SByte[] coords)
            ;
            

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
            [Slot(330)]
            public static extern 
            void TexCoord4(ref SByte coords)
            ;
            

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
            [Slot(330)]
            public static extern 
            unsafe void TexCoord4(SByte* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord4xOES")]
            [Slot(331)]
            public static extern 
            void TexCoord4x(int s, int t, int r, int q)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord4xvOES")]
            [Slot(332)]
            public static extern 
            void TexCoord4x(int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord4xvOES")]
            [Slot(332)]
            public static extern 
            void TexCoord4x(ref int coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexCoord4xvOES")]
            [Slot(332)]
            public static extern 
            unsafe void TexCoord4x(int* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexEnvxOES")]
            [Slot(339)]
            public static extern 
            void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexEnvxvOES")]
            [Slot(341)]
            public static extern 
            void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexEnvxvOES")]
            [Slot(341)]
            public static extern 
            unsafe void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
            ;
            

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
            [Slot(342)]
            public static extern 
            void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single param)
            ;
            

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
            [Slot(343)]
            public static extern 
            void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single[] @params)
            ;
            

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
            [Slot(343)]
            public static extern 
            unsafe void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single* @params)
            ;
            

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
            [Slot(344)]
            public static extern 
            void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32 param)
            ;
            

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
            [Slot(345)]
            public static extern 
            void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32[] @params)
            ;
            

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
            [Slot(345)]
            public static extern 
            unsafe void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32* @params)
            ;
            

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glTexGenxOES")]
            [Slot(346)]
            public static extern 
            void TexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int param)
            ;
            

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glTexGenxvOES")]
            [Slot(347)]
            public static extern 
            void TexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point|OES_texture_cube_map", Version = "", EntryPoint = "glTexGenxvOES")]
            [Slot(347)]
            public static extern 
            unsafe void TexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int* @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexParameterxOES")]
            [Slot(354)]
            public static extern 
            void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexParameterxvOES")]
            [Slot(356)]
            public static extern 
            void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTexParameterxvOES")]
            [Slot(356)]
            public static extern 
            unsafe void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glTranslatexOES")]
            [Slot(366)]
            public static extern 
            void Translatex(int x, int y, int z)
            ;
            

            /// <summary>[requires: OES_mapbuffer]</summary>
            [AutoGenerated(Category = "OES_mapbuffer", Version = "", EntryPoint = "glUnmapBufferOES")]
            [Slot(367)]
            public static extern 
            bool UnmapBuffer(OpenTK.Graphics.ES11.All target)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bOES")]
            [Slot(368)]
            public static extern 
            void Vertex2(Byte x)
            ;
            

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
            [Slot(368)]
            public static extern 
            void Vertex2(SByte x)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex2bvOES")]
            [Slot(369)]
            public static extern 
            void Vertex2(Byte[] coords)
            ;
            

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
            [Slot(369)]
            public static extern 
            unsafe void Vertex2(Byte* coords)
            ;
            

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
            [Slot(369)]
            public static extern 
            void Vertex2(SByte[] coords)
            ;
            

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
            [Slot(369)]
            public static extern 
            unsafe void Vertex2(SByte* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex2xOES")]
            [Slot(370)]
            public static extern 
            void Vertex2x(int x)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex2xvOES")]
            [Slot(371)]
            public static extern 
            void Vertex2x(int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex2xvOES")]
            [Slot(371)]
            public static extern 
            unsafe void Vertex2x(int* coords)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bOES")]
            [Slot(372)]
            public static extern 
            void Vertex3(Byte x, Byte y)
            ;
            

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
            [Slot(372)]
            public static extern 
            void Vertex3(SByte x, SByte y)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            [Slot(373)]
            public static extern 
            void Vertex3(Byte[] coords)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex3bvOES")]
            [Slot(373)]
            public static extern 
            void Vertex3(ref Byte coords)
            ;
            

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
            [Slot(373)]
            public static extern 
            unsafe void Vertex3(Byte* coords)
            ;
            

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
            [Slot(373)]
            public static extern 
            void Vertex3(SByte[] coords)
            ;
            

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
            [Slot(373)]
            public static extern 
            void Vertex3(ref SByte coords)
            ;
            

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
            [Slot(373)]
            public static extern 
            unsafe void Vertex3(SByte* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex3xOES")]
            [Slot(374)]
            public static extern 
            void Vertex3x(int x, int y)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex3xvOES")]
            [Slot(375)]
            public static extern 
            void Vertex3x(int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex3xvOES")]
            [Slot(375)]
            public static extern 
            void Vertex3x(ref int coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex3xvOES")]
            [Slot(375)]
            public static extern 
            unsafe void Vertex3x(int* coords)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bOES")]
            [Slot(376)]
            public static extern 
            void Vertex4(Byte x, Byte y, Byte z)
            ;
            

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
            [Slot(376)]
            public static extern 
            void Vertex4(SByte x, SByte y, SByte z)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            [Slot(377)]
            public static extern 
            void Vertex4(Byte[] coords)
            ;
            

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [AutoGenerated(Category = "OES_byte_coordinates", Version = "", EntryPoint = "glVertex4bvOES")]
            [Slot(377)]
            public static extern 
            void Vertex4(ref Byte coords)
            ;
            

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
            [Slot(377)]
            public static extern 
            unsafe void Vertex4(Byte* coords)
            ;
            

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
            [Slot(377)]
            public static extern 
            void Vertex4(SByte[] coords)
            ;
            

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
            [Slot(377)]
            public static extern 
            void Vertex4(ref SByte coords)
            ;
            

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
            [Slot(377)]
            public static extern 
            unsafe void Vertex4(SByte* coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex4xOES")]
            [Slot(378)]
            public static extern 
            void Vertex4x(int x, int y, int z)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex4xvOES")]
            [Slot(379)]
            public static extern 
            void Vertex4x(int[] coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex4xvOES")]
            [Slot(379)]
            public static extern 
            void Vertex4x(ref int coords)
            ;
            

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "OES_fixed_point", Version = "", EntryPoint = "glVertex4xvOES")]
            [Slot(379)]
            public static extern 
            unsafe void Vertex4x(int* coords)
            ;
            

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            [Slot(383)]
            public static extern 
            void WeightPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer)
            ;
            

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            [Slot(383)]
            public static extern 
            void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
                where T3 : struct
            ;
            

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            [Slot(383)]
            public static extern 
            void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
                where T3 : struct
            ;
            

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            [Slot(383)]
            public static extern 
            void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
                where T3 : struct
            ;
            

            /// <summary>[requires: OES_matrix_palette]</summary>
            [AutoGenerated(Category = "OES_matrix_palette", Version = "", EntryPoint = "glWeightPointerOES")]
            [Slot(383)]
            public static extern 
            void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
                where T3 : struct
            ;
            

        }

        public static partial class Qcom
        {
            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glDisableDriverControlQCOM")]
            [Slot(71)]
            public static extern 
            void DisableDriverControl(Int32 driverControl)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glDisableDriverControlQCOM")]
            [Slot(71)]
            public static extern 
            void DisableDriverControl(UInt32 driverControl)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glEnableDriverControlQCOM")]
            [Slot(87)]
            public static extern 
            void EnableDriverControl(Int32 driverControl)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glEnableDriverControlQCOM")]
            [Slot(87)]
            public static extern 
            void EnableDriverControl(UInt32 driverControl)
            ;
            

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glEndTilingQCOM")]
            [Slot(88)]
            public static extern 
            void EndTiling(Int32 preserveMask)
            ;
            

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glEndTilingQCOM")]
            [Slot(88)]
            public static extern 
            void EndTiling(UInt32 preserveMask)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            [Slot(93)]
            public static extern 
            void ExtGetBufferPointer(OpenTK.Graphics.ES11.All target, [OutAttribute] IntPtr @params)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            [Slot(93)]
            public static extern 
            void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] T1[] @params)
                where T1 : struct
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            [Slot(93)]
            public static extern 
            void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] T1[,] @params)
                where T1 : struct
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            [Slot(93)]
            public static extern 
            void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] T1[,,] @params)
                where T1 : struct
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBufferPointervQCOM")]
            [Slot(93)]
            public static extern 
            void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] ref T1 @params)
                where T1 : struct
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            [Slot(94)]
            public static extern 
            void ExtGetBuffers([OutAttribute] Int32[] buffers, Int32 maxBuffers, [OutAttribute] Int32[] numBuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            [Slot(94)]
            public static extern 
            void ExtGetBuffers([OutAttribute] out Int32 buffers, Int32 maxBuffers, [OutAttribute] out Int32 numBuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            [Slot(94)]
            public static extern 
            unsafe void ExtGetBuffers([OutAttribute] Int32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            [Slot(94)]
            public static extern 
            void ExtGetBuffers([OutAttribute] UInt32[] buffers, Int32 maxBuffers, [OutAttribute] Int32[] numBuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            [Slot(94)]
            public static extern 
            void ExtGetBuffers([OutAttribute] out UInt32 buffers, Int32 maxBuffers, [OutAttribute] out Int32 numBuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetBuffersQCOM")]
            [Slot(94)]
            public static extern 
            unsafe void ExtGetBuffers([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            [Slot(95)]
            public static extern 
            void ExtGetFramebuffers([OutAttribute] Int32[] framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32[] numFramebuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            [Slot(95)]
            public static extern 
            void ExtGetFramebuffers([OutAttribute] out Int32 framebuffers, Int32 maxFramebuffers, [OutAttribute] out Int32 numFramebuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            [Slot(95)]
            public static extern 
            unsafe void ExtGetFramebuffers([OutAttribute] Int32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            [Slot(95)]
            public static extern 
            void ExtGetFramebuffers([OutAttribute] UInt32[] framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32[] numFramebuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            [Slot(95)]
            public static extern 
            void ExtGetFramebuffers([OutAttribute] out UInt32 framebuffers, Int32 maxFramebuffers, [OutAttribute] out Int32 numFramebuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetFramebuffersQCOM")]
            [Slot(95)]
            public static extern 
            unsafe void ExtGetFramebuffers([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            [Slot(96)]
            public static extern 
            void ExtGetProgramBinarySource(Int32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32[] length)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            [Slot(96)]
            public static extern 
            void ExtGetProgramBinarySource(Int32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] out Int32 length)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            [Slot(96)]
            public static extern 
            unsafe void ExtGetProgramBinarySource(Int32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            [Slot(96)]
            public static extern 
            void ExtGetProgramBinarySource(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32[] length)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            [Slot(96)]
            public static extern 
            void ExtGetProgramBinarySource(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] out Int32 length)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
            [Slot(96)]
            public static extern 
            unsafe void ExtGetProgramBinarySource(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            [Slot(97)]
            public static extern 
            void ExtGetProgram([OutAttribute] Int32[] programs, Int32 maxPrograms, [OutAttribute] Int32[] numPrograms)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            [Slot(97)]
            public static extern 
            void ExtGetProgram([OutAttribute] out Int32 programs, Int32 maxPrograms, [OutAttribute] out Int32 numPrograms)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            [Slot(97)]
            public static extern 
            unsafe void ExtGetProgram([OutAttribute] Int32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            [Slot(97)]
            public static extern 
            void ExtGetProgram([OutAttribute] UInt32[] programs, Int32 maxPrograms, [OutAttribute] Int32[] numPrograms)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            [Slot(97)]
            public static extern 
            void ExtGetProgram([OutAttribute] out UInt32 programs, Int32 maxPrograms, [OutAttribute] out Int32 numPrograms)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetProgramsQCOM")]
            [Slot(97)]
            public static extern 
            unsafe void ExtGetProgram([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            [Slot(98)]
            public static extern 
            void ExtGetRenderbuffers([OutAttribute] Int32[] renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32[] numRenderbuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            [Slot(98)]
            public static extern 
            void ExtGetRenderbuffers([OutAttribute] out Int32 renderbuffers, Int32 maxRenderbuffers, [OutAttribute] out Int32 numRenderbuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            [Slot(98)]
            public static extern 
            unsafe void ExtGetRenderbuffers([OutAttribute] Int32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            [Slot(98)]
            public static extern 
            void ExtGetRenderbuffers([OutAttribute] UInt32[] renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32[] numRenderbuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            [Slot(98)]
            public static extern 
            void ExtGetRenderbuffers([OutAttribute] out UInt32 renderbuffers, Int32 maxRenderbuffers, [OutAttribute] out Int32 numRenderbuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetRenderbuffersQCOM")]
            [Slot(98)]
            public static extern 
            unsafe void ExtGetRenderbuffers([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            [Slot(99)]
            public static extern 
            void ExtGetShaders([OutAttribute] Int32[] shaders, Int32 maxShaders, [OutAttribute] Int32[] numShaders)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            [Slot(99)]
            public static extern 
            void ExtGetShaders([OutAttribute] out Int32 shaders, Int32 maxShaders, [OutAttribute] out Int32 numShaders)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            [Slot(99)]
            public static extern 
            unsafe void ExtGetShaders([OutAttribute] Int32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            [Slot(99)]
            public static extern 
            void ExtGetShaders([OutAttribute] UInt32[] shaders, Int32 maxShaders, [OutAttribute] Int32[] numShaders)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            [Slot(99)]
            public static extern 
            void ExtGetShaders([OutAttribute] out UInt32 shaders, Int32 maxShaders, [OutAttribute] out Int32 numShaders)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtGetShadersQCOM")]
            [Slot(99)]
            public static extern 
            unsafe void ExtGetShaders([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            [Slot(100)]
            public static extern 
            void ExtGetTexLevelParameter(Int32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            [Slot(100)]
            public static extern 
            void ExtGetTexLevelParameter(Int32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            [Slot(100)]
            public static extern 
            unsafe void ExtGetTexLevelParameter(Int32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            [Slot(100)]
            public static extern 
            void ExtGetTexLevelParameter(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            [Slot(100)]
            public static extern 
            void ExtGetTexLevelParameter(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
            [Slot(100)]
            public static extern 
            unsafe void ExtGetTexLevelParameter(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            [Slot(101)]
            public static extern 
            void ExtGetTexSubImage(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [OutAttribute] IntPtr texels)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            [Slot(101)]
            public static extern 
            void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T10[] texels)
                where T10 : struct
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            [Slot(101)]
            public static extern 
            void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T10[,] texels)
                where T10 : struct
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            [Slot(101)]
            public static extern 
            void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T10[,,] texels)
                where T10 : struct
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexSubImageQCOM")]
            [Slot(101)]
            public static extern 
            void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T10 texels)
                where T10 : struct
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            [Slot(102)]
            public static extern 
            void ExtGetTextures([OutAttribute] Int32[] textures, Int32 maxTextures, [OutAttribute] Int32[] numTextures)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            [Slot(102)]
            public static extern 
            void ExtGetTextures([OutAttribute] out Int32 textures, Int32 maxTextures, [OutAttribute] out Int32 numTextures)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            [Slot(102)]
            public static extern 
            unsafe void ExtGetTextures([OutAttribute] Int32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            [Slot(102)]
            public static extern 
            void ExtGetTextures([OutAttribute] UInt32[] textures, Int32 maxTextures, [OutAttribute] Int32[] numTextures)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            [Slot(102)]
            public static extern 
            void ExtGetTextures([OutAttribute] out UInt32 textures, Int32 maxTextures, [OutAttribute] out Int32 numTextures)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtGetTexturesQCOM")]
            [Slot(102)]
            public static extern 
            unsafe void ExtGetTextures([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtIsProgramBinaryQCOM")]
            [Slot(103)]
            public static extern 
            bool ExtIsProgramBinary(Int32 program)
            ;
            

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_extended_get2", Version = "", EntryPoint = "glExtIsProgramBinaryQCOM")]
            [Slot(103)]
            public static extern 
            bool ExtIsProgramBinary(UInt32 program)
            ;
            

            /// <summary>[requires: QCOM_extended_get]</summary>
            [AutoGenerated(Category = "QCOM_extended_get", Version = "", EntryPoint = "glExtTexObjectStateOverrideiQCOM")]
            [Slot(104)]
            public static extern 
            void ExtTexObjectStateOverride(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            [Slot(141)]
            public static extern 
            void GetDriverControl([OutAttribute] Int32[] num, Int32 size, [OutAttribute] Int32[] driverControls)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            [Slot(141)]
            public static extern 
            void GetDriverControl([OutAttribute] Int32[] num, Int32 size, [OutAttribute] UInt32[] driverControls)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            [Slot(141)]
            public static extern 
            void GetDriverControl([OutAttribute] out Int32 num, Int32 size, [OutAttribute] out Int32 driverControls)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            [Slot(141)]
            public static extern 
            void GetDriverControl([OutAttribute] out Int32 num, Int32 size, [OutAttribute] out UInt32 driverControls)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            [Slot(141)]
            public static extern 
            unsafe void GetDriverControl([OutAttribute] Int32* num, Int32 size, [OutAttribute] Int32* driverControls)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            [Slot(141)]
            public static extern 
            unsafe void GetDriverControl([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            [Slot(142)]
            public static extern 
            void GetDriverControlString(Int32 driverControl, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] StringBuilder driverControlString)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            [Slot(142)]
            public static extern 
            void GetDriverControlString(Int32 driverControl, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder driverControlString)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            [Slot(142)]
            public static extern 
            unsafe void GetDriverControlString(Int32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            [Slot(142)]
            public static extern 
            void GetDriverControlString(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] StringBuilder driverControlString)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            [Slot(142)]
            public static extern 
            void GetDriverControlString(UInt32 driverControl, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder driverControlString)
            ;
            

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            [Slot(142)]
            public static extern 
            unsafe void GetDriverControlString(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString)
            ;
            

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glStartTilingQCOM")]
            [Slot(312)]
            public static extern 
            void StartTiling(Int32 x, Int32 y, Int32 width, Int32 height, Int32 preserveMask)
            ;
            

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glStartTilingQCOM")]
            [Slot(312)]
            public static extern 
            void StartTiling(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask)
            ;
            

        }

    }
}
