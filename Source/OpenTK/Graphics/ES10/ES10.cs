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

namespace OpenTK.Graphics.ES10
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
            EntryPointNames = new byte[]
            {
                // glActiveTexture
                103, 108, 65, 99, 116, 105, 118, 101, 84, 101, 120, 116, 117, 114, 101, 0,
                // glAlphaFunc
                103, 108, 65, 108, 112, 104, 97, 70, 117, 110, 99, 0,
                // glAlphaFuncx
                103, 108, 65, 108, 112, 104, 97, 70, 117, 110, 99, 120, 0,
                // glBindBuffer
                103, 108, 66, 105, 110, 100, 66, 117, 102, 102, 101, 114, 0,
                // glBindTexture
                103, 108, 66, 105, 110, 100, 84, 101, 120, 116, 117, 114, 101, 0,
                // glBlendFunc
                103, 108, 66, 108, 101, 110, 100, 70, 117, 110, 99, 0,
                // glBufferData
                103, 108, 66, 117, 102, 102, 101, 114, 68, 97, 116, 97, 0,
                // glBufferSubData
                103, 108, 66, 117, 102, 102, 101, 114, 83, 117, 98, 68, 97, 116, 97, 0,
                // glClear
                103, 108, 67, 108, 101, 97, 114, 0,
                // glClearColor
                103, 108, 67, 108, 101, 97, 114, 67, 111, 108, 111, 114, 0,
                // glClearColorx
                103, 108, 67, 108, 101, 97, 114, 67, 111, 108, 111, 114, 120, 0,
                // glClearDepthf
                103, 108, 67, 108, 101, 97, 114, 68, 101, 112, 116, 104, 102, 0,
                // glClearDepthx
                103, 108, 67, 108, 101, 97, 114, 68, 101, 112, 116, 104, 120, 0,
                // glClearStencil
                103, 108, 67, 108, 101, 97, 114, 83, 116, 101, 110, 99, 105, 108, 0,
                // glClientActiveTexture
                103, 108, 67, 108, 105, 101, 110, 116, 65, 99, 116, 105, 118, 101, 84, 101, 120, 116, 117, 114, 101, 0,
                // glClipPlanef
                103, 108, 67, 108, 105, 112, 80, 108, 97, 110, 101, 102, 0,
                // glClipPlanefIMG
                103, 108, 67, 108, 105, 112, 80, 108, 97, 110, 101, 102, 73, 77, 71, 0,
                // glClipPlanex
                103, 108, 67, 108, 105, 112, 80, 108, 97, 110, 101, 120, 0,
                // glClipPlanexIMG
                103, 108, 67, 108, 105, 112, 80, 108, 97, 110, 101, 120, 73, 77, 71, 0,
                // glColor4f
                103, 108, 67, 111, 108, 111, 114, 52, 102, 0,
                // glColor4ub
                103, 108, 67, 111, 108, 111, 114, 52, 117, 98, 0,
                // glColor4x
                103, 108, 67, 111, 108, 111, 114, 52, 120, 0,
                // glColorMask
                103, 108, 67, 111, 108, 111, 114, 77, 97, 115, 107, 0,
                // glColorPointer
                103, 108, 67, 111, 108, 111, 114, 80, 111, 105, 110, 116, 101, 114, 0,
                // glCompressedTexImage2D
                103, 108, 67, 111, 109, 112, 114, 101, 115, 115, 101, 100, 84, 101, 120, 73, 109, 97, 103, 101, 50, 68, 0,
                // glCompressedTexSubImage2D
                103, 108, 67, 111, 109, 112, 114, 101, 115, 115, 101, 100, 84, 101, 120, 83, 117, 98, 73, 109, 97, 103, 101, 50, 68, 0,
                // glCopyTexImage2D
                103, 108, 67, 111, 112, 121, 84, 101, 120, 73, 109, 97, 103, 101, 50, 68, 0,
                // glCopyTexSubImage2D
                103, 108, 67, 111, 112, 121, 84, 101, 120, 83, 117, 98, 73, 109, 97, 103, 101, 50, 68, 0,
                // glCullFace
                103, 108, 67, 117, 108, 108, 70, 97, 99, 101, 0,
                // glDeleteBuffers
                103, 108, 68, 101, 108, 101, 116, 101, 66, 117, 102, 102, 101, 114, 115, 0,
                // glDeleteTextures
                103, 108, 68, 101, 108, 101, 116, 101, 84, 101, 120, 116, 117, 114, 101, 115, 0,
                // glDepthFunc
                103, 108, 68, 101, 112, 116, 104, 70, 117, 110, 99, 0,
                // glDepthMask
                103, 108, 68, 101, 112, 116, 104, 77, 97, 115, 107, 0,
                // glDepthRangef
                103, 108, 68, 101, 112, 116, 104, 82, 97, 110, 103, 101, 102, 0,
                // glDepthRangex
                103, 108, 68, 101, 112, 116, 104, 82, 97, 110, 103, 101, 120, 0,
                // glDisable
                103, 108, 68, 105, 115, 97, 98, 108, 101, 0,
                // glDisableClientState
                103, 108, 68, 105, 115, 97, 98, 108, 101, 67, 108, 105, 101, 110, 116, 83, 116, 97, 116, 101, 0,
                // glDisableDriverControlQCOM
                103, 108, 68, 105, 115, 97, 98, 108, 101, 68, 114, 105, 118, 101, 114, 67, 111, 110, 116, 114, 111, 108, 81, 67, 79, 77, 0,
                // glDrawArrays
                103, 108, 68, 114, 97, 119, 65, 114, 114, 97, 121, 115, 0,
                // glDrawElements
                103, 108, 68, 114, 97, 119, 69, 108, 101, 109, 101, 110, 116, 115, 0,
                // glEnable
                103, 108, 69, 110, 97, 98, 108, 101, 0,
                // glEnableClientState
                103, 108, 69, 110, 97, 98, 108, 101, 67, 108, 105, 101, 110, 116, 83, 116, 97, 116, 101, 0,
                // glEnableDriverControlQCOM
                103, 108, 69, 110, 97, 98, 108, 101, 68, 114, 105, 118, 101, 114, 67, 111, 110, 116, 114, 111, 108, 81, 67, 79, 77, 0,
                // glEndTilingQCOM
                103, 108, 69, 110, 100, 84, 105, 108, 105, 110, 103, 81, 67, 79, 77, 0,
                // glExtGetBufferPointervQCOM
                103, 108, 69, 120, 116, 71, 101, 116, 66, 117, 102, 102, 101, 114, 80, 111, 105, 110, 116, 101, 114, 118, 81, 67, 79, 77, 0,
                // glExtGetBuffersQCOM
                103, 108, 69, 120, 116, 71, 101, 116, 66, 117, 102, 102, 101, 114, 115, 81, 67, 79, 77, 0,
                // glExtGetFramebuffersQCOM
                103, 108, 69, 120, 116, 71, 101, 116, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 115, 81, 67, 79, 77, 0,
                // glExtGetProgramBinarySourceQCOM
                103, 108, 69, 120, 116, 71, 101, 116, 80, 114, 111, 103, 114, 97, 109, 66, 105, 110, 97, 114, 121, 83, 111, 117, 114, 99, 101, 81, 67, 79, 77, 0,
                // glExtGetProgramsQCOM
                103, 108, 69, 120, 116, 71, 101, 116, 80, 114, 111, 103, 114, 97, 109, 115, 81, 67, 79, 77, 0,
                // glExtGetRenderbuffersQCOM
                103, 108, 69, 120, 116, 71, 101, 116, 82, 101, 110, 100, 101, 114, 98, 117, 102, 102, 101, 114, 115, 81, 67, 79, 77, 0,
                // glExtGetShadersQCOM
                103, 108, 69, 120, 116, 71, 101, 116, 83, 104, 97, 100, 101, 114, 115, 81, 67, 79, 77, 0,
                // glExtGetTexLevelParameterivQCOM
                103, 108, 69, 120, 116, 71, 101, 116, 84, 101, 120, 76, 101, 118, 101, 108, 80, 97, 114, 97, 109, 101, 116, 101, 114, 105, 118, 81, 67, 79, 77, 0,
                // glExtGetTexSubImageQCOM
                103, 108, 69, 120, 116, 71, 101, 116, 84, 101, 120, 83, 117, 98, 73, 109, 97, 103, 101, 81, 67, 79, 77, 0,
                // glExtGetTexturesQCOM
                103, 108, 69, 120, 116, 71, 101, 116, 84, 101, 120, 116, 117, 114, 101, 115, 81, 67, 79, 77, 0,
                // glExtIsProgramBinaryQCOM
                103, 108, 69, 120, 116, 73, 115, 80, 114, 111, 103, 114, 97, 109, 66, 105, 110, 97, 114, 121, 81, 67, 79, 77, 0,
                // glExtTexObjectStateOverrideiQCOM
                103, 108, 69, 120, 116, 84, 101, 120, 79, 98, 106, 101, 99, 116, 83, 116, 97, 116, 101, 79, 118, 101, 114, 114, 105, 100, 101, 105, 81, 67, 79, 77, 0,
                // glFinish
                103, 108, 70, 105, 110, 105, 115, 104, 0,
                // glFlush
                103, 108, 70, 108, 117, 115, 104, 0,
                // glFogf
                103, 108, 70, 111, 103, 102, 0,
                // glFogfv
                103, 108, 70, 111, 103, 102, 118, 0,
                // glFogx
                103, 108, 70, 111, 103, 120, 0,
                // glFogxv
                103, 108, 70, 111, 103, 120, 118, 0,
                // glFramebufferTexture2DMultisampleIMG
                103, 108, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 84, 101, 120, 116, 117, 114, 101, 50, 68, 77, 117, 108, 116, 105, 115, 97, 109, 112, 108, 101, 73, 77, 71, 0,
                // glFrontFace
                103, 108, 70, 114, 111, 110, 116, 70, 97, 99, 101, 0,
                // glFrustumf
                103, 108, 70, 114, 117, 115, 116, 117, 109, 102, 0,
                // glFrustumx
                103, 108, 70, 114, 117, 115, 116, 117, 109, 120, 0,
                // glGenBuffers
                103, 108, 71, 101, 110, 66, 117, 102, 102, 101, 114, 115, 0,
                // glGenTextures
                103, 108, 71, 101, 110, 84, 101, 120, 116, 117, 114, 101, 115, 0,
                // glGetBooleanv
                103, 108, 71, 101, 116, 66, 111, 111, 108, 101, 97, 110, 118, 0,
                // glGetBufferParameteriv
                103, 108, 71, 101, 116, 66, 117, 102, 102, 101, 114, 80, 97, 114, 97, 109, 101, 116, 101, 114, 105, 118, 0,
                // glGetClipPlanef
                103, 108, 71, 101, 116, 67, 108, 105, 112, 80, 108, 97, 110, 101, 102, 0,
                // glGetClipPlanex
                103, 108, 71, 101, 116, 67, 108, 105, 112, 80, 108, 97, 110, 101, 120, 0,
                // glGetDriverControlsQCOM
                103, 108, 71, 101, 116, 68, 114, 105, 118, 101, 114, 67, 111, 110, 116, 114, 111, 108, 115, 81, 67, 79, 77, 0,
                // glGetDriverControlStringQCOM
                103, 108, 71, 101, 116, 68, 114, 105, 118, 101, 114, 67, 111, 110, 116, 114, 111, 108, 83, 116, 114, 105, 110, 103, 81, 67, 79, 77, 0,
                // glGetError
                103, 108, 71, 101, 116, 69, 114, 114, 111, 114, 0,
                // glGetFixedv
                103, 108, 71, 101, 116, 70, 105, 120, 101, 100, 118, 0,
                // glGetFloatv
                103, 108, 71, 101, 116, 70, 108, 111, 97, 116, 118, 0,
                // glGetIntegerv
                103, 108, 71, 101, 116, 73, 110, 116, 101, 103, 101, 114, 118, 0,
                // glGetLightfv
                103, 108, 71, 101, 116, 76, 105, 103, 104, 116, 102, 118, 0,
                // glGetLightxv
                103, 108, 71, 101, 116, 76, 105, 103, 104, 116, 120, 118, 0,
                // glGetMaterialfv
                103, 108, 71, 101, 116, 77, 97, 116, 101, 114, 105, 97, 108, 102, 118, 0,
                // glGetMaterialxv
                103, 108, 71, 101, 116, 77, 97, 116, 101, 114, 105, 97, 108, 120, 118, 0,
                // glGetPixelMapxv
                103, 108, 71, 101, 116, 80, 105, 120, 101, 108, 77, 97, 112, 120, 118, 0,
                // glGetPointerv
                103, 108, 71, 101, 116, 80, 111, 105, 110, 116, 101, 114, 118, 0,
                // glGetString
                103, 108, 71, 101, 116, 83, 116, 114, 105, 110, 103, 0,
                // glGetTexEnvfv
                103, 108, 71, 101, 116, 84, 101, 120, 69, 110, 118, 102, 118, 0,
                // glGetTexEnviv
                103, 108, 71, 101, 116, 84, 101, 120, 69, 110, 118, 105, 118, 0,
                // glGetTexEnvxv
                103, 108, 71, 101, 116, 84, 101, 120, 69, 110, 118, 120, 118, 0,
                // glGetTexParameterfv
                103, 108, 71, 101, 116, 84, 101, 120, 80, 97, 114, 97, 109, 101, 116, 101, 114, 102, 118, 0,
                // glGetTexParameteriv
                103, 108, 71, 101, 116, 84, 101, 120, 80, 97, 114, 97, 109, 101, 116, 101, 114, 105, 118, 0,
                // glGetTexParameterxv
                103, 108, 71, 101, 116, 84, 101, 120, 80, 97, 114, 97, 109, 101, 116, 101, 114, 120, 118, 0,
                // glHint
                103, 108, 72, 105, 110, 116, 0,
                // glIsBuffer
                103, 108, 73, 115, 66, 117, 102, 102, 101, 114, 0,
                // glIsEnabled
                103, 108, 73, 115, 69, 110, 97, 98, 108, 101, 100, 0,
                // glIsTexture
                103, 108, 73, 115, 84, 101, 120, 116, 117, 114, 101, 0,
                // glLightf
                103, 108, 76, 105, 103, 104, 116, 102, 0,
                // glLightfv
                103, 108, 76, 105, 103, 104, 116, 102, 118, 0,
                // glLightModelf
                103, 108, 76, 105, 103, 104, 116, 77, 111, 100, 101, 108, 102, 0,
                // glLightModelfv
                103, 108, 76, 105, 103, 104, 116, 77, 111, 100, 101, 108, 102, 118, 0,
                // glLightModelx
                103, 108, 76, 105, 103, 104, 116, 77, 111, 100, 101, 108, 120, 0,
                // glLightModelxv
                103, 108, 76, 105, 103, 104, 116, 77, 111, 100, 101, 108, 120, 118, 0,
                // glLightx
                103, 108, 76, 105, 103, 104, 116, 120, 0,
                // glLightxv
                103, 108, 76, 105, 103, 104, 116, 120, 118, 0,
                // glLineWidth
                103, 108, 76, 105, 110, 101, 87, 105, 100, 116, 104, 0,
                // glLineWidthx
                103, 108, 76, 105, 110, 101, 87, 105, 100, 116, 104, 120, 0,
                // glLoadIdentity
                103, 108, 76, 111, 97, 100, 73, 100, 101, 110, 116, 105, 116, 121, 0,
                // glLoadMatrixf
                103, 108, 76, 111, 97, 100, 77, 97, 116, 114, 105, 120, 102, 0,
                // glLoadMatrixx
                103, 108, 76, 111, 97, 100, 77, 97, 116, 114, 105, 120, 120, 0,
                // glLogicOp
                103, 108, 76, 111, 103, 105, 99, 79, 112, 0,
                // glMaterialf
                103, 108, 77, 97, 116, 101, 114, 105, 97, 108, 102, 0,
                // glMaterialfv
                103, 108, 77, 97, 116, 101, 114, 105, 97, 108, 102, 118, 0,
                // glMaterialx
                103, 108, 77, 97, 116, 101, 114, 105, 97, 108, 120, 0,
                // glMaterialxv
                103, 108, 77, 97, 116, 101, 114, 105, 97, 108, 120, 118, 0,
                // glMatrixMode
                103, 108, 77, 97, 116, 114, 105, 120, 77, 111, 100, 101, 0,
                // glMultiTexCoord4f
                103, 108, 77, 117, 108, 116, 105, 84, 101, 120, 67, 111, 111, 114, 100, 52, 102, 0,
                // glMultiTexCoord4x
                103, 108, 77, 117, 108, 116, 105, 84, 101, 120, 67, 111, 111, 114, 100, 52, 120, 0,
                // glMultMatrixf
                103, 108, 77, 117, 108, 116, 77, 97, 116, 114, 105, 120, 102, 0,
                // glMultMatrixx
                103, 108, 77, 117, 108, 116, 77, 97, 116, 114, 105, 120, 120, 0,
                // glNormal3f
                103, 108, 78, 111, 114, 109, 97, 108, 51, 102, 0,
                // glNormal3x
                103, 108, 78, 111, 114, 109, 97, 108, 51, 120, 0,
                // glNormalPointer
                103, 108, 78, 111, 114, 109, 97, 108, 80, 111, 105, 110, 116, 101, 114, 0,
                // glOrthof
                103, 108, 79, 114, 116, 104, 111, 102, 0,
                // glOrthox
                103, 108, 79, 114, 116, 104, 111, 120, 0,
                // glPixelMapx
                103, 108, 80, 105, 120, 101, 108, 77, 97, 112, 120, 0,
                // glPixelStorei
                103, 108, 80, 105, 120, 101, 108, 83, 116, 111, 114, 101, 105, 0,
                // glPixelStorex
                103, 108, 80, 105, 120, 101, 108, 83, 116, 111, 114, 101, 120, 0,
                // glPointParameterf
                103, 108, 80, 111, 105, 110, 116, 80, 97, 114, 97, 109, 101, 116, 101, 114, 102, 0,
                // glPointParameterfv
                103, 108, 80, 111, 105, 110, 116, 80, 97, 114, 97, 109, 101, 116, 101, 114, 102, 118, 0,
                // glPointParameterx
                103, 108, 80, 111, 105, 110, 116, 80, 97, 114, 97, 109, 101, 116, 101, 114, 120, 0,
                // glPointParameterxv
                103, 108, 80, 111, 105, 110, 116, 80, 97, 114, 97, 109, 101, 116, 101, 114, 120, 118, 0,
                // glPointSize
                103, 108, 80, 111, 105, 110, 116, 83, 105, 122, 101, 0,
                // glPointSizex
                103, 108, 80, 111, 105, 110, 116, 83, 105, 122, 101, 120, 0,
                // glPolygonOffset
                103, 108, 80, 111, 108, 121, 103, 111, 110, 79, 102, 102, 115, 101, 116, 0,
                // glPolygonOffsetx
                103, 108, 80, 111, 108, 121, 103, 111, 110, 79, 102, 102, 115, 101, 116, 120, 0,
                // glPopMatrix
                103, 108, 80, 111, 112, 77, 97, 116, 114, 105, 120, 0,
                // glPushMatrix
                103, 108, 80, 117, 115, 104, 77, 97, 116, 114, 105, 120, 0,
                // glReadPixels
                103, 108, 82, 101, 97, 100, 80, 105, 120, 101, 108, 115, 0,
                // glRenderbufferStorageMultisampleIMG
                103, 108, 82, 101, 110, 100, 101, 114, 98, 117, 102, 102, 101, 114, 83, 116, 111, 114, 97, 103, 101, 77, 117, 108, 116, 105, 115, 97, 109, 112, 108, 101, 73, 77, 71, 0,
                // glRotatef
                103, 108, 82, 111, 116, 97, 116, 101, 102, 0,
                // glRotatex
                103, 108, 82, 111, 116, 97, 116, 101, 120, 0,
                // glSampleCoverage
                103, 108, 83, 97, 109, 112, 108, 101, 67, 111, 118, 101, 114, 97, 103, 101, 0,
                // glSampleCoveragex
                103, 108, 83, 97, 109, 112, 108, 101, 67, 111, 118, 101, 114, 97, 103, 101, 120, 0,
                // glScalef
                103, 108, 83, 99, 97, 108, 101, 102, 0,
                // glScalex
                103, 108, 83, 99, 97, 108, 101, 120, 0,
                // glScissor
                103, 108, 83, 99, 105, 115, 115, 111, 114, 0,
                // glShadeModel
                103, 108, 83, 104, 97, 100, 101, 77, 111, 100, 101, 108, 0,
                // glStartTilingQCOM
                103, 108, 83, 116, 97, 114, 116, 84, 105, 108, 105, 110, 103, 81, 67, 79, 77, 0,
                // glStencilFunc
                103, 108, 83, 116, 101, 110, 99, 105, 108, 70, 117, 110, 99, 0,
                // glStencilMask
                103, 108, 83, 116, 101, 110, 99, 105, 108, 77, 97, 115, 107, 0,
                // glStencilOp
                103, 108, 83, 116, 101, 110, 99, 105, 108, 79, 112, 0,
                // glTexCoordPointer
                103, 108, 84, 101, 120, 67, 111, 111, 114, 100, 80, 111, 105, 110, 116, 101, 114, 0,
                // glTexEnvf
                103, 108, 84, 101, 120, 69, 110, 118, 102, 0,
                // glTexEnvfv
                103, 108, 84, 101, 120, 69, 110, 118, 102, 118, 0,
                // glTexEnvi
                103, 108, 84, 101, 120, 69, 110, 118, 105, 0,
                // glTexEnviv
                103, 108, 84, 101, 120, 69, 110, 118, 105, 118, 0,
                // glTexEnvx
                103, 108, 84, 101, 120, 69, 110, 118, 120, 0,
                // glTexEnvxv
                103, 108, 84, 101, 120, 69, 110, 118, 120, 118, 0,
                // glTexImage2D
                103, 108, 84, 101, 120, 73, 109, 97, 103, 101, 50, 68, 0,
                // glTexParameterf
                103, 108, 84, 101, 120, 80, 97, 114, 97, 109, 101, 116, 101, 114, 102, 0,
                // glTexParameterfv
                103, 108, 84, 101, 120, 80, 97, 114, 97, 109, 101, 116, 101, 114, 102, 118, 0,
                // glTexParameteri
                103, 108, 84, 101, 120, 80, 97, 114, 97, 109, 101, 116, 101, 114, 105, 0,
                // glTexParameteriv
                103, 108, 84, 101, 120, 80, 97, 114, 97, 109, 101, 116, 101, 114, 105, 118, 0,
                // glTexParameterx
                103, 108, 84, 101, 120, 80, 97, 114, 97, 109, 101, 116, 101, 114, 120, 0,
                // glTexParameterxv
                103, 108, 84, 101, 120, 80, 97, 114, 97, 109, 101, 116, 101, 114, 120, 118, 0,
                // glTexSubImage2D
                103, 108, 84, 101, 120, 83, 117, 98, 73, 109, 97, 103, 101, 50, 68, 0,
                // glTranslatef
                103, 108, 84, 114, 97, 110, 115, 108, 97, 116, 101, 102, 0,
                // glTranslatex
                103, 108, 84, 114, 97, 110, 115, 108, 97, 116, 101, 120, 0,
                // glVertexPointer
                103, 108, 86, 101, 114, 116, 101, 120, 80, 111, 105, 110, 116, 101, 114, 0,
                // glViewport
                103, 108, 86, 105, 101, 119, 112, 111, 114, 116, 0,
            };
            EntryPointNameOffsets = new int[]
            {
                0,
                16,
                28,
                41,
                54,
                68,
                80,
                93,
                109,
                117,
                130,
                144,
                158,
                172,
                187,
                209,
                222,
                238,
                251,
                267,
                277,
                288,
                298,
                310,
                325,
                348,
                374,
                391,
                411,
                422,
                438,
                455,
                467,
                479,
                493,
                507,
                517,
                538,
                565,
                578,
                593,
                602,
                622,
                648,
                664,
                691,
                711,
                736,
                768,
                789,
                815,
                835,
                867,
                891,
                912,
                937,
                970,
                979,
                987,
                994,
                1002,
                1009,
                1017,
                1054,
                1066,
                1077,
                1088,
                1101,
                1115,
                1129,
                1152,
                1168,
                1184,
                1208,
                1237,
                1248,
                1260,
                1272,
                1286,
                1299,
                1312,
                1328,
                1344,
                1360,
                1374,
                1386,
                1400,
                1414,
                1428,
                1448,
                1468,
                1488,
                1495,
                1506,
                1518,
                1530,
                1539,
                1549,
                1563,
                1578,
                1592,
                1607,
                1616,
                1626,
                1638,
                1651,
                1666,
                1680,
                1694,
                1704,
                1716,
                1729,
                1741,
                1754,
                1767,
                1785,
                1803,
                1817,
                1831,
                1842,
                1853,
                1869,
                1878,
                1887,
                1899,
                1913,
                1927,
                1945,
                1964,
                1982,
                2001,
                2013,
                2026,
                2042,
                2059,
                2071,
                2084,
                2097,
                2133,
                2143,
                2153,
                2170,
                2188,
                2197,
                2206,
                2216,
                2229,
                2247,
                2261,
                2275,
                2287,
                2305,
                2315,
                2326,
                2336,
                2347,
                2357,
                2368,
                2381,
                2397,
                2414,
                2430,
                2447,
                2463,
                2480,
                2496,
                2509,
                2522,
                2538,
            };
            EntryPoints = new IntPtr[EntryPointNameOffsets.Length];
        }

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture"> 
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least 8. texture must be one of Texturei, where i ranges from 0 to (MaxCombinedTextureImageUnits - 1). The initial value is Texture0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glActiveTexture")]
        public static void ActiveTexture(OpenTK.Graphics.ES10.All texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture"> 
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least 8. texture must be one of Texturei, where i ranges from 0 to (MaxCombinedTextureImageUnits - 1). The initial value is Texture0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glActiveTexture")]
        public static void ActiveTexture(OpenTK.Graphics.ES10.TextureUnit texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the alpha test function
        /// </summary>
        /// <param name="func"> 
        /// Specifies the alpha comparison function. Symbolic constants Never, Less, Equal, Lequal, Greater, Notequal, Gequal, and Always are accepted. The initial value is Always.
        /// </param>
        /// <param name="ref"> 
        /// Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range [0,1], where 0 represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glAlphaFunc")]
        public static void AlphaFunc(OpenTK.Graphics.ES10.All func, Single @ref) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the alpha test function
        /// </summary>
        /// <param name="func"> 
        /// Specifies the alpha comparison function. Symbolic constants Never, Less, Equal, Lequal, Greater, Notequal, Gequal, and Always are accepted. The initial value is Always.
        /// </param>
        /// <param name="ref"> 
        /// Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range [0,1], where 0 represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glAlphaFunc")]
        public static void AlphaFunc(OpenTK.Graphics.ES10.AlphaFunction func, Single @ref) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="func"></param>
        /// <param name="ref"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glAlphaFuncx")]
        public static void AlphaFuncx(OpenTK.Graphics.ES10.All func, int @ref) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the buffer object is bound. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="buffer"> 
        /// Specifies the name of a buffer object.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindBuffer")]
        [CLSCompliant(false)]
        public static void BindBuffer(OpenTK.Graphics.ES10.All target, Int32 buffer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the buffer object is bound. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="buffer"> 
        /// Specifies the name of a buffer object.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindBuffer")]
        [CLSCompliant(false)]
        public static void BindBuffer(OpenTK.Graphics.ES10.All target, UInt32 buffer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the buffer object is bound. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="buffer"> 
        /// Specifies the name of a buffer object.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindBuffer")]
        [CLSCompliant(false)]
        public static void BindBuffer(OpenTK.Graphics.ES10.BufferTarget target, Int32 buffer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target to which the buffer object is bound. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="buffer"> 
        /// Specifies the name of a buffer object.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindBuffer")]
        [CLSCompliant(false)]
        public static void BindBuffer(OpenTK.Graphics.ES10.BufferTarget target, UInt32 buffer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target of the active texture unit to which the texture is bound. Must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the name of a texture.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindTexture")]
        [CLSCompliant(false)]
        public static void BindTexture(OpenTK.Graphics.ES10.All target, Int32 texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target of the active texture unit to which the texture is bound. Must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the name of a texture.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindTexture")]
        [CLSCompliant(false)]
        public static void BindTexture(OpenTK.Graphics.ES10.All target, UInt32 texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target of the active texture unit to which the texture is bound. Must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the name of a texture.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindTexture")]
        [CLSCompliant(false)]
        public static void BindTexture(OpenTK.Graphics.ES10.TextureTarget target, Int32 texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target of the active texture unit to which the texture is bound. Must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="texture"> 
        /// Specifies the name of a texture.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBindTexture")]
        [CLSCompliant(false)]
        public static void BindTexture(OpenTK.Graphics.ES10.TextureTarget target, UInt32 texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify pixel arithmetic
        /// </summary>
        /// <param name="sfactor"> 
        /// Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants are accepted: Zero, One, SrcColor, OneMinusSrcColor, DstColor, OneMinusDstColor, SrcAlpha, OneMinusSrcAlpha, DstAlpha, OneMinusDstAlpha, ConstantColor, OneMinusConstantColor, ConstantAlpha, OneMinusConstantAlpha, and SrcAlphaSaturate. The initial value is One.
        /// </param>
        /// <param name="dfactor"> 
        /// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: Zero, One, SrcColor, OneMinusSrcColor, DstColor, OneMinusDstColor, SrcAlpha, OneMinusSrcAlpha, DstAlpha, OneMinusDstAlpha. ConstantColor, OneMinusConstantColor, ConstantAlpha, and OneMinusConstantAlpha. The initial value is Zero.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBlendFunc")]
        public static void BlendFunc(OpenTK.Graphics.ES10.All sfactor, OpenTK.Graphics.ES10.All dfactor) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify pixel arithmetic
        /// </summary>
        /// <param name="sfactor"> 
        /// Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants are accepted: Zero, One, SrcColor, OneMinusSrcColor, DstColor, OneMinusDstColor, SrcAlpha, OneMinusSrcAlpha, DstAlpha, OneMinusDstAlpha, ConstantColor, OneMinusConstantColor, ConstantAlpha, OneMinusConstantAlpha, and SrcAlphaSaturate. The initial value is One.
        /// </param>
        /// <param name="dfactor"> 
        /// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: Zero, One, SrcColor, OneMinusSrcColor, DstColor, OneMinusDstColor, SrcAlpha, OneMinusSrcAlpha, DstAlpha, OneMinusDstAlpha. ConstantColor, OneMinusConstantColor, ConstantAlpha, and OneMinusConstantAlpha. The initial value is Zero.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBlendFunc")]
        public static void BlendFunc(OpenTK.Graphics.ES10.BlendingFactorSrc sfactor, OpenTK.Graphics.ES10.BlendingFactorDest dfactor) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Create and initialize a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="usage"> 
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be StreamDraw, StaticDraw, or DynamicDraw.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        public static void BufferData(OpenTK.Graphics.ES10.All target, IntPtr size, IntPtr data, OpenTK.Graphics.ES10.All usage) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Create and initialize a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="usage"> 
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be StreamDraw, StaticDraw, or DynamicDraw.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        [CLSCompliant(false)]
        public static void BufferData<T2>(OpenTK.Graphics.ES10.All target, IntPtr size, [InAttribute, OutAttribute] T2[] data, OpenTK.Graphics.ES10.All usage)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Create and initialize a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="usage"> 
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be StreamDraw, StaticDraw, or DynamicDraw.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        [CLSCompliant(false)]
        public static void BufferData<T2>(OpenTK.Graphics.ES10.All target, IntPtr size, [InAttribute, OutAttribute] T2[,] data, OpenTK.Graphics.ES10.All usage)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Create and initialize a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="usage"> 
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be StreamDraw, StaticDraw, or DynamicDraw.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        [CLSCompliant(false)]
        public static void BufferData<T2>(OpenTK.Graphics.ES10.All target, IntPtr size, [InAttribute, OutAttribute] T2[,,] data, OpenTK.Graphics.ES10.All usage)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Create and initialize a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="usage"> 
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be StreamDraw, StaticDraw, or DynamicDraw.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        public static void BufferData<T2>(OpenTK.Graphics.ES10.All target, IntPtr size, [InAttribute, OutAttribute] ref T2 data, OpenTK.Graphics.ES10.All usage)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Create and initialize a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="usage"> 
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be StreamDraw, StaticDraw, or DynamicDraw.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        public static void BufferData(OpenTK.Graphics.ES10.BufferTarget target, IntPtr size, IntPtr data, OpenTK.Graphics.ES10.BufferUsageHint usage) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Create and initialize a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="usage"> 
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be StreamDraw, StaticDraw, or DynamicDraw.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        [CLSCompliant(false)]
        public static void BufferData<T2>(OpenTK.Graphics.ES10.BufferTarget target, IntPtr size, [InAttribute, OutAttribute] T2[] data, OpenTK.Graphics.ES10.BufferUsageHint usage)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Create and initialize a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="usage"> 
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be StreamDraw, StaticDraw, or DynamicDraw.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        [CLSCompliant(false)]
        public static void BufferData<T2>(OpenTK.Graphics.ES10.BufferTarget target, IntPtr size, [InAttribute, OutAttribute] T2[,] data, OpenTK.Graphics.ES10.BufferUsageHint usage)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Create and initialize a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="usage"> 
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be StreamDraw, StaticDraw, or DynamicDraw.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        [CLSCompliant(false)]
        public static void BufferData<T2>(OpenTK.Graphics.ES10.BufferTarget target, IntPtr size, [InAttribute, OutAttribute] T2[,,] data, OpenTK.Graphics.ES10.BufferUsageHint usage)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Create and initialize a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to data that will be copied into the data store for initialization, or Null if no data is to be copied.
        /// </param>
        /// <param name="usage"> 
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be StreamDraw, StaticDraw, or DynamicDraw.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferData")]
        public static void BufferData<T2>(OpenTK.Graphics.ES10.BufferTarget target, IntPtr size, [InAttribute, OutAttribute] ref T2 data, OpenTK.Graphics.ES10.BufferUsageHint usage)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Update a subset of a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="offset"> 
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the data store region being replaced.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        public static void BufferSubData(OpenTK.Graphics.ES10.All target, IntPtr offset, IntPtr size, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Update a subset of a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="offset"> 
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the data store region being replaced.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        [CLSCompliant(false)]
        public static void BufferSubData<T3>(OpenTK.Graphics.ES10.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[] data)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Update a subset of a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="offset"> 
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the data store region being replaced.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        [CLSCompliant(false)]
        public static void BufferSubData<T3>(OpenTK.Graphics.ES10.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[,] data)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Update a subset of a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="offset"> 
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the data store region being replaced.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        [CLSCompliant(false)]
        public static void BufferSubData<T3>(OpenTK.Graphics.ES10.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[,,] data)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Update a subset of a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="offset"> 
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the data store region being replaced.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        public static void BufferSubData<T3>(OpenTK.Graphics.ES10.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] ref T3 data)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Update a subset of a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="offset"> 
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the data store region being replaced.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        public static void BufferSubData(OpenTK.Graphics.ES10.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Update a subset of a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="offset"> 
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the data store region being replaced.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        [CLSCompliant(false)]
        public static void BufferSubData<T3>(OpenTK.Graphics.ES10.BufferTarget target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[] data)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Update a subset of a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="offset"> 
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the data store region being replaced.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        [CLSCompliant(false)]
        public static void BufferSubData<T3>(OpenTK.Graphics.ES10.BufferTarget target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[,] data)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Update a subset of a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="offset"> 
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the data store region being replaced.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        [CLSCompliant(false)]
        public static void BufferSubData<T3>(OpenTK.Graphics.ES10.BufferTarget target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[,,] data)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Update a subset of a buffer object's data store
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="offset"> 
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </param>
        /// <param name="size"> 
        /// Specifies the size in bytes of the data store region being replaced.
        /// </param>
        /// <param name="data">[length: size] 
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glBufferSubData")]
        public static void BufferSubData<T3>(OpenTK.Graphics.ES10.BufferTarget target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] ref T3 data)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Clear buffers to preset values
        /// </summary>
        /// <param name="mask"> 
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are ColorBufferBit, DepthBufferBit, and StencilBufferBit.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClear")]
        public static void Clear(OpenTK.Graphics.ES10.All mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Clear buffers to preset values
        /// </summary>
        /// <param name="mask"> 
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are ColorBufferBit, DepthBufferBit, and StencilBufferBit.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClear")]
        public static void Clear(OpenTK.Graphics.ES10.ClearBufferMask mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Clear buffers to preset values
        /// </summary>
        /// <param name="mask"> 
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are ColorBufferBit, DepthBufferBit, and StencilBufferBit.
        /// </param>
        [Obsolete("Use ClearBufferMask overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClear")]
        public static void Clear(Int32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Clear buffers to preset values
        /// </summary>
        /// <param name="mask"> 
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are ColorBufferBit, DepthBufferBit, and StencilBufferBit.
        /// </param>
        [Obsolete("Use ClearBufferMask overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClear")]
        public static void Clear(UInt32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify clear values for the color buffers
        /// </summary>
        /// <param name="red"> 
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </param>
        /// <param name="green"> 
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </param>
        /// <param name="blue"> 
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </param>
        /// <param name="alpha"> 
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearColor")]
        public static void ClearColor(Single red, Single green, Single blue, Single alpha) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <param name="alpha"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearColorx")]
        public static void ClearColorx(int red, int green, int blue, int alpha) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the clear value for the depth buffer
        /// </summary>
        /// <param name="d"> 
        /// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearDepthf")]
        public static void ClearDepth(Single d) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="depth"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearDepthx")]
        public static void ClearDepthx(int depth) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the clear value for the stencil buffer
        /// </summary>
        /// <param name="s"> 
        /// Specifies the index used when the stencil buffer is cleared. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClearStencil")]
        public static void ClearStencil(Int32 s) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture"> 
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least two. texture must be one of Texturei, where i ranges from 0 to the value of MaxTextureCoords - 1, which is an implementation-dependent value.  The initial value is Texture0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClientActiveTexture")]
        public static void ClientActiveTexture(OpenTK.Graphics.ES10.All texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture"> 
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least two. texture must be one of Texturei, where i ranges from 0 to the value of MaxTextureCoords - 1, which is an implementation-dependent value.  The initial value is Texture0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClientActiveTexture")]
        public static void ClientActiveTexture(OpenTK.Graphics.ES10.TextureUnit texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a plane against which all geometry is clipped
        /// </summary>
        /// <param name="p"> 
        /// Specifies which clipping plane is being positioned. Symbolic names of the form ClipPlanei, where i is an integer between 0 and MaxClipPlanes - 1, are accepted.
        /// </param>
        /// <param name="eqn">[length: 4] 
        /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanef")]
        [CLSCompliant(false)]
        public static void ClipPlane(OpenTK.Graphics.ES10.All p, Single[] eqn) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a plane against which all geometry is clipped
        /// </summary>
        /// <param name="p"> 
        /// Specifies which clipping plane is being positioned. Symbolic names of the form ClipPlanei, where i is an integer between 0 and MaxClipPlanes - 1, are accepted.
        /// </param>
        /// <param name="eqn">[length: 4] 
        /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanef")]
        [CLSCompliant(false)]
        public static void ClipPlane(OpenTK.Graphics.ES10.All p, ref Single eqn) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a plane against which all geometry is clipped
        /// </summary>
        /// <param name="p"> 
        /// Specifies which clipping plane is being positioned. Symbolic names of the form ClipPlanei, where i is an integer between 0 and MaxClipPlanes - 1, are accepted.
        /// </param>
        /// <param name="eqn">[length: 4] 
        /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanef")]
        [CLSCompliant(false)]
        public static unsafe void ClipPlane(OpenTK.Graphics.ES10.All p, Single* eqn) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or IMG_user_clip_plane]</summary>
        /// <param name="p"></param>
        /// <param name="eqn">[length: 4]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "IMG_user_clip_plane", Version = "1.0", EntryPoint = "glClipPlanefIMG")]
        [CLSCompliant(false)]
        public static void ClipPlanefIMG(OpenTK.Graphics.ES10.All p, Single[] eqn) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or IMG_user_clip_plane]</summary>
        /// <param name="p"></param>
        /// <param name="eqn">[length: 4]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "IMG_user_clip_plane", Version = "1.0", EntryPoint = "glClipPlanefIMG")]
        [CLSCompliant(false)]
        public static void ClipPlanefIMG(OpenTK.Graphics.ES10.All p, ref Single eqn) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or IMG_user_clip_plane]</summary>
        /// <param name="p"></param>
        /// <param name="eqn">[length: 4]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "IMG_user_clip_plane", Version = "1.0", EntryPoint = "glClipPlanefIMG")]
        [CLSCompliant(false)]
        public static unsafe void ClipPlanefIMG(OpenTK.Graphics.ES10.All p, Single* eqn) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="plane"></param>
        /// <param name="equation">[length: 4]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanex")]
        [CLSCompliant(false)]
        public static void ClipPlanex(OpenTK.Graphics.ES10.All plane, int[] equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="plane"></param>
        /// <param name="equation">[length: 4]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanex")]
        [CLSCompliant(false)]
        public static void ClipPlanex(OpenTK.Graphics.ES10.All plane, ref int equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="plane"></param>
        /// <param name="equation">[length: 4]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glClipPlanex")]
        [CLSCompliant(false)]
        public static unsafe void ClipPlanex(OpenTK.Graphics.ES10.All plane, int* equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or IMG_user_clip_plane]</summary>
        /// <param name="p"></param>
        /// <param name="eqn">[length: 4]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "IMG_user_clip_plane", Version = "1.0", EntryPoint = "glClipPlanexIMG")]
        [CLSCompliant(false)]
        public static void ClipPlanexIMG(OpenTK.Graphics.ES10.All p, int[] eqn) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or IMG_user_clip_plane]</summary>
        /// <param name="p"></param>
        /// <param name="eqn">[length: 4]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "IMG_user_clip_plane", Version = "1.0", EntryPoint = "glClipPlanexIMG")]
        [CLSCompliant(false)]
        public static void ClipPlanexIMG(OpenTK.Graphics.ES10.All p, ref int eqn) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or IMG_user_clip_plane]</summary>
        /// <param name="p"></param>
        /// <param name="eqn">[length: 4]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "IMG_user_clip_plane", Version = "1.0", EntryPoint = "glClipPlanexIMG")]
        [CLSCompliant(false)]
        public static unsafe void ClipPlanexIMG(OpenTK.Graphics.ES10.All p, int* eqn) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the current color
        /// </summary>
        /// <param name="red"> 
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green"> 
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue"> 
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="alpha"> 
        /// Specifies a new alpha value for the current color. Included only in the four-argument glColor4 commands.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColor4f")]
        public static void Color4(Single red, Single green, Single blue, Single alpha) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the current color
        /// </summary>
        /// <param name="red"> 
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green"> 
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue"> 
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="alpha"> 
        /// Specifies a new alpha value for the current color. Included only in the four-argument glColor4 commands.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColor4ub")]
        public static void Color4(Byte red, Byte green, Byte blue, Byte alpha) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <param name="alpha"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColor4x")]
        public static void Color4x(int red, int green, int blue, int alpha) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Enable and disable writing of frame buffer color components
        /// </summary>
        /// <param name="red"> 
        /// Specify whether red, green, blue, and alpha can or cannot be written into the frame buffer. The initial values are all True, indicating that the color components can be written.
        /// </param>
        /// <param name="green"> 
        /// Specify whether red, green, blue, and alpha can or cannot be written into the frame buffer. The initial values are all True, indicating that the color components can be written.
        /// </param>
        /// <param name="blue"> 
        /// Specify whether red, green, blue, and alpha can or cannot be written into the frame buffer. The initial values are all True, indicating that the color components can be written.
        /// </param>
        /// <param name="alpha"> 
        /// Specify whether red, green, blue, and alpha can or cannot be written into the frame buffer. The initial values are all True, indicating that the color components can be written.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorMask")]
        public static void ColorMask(bool red, bool green, bool blue, bool alpha) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        public static void ColorPointer(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        [CLSCompliant(false)]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        [CLSCompliant(false)]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        [CLSCompliant(false)]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        public static void ColorPointer(Int32 size, OpenTK.Graphics.ES10.ColorPointerType type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        [CLSCompliant(false)]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES10.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        [CLSCompliant(false)]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES10.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        [CLSCompliant(false)]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES10.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glColorPointer")]
        public static void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES10.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        public static void CompressedTexImage2D(OpenTK.Graphics.ES10.All target, Int32 level, OpenTK.Graphics.ES10.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES10.All target, Int32 level, OpenTK.Graphics.ES10.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES10.All target, Int32 level, OpenTK.Graphics.ES10.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES10.All target, Int32 level, OpenTK.Graphics.ES10.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,,] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES10.All target, Int32 level, OpenTK.Graphics.ES10.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] ref T7 data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        public static void CompressedTexImage2D(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, OpenTK.Graphics.ES10.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, OpenTK.Graphics.ES10.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, OpenTK.Graphics.ES10.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, OpenTK.Graphics.ES10.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,,] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, OpenTK.Graphics.ES10.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] ref T7 data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        public static void CompressedTexImage2D(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, OpenTK.Graphics.ES10.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, OpenTK.Graphics.ES10.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, OpenTK.Graphics.ES10.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, OpenTK.Graphics.ES10.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,,] data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexImage2D")]
        public static void CompressedTexImage2D<T7>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, OpenTK.Graphics.ES10.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] ref T7 data)
            where T7 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        public static void CompressedTexSubImage2D(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, Int32 imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, Int32 imageSize, [InAttribute, OutAttribute] T8[] data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, Int32 imageSize, [InAttribute, OutAttribute] T8[,] data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, Int32 imageSize, [InAttribute, OutAttribute] T8[,,] data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, Int32 imageSize, [InAttribute, OutAttribute] ref T8 data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        public static void CompressedTexSubImage2D(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, Int32 imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[] data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[,] data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        [CLSCompliant(false)]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[,,] data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the compressed image data stored at address data.
        /// </param>
        /// <param name="imageSize"> 
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </param>
        /// <param name="data">[length: imageSize] 
        /// Specifies a pointer to the compressed image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCompressedTexSubImage2D")]
        public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] ref T8 data)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Copy pixels into a 2D texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, or Rgba.
        /// </param>
        /// <param name="x"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCopyTexImage2D")]
        public static void CopyTexImage2D(OpenTK.Graphics.ES10.All target, Int32 level, OpenTK.Graphics.ES10.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Copy pixels into a 2D texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, or Rgba.
        /// </param>
        /// <param name="x"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCopyTexImage2D")]
        public static void CopyTexImage2D(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, OpenTK.Graphics.ES10.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Copy pixels into a 2D texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, or Rgba.
        /// </param>
        /// <param name="x"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image. All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCopyTexImage2D")]
        public static void CopyTexImage2D(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, OpenTK.Graphics.ES10.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Copy a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="x"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCopyTexSubImage2D")]
        public static void CopyTexSubImage2D(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Copy a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="x"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCopyTexSubImage2D")]
        public static void CopyTexSubImage2D(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify whether front- or back-facing polygons can be culled
        /// </summary>
        /// <param name="mode"> 
        /// Specifies whether front- or back-facing polygons are candidates for culling. Symbolic constants Front, Back, and FrontAndBack are accepted. The initial value is Back.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCullFace")]
        public static void CullFace(OpenTK.Graphics.ES10.All mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify whether front- or back-facing polygons can be culled
        /// </summary>
        /// <param name="mode"> 
        /// Specifies whether front- or back-facing polygons are candidates for culling. Symbolic constants Front, Back, and FrontAndBack are accepted. The initial value is Back.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glCullFace")]
        public static void CullFace(OpenTK.Graphics.ES10.CullFaceMode mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static void DeleteBuffer(Int32 buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static void DeleteBuffer(UInt32 buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer objects to be deleted.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static void DeleteBuffers(Int32 n, Int32[] buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer objects to be deleted.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static void DeleteBuffers(Int32 n, ref Int32 buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer objects to be deleted.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static unsafe void DeleteBuffers(Int32 n, Int32* buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer objects to be deleted.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static void DeleteBuffers(Int32 n, UInt32[] buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer objects to be deleted.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static void DeleteBuffers(Int32 n, ref UInt32 buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer objects to be deleted.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array of buffer objects to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteBuffers")]
        [CLSCompliant(false)]
        public static unsafe void DeleteBuffers(Int32 n, UInt32* buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static void DeleteTexture(Int32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static void DeleteTexture(UInt32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of textures to be deleted.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static void DeleteTextures(Int32 n, Int32[] textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of textures to be deleted.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static void DeleteTextures(Int32 n, ref Int32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of textures to be deleted.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static unsafe void DeleteTextures(Int32 n, Int32* textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of textures to be deleted.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static void DeleteTextures(Int32 n, UInt32[] textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of textures to be deleted.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static void DeleteTextures(Int32 n, ref UInt32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of textures to be deleted.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array of textures to be deleted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDeleteTextures")]
        [CLSCompliant(false)]
        public static unsafe void DeleteTextures(Int32 n, UInt32* textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the value used for depth buffer comparisons
        /// </summary>
        /// <param name="func"> 
        /// Specifies the depth comparison function. Symbolic constants Never, Less, Equal, Lequal, Greater, Notequal, Gequal, and Always are accepted. The initial value is Less.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthFunc")]
        public static void DepthFunc(OpenTK.Graphics.ES10.All func) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the value used for depth buffer comparisons
        /// </summary>
        /// <param name="func"> 
        /// Specifies the depth comparison function. Symbolic constants Never, Less, Equal, Lequal, Greater, Notequal, Gequal, and Always are accepted. The initial value is Less.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthFunc")]
        public static void DepthFunc(OpenTK.Graphics.ES10.DepthFunction func) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Enable or disable writing into the depth buffer
        /// </summary>
        /// <param name="flag"> 
        /// Specifies whether the depth buffer is enabled for writing. If flag is False, depth buffer writing is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthMask")]
        public static void DepthMask(bool flag) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify mapping of depth values from normalized device coordinates to window coordinates
        /// </summary>
        /// <param name="n"> 
        /// Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.
        /// </param>
        /// <param name="f"> 
        /// Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthRangef")]
        public static void DepthRange(Single n, Single f) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="n"></param>
        /// <param name="f"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDepthRangex")]
        public static void DepthRangex(int n, int f) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="cap"></param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisable")]
        public static void Disable(OpenTK.Graphics.ES10.All cap) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="cap"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisable")]
        public static void Disable(OpenTK.Graphics.ES10.EnableCap cap) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="array"></param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisableClientState")]
        public static void DisableClientState(OpenTK.Graphics.ES10.All array) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="array"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDisableClientState")]
        public static void DisableClientState(OpenTK.Graphics.ES10.EnableCap array) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="driverControl"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glDisableDriverControlQCOM")]
        [CLSCompliant(false)]
        public static void DisableDriverControlQCOM(Int32 driverControl) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="driverControl"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glDisableDriverControlQCOM")]
        [CLSCompliant(false)]
        public static void DisableDriverControlQCOM(UInt32 driverControl) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="first"> 
        /// Specifies the starting index in the enabled arrays.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of indices to be rendered.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawArrays")]
        public static void DrawArrays(OpenTK.Graphics.ES10.All mode, Int32 first, Int32 count) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="first"> 
        /// Specifies the starting index in the enabled arrays.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of indices to be rendered.
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawArrays")]
        public static void DrawArrays(OpenTK.Graphics.ES10.BeginMode mode, Int32 first, Int32 count) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="first"> 
        /// Specifies the starting index in the enabled arrays.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of indices to be rendered.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawArrays")]
        public static void DrawArrays(OpenTK.Graphics.ES10.PrimitiveType mode, Int32 first, Int32 count) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements(OpenTK.Graphics.ES10.All mode, Int32 count, OpenTK.Graphics.ES10.All type, IntPtr indices) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.All mode, Int32 count, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T3[] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.All mode, Int32 count, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T3[,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.All mode, Int32 count, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T3[,,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.All mode, Int32 count, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] ref T3 indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements(OpenTK.Graphics.ES10.BeginMode mode, Int32 count, OpenTK.Graphics.ES10.All type, IntPtr indices) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.BeginMode mode, Int32 count, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T3[] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.BeginMode mode, Int32 count, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T3[,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.BeginMode mode, Int32 count, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T3[,,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.BeginMode mode, Int32 count, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] ref T3 indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements(OpenTK.Graphics.ES10.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES10.All type, IntPtr indices) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T3[] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T3[,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T3[,,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [Obsolete("Use PrimitiveType overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] ref T3 indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements(OpenTK.Graphics.ES10.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES10.DrawElementsType type, IntPtr indices) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES10.DrawElementsType type, [InAttribute, OutAttribute] T3[] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES10.DrawElementsType type, [InAttribute, OutAttribute] T3[,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        [CLSCompliant(false)]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES10.DrawElementsType type, [InAttribute, OutAttribute] T3[,,] indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode"> 
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, and Triangles are accepted.
        /// </param>
        /// <param name="count"> 
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type"> 
        /// Specifies the type of the values in indices. Must be UnsignedByte or UnsignedShort.
        /// </param>
        /// <param name="indices">[length: count,type] 
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glDrawElements")]
        public static void DrawElements<T3>(OpenTK.Graphics.ES10.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES10.DrawElementsType type, [InAttribute, OutAttribute] ref T3 indices)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Enable or disable server-side GL capabilities
        /// </summary>
        /// <param name="cap"> 
        /// Specifies a symbolic constant indicating a GL capability.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glEnable")]
        public static void Enable(OpenTK.Graphics.ES10.All cap) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Enable or disable server-side GL capabilities
        /// </summary>
        /// <param name="cap"> 
        /// Specifies a symbolic constant indicating a GL capability.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glEnable")]
        public static void Enable(OpenTK.Graphics.ES10.EnableCap cap) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Enable or disable client-side capability
        /// </summary>
        /// <param name="array"> 
        /// Specifies the capability to enable. Symbolic constants ColorArray, EdgeFlagArray, FogCoordArray, IndexArray, NormalArray, SecondaryColorArray, TextureCoordArray, and VertexArray are accepted.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glEnableClientState")]
        public static void EnableClientState(OpenTK.Graphics.ES10.All array) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Enable or disable client-side capability
        /// </summary>
        /// <param name="array"> 
        /// Specifies the capability to enable. Symbolic constants ColorArray, EdgeFlagArray, FogCoordArray, IndexArray, NormalArray, SecondaryColorArray, TextureCoordArray, and VertexArray are accepted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glEnableClientState")]
        public static void EnableClientState(OpenTK.Graphics.ES10.ArrayCap array) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Enable or disable client-side capability
        /// </summary>
        /// <param name="array"> 
        /// Specifies the capability to enable. Symbolic constants ColorArray, EdgeFlagArray, FogCoordArray, IndexArray, NormalArray, SecondaryColorArray, TextureCoordArray, and VertexArray are accepted.
        /// </param>
        [Obsolete("Use ArrayCap overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glEnableClientState")]
        public static void EnableClientState(OpenTK.Graphics.ES10.EnableCap array) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="driverControl"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glEnableDriverControlQCOM")]
        [CLSCompliant(false)]
        public static void EnableDriverControlQCOM(Int32 driverControl) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="driverControl"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glEnableDriverControlQCOM")]
        [CLSCompliant(false)]
        public static void EnableDriverControlQCOM(UInt32 driverControl) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_tiled_rendering]</summary>
        /// <param name="preserveMask"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "1.0", EntryPoint = "glEndTilingQCOM")]
        [CLSCompliant(false)]
        public static void EndTilingQCOM(Int32 preserveMask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_tiled_rendering]</summary>
        /// <param name="preserveMask"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "1.0", EntryPoint = "glEndTilingQCOM")]
        [CLSCompliant(false)]
        public static void EndTilingQCOM(UInt32 preserveMask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="target"></param>
        /// <param name="params"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetBufferPointervQCOM")]
        public static void ExtGetBufferPointervQCOM(OpenTK.Graphics.ES10.All target, IntPtr @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="target"></param>
        /// <param name="params"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetBufferPointervQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetBufferPointervQCOM<T1>(OpenTK.Graphics.ES10.All target, [InAttribute, OutAttribute] T1[] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="target"></param>
        /// <param name="params"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetBufferPointervQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetBufferPointervQCOM<T1>(OpenTK.Graphics.ES10.All target, [InAttribute, OutAttribute] T1[,] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="target"></param>
        /// <param name="params"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetBufferPointervQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetBufferPointervQCOM<T1>(OpenTK.Graphics.ES10.All target, [InAttribute, OutAttribute] T1[,,] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="target"></param>
        /// <param name="params"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetBufferPointervQCOM")]
        public static void ExtGetBufferPointervQCOM<T1>(OpenTK.Graphics.ES10.All target, [InAttribute, OutAttribute] ref T1 @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="buffers">[length: maxBuffers]</param>
        /// <param name="maxBuffers"></param>
        /// <param name="numBuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetBuffersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetBuffersQCOM(Int32[] buffers, Int32 maxBuffers, Int32[] numBuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="buffers">[length: maxBuffers]</param>
        /// <param name="maxBuffers"></param>
        /// <param name="numBuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetBuffersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetBuffersQCOM(ref Int32 buffers, Int32 maxBuffers, ref Int32 numBuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="buffers">[length: maxBuffers]</param>
        /// <param name="maxBuffers"></param>
        /// <param name="numBuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetBuffersQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetBuffersQCOM(Int32* buffers, Int32 maxBuffers, Int32* numBuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="buffers">[length: maxBuffers]</param>
        /// <param name="maxBuffers"></param>
        /// <param name="numBuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetBuffersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetBuffersQCOM(UInt32[] buffers, Int32 maxBuffers, Int32[] numBuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="buffers">[length: maxBuffers]</param>
        /// <param name="maxBuffers"></param>
        /// <param name="numBuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetBuffersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetBuffersQCOM(ref UInt32 buffers, Int32 maxBuffers, ref Int32 numBuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="buffers">[length: maxBuffers]</param>
        /// <param name="maxBuffers"></param>
        /// <param name="numBuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetBuffersQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetBuffersQCOM(UInt32* buffers, Int32 maxBuffers, Int32* numBuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="framebuffers">[length: maxFramebuffers]</param>
        /// <param name="maxFramebuffers"></param>
        /// <param name="numFramebuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetFramebuffersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetFramebuffersQCOM(Int32[] framebuffers, Int32 maxFramebuffers, Int32[] numFramebuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="framebuffers">[length: maxFramebuffers]</param>
        /// <param name="maxFramebuffers"></param>
        /// <param name="numFramebuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetFramebuffersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetFramebuffersQCOM(ref Int32 framebuffers, Int32 maxFramebuffers, ref Int32 numFramebuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="framebuffers">[length: maxFramebuffers]</param>
        /// <param name="maxFramebuffers"></param>
        /// <param name="numFramebuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetFramebuffersQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetFramebuffersQCOM(Int32* framebuffers, Int32 maxFramebuffers, Int32* numFramebuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="framebuffers">[length: maxFramebuffers]</param>
        /// <param name="maxFramebuffers"></param>
        /// <param name="numFramebuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetFramebuffersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetFramebuffersQCOM(UInt32[] framebuffers, Int32 maxFramebuffers, Int32[] numFramebuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="framebuffers">[length: maxFramebuffers]</param>
        /// <param name="maxFramebuffers"></param>
        /// <param name="numFramebuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetFramebuffersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetFramebuffersQCOM(ref UInt32 framebuffers, Int32 maxFramebuffers, ref Int32 numFramebuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="framebuffers">[length: maxFramebuffers]</param>
        /// <param name="maxFramebuffers"></param>
        /// <param name="numFramebuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetFramebuffersQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetFramebuffersQCOM(UInt32* framebuffers, Int32 maxFramebuffers, Int32* numFramebuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="program"></param>
        /// <param name="shadertype"></param>
        /// <param name="source"></param>
        /// <param name="length"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetProgramBinarySourceQCOM(Int32 program, OpenTK.Graphics.ES10.All shadertype, String source, Int32[] length) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="program"></param>
        /// <param name="shadertype"></param>
        /// <param name="source"></param>
        /// <param name="length"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetProgramBinarySourceQCOM(Int32 program, OpenTK.Graphics.ES10.All shadertype, String source, ref Int32 length) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="program"></param>
        /// <param name="shadertype"></param>
        /// <param name="source"></param>
        /// <param name="length"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetProgramBinarySourceQCOM(Int32 program, OpenTK.Graphics.ES10.All shadertype, String source, Int32* length) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="program"></param>
        /// <param name="shadertype"></param>
        /// <param name="source"></param>
        /// <param name="length"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES10.All shadertype, String source, Int32[] length) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="program"></param>
        /// <param name="shadertype"></param>
        /// <param name="source"></param>
        /// <param name="length"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES10.All shadertype, String source, ref Int32 length) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="program"></param>
        /// <param name="shadertype"></param>
        /// <param name="source"></param>
        /// <param name="length"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetProgramBinarySourceQCOM(UInt32 program, OpenTK.Graphics.ES10.All shadertype, String source, Int32* length) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="programs">[length: maxPrograms]</param>
        /// <param name="maxPrograms"></param>
        /// <param name="numPrograms"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetProgramsQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetProgramsQCOM(Int32[] programs, Int32 maxPrograms, Int32[] numPrograms) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="programs">[length: maxPrograms]</param>
        /// <param name="maxPrograms"></param>
        /// <param name="numPrograms"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetProgramsQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetProgramsQCOM(ref Int32 programs, Int32 maxPrograms, ref Int32 numPrograms) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="programs">[length: maxPrograms]</param>
        /// <param name="maxPrograms"></param>
        /// <param name="numPrograms"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetProgramsQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetProgramsQCOM(Int32* programs, Int32 maxPrograms, Int32* numPrograms) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="programs">[length: maxPrograms]</param>
        /// <param name="maxPrograms"></param>
        /// <param name="numPrograms"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetProgramsQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetProgramsQCOM(UInt32[] programs, Int32 maxPrograms, Int32[] numPrograms) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="programs">[length: maxPrograms]</param>
        /// <param name="maxPrograms"></param>
        /// <param name="numPrograms"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetProgramsQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetProgramsQCOM(ref UInt32 programs, Int32 maxPrograms, ref Int32 numPrograms) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="programs">[length: maxPrograms]</param>
        /// <param name="maxPrograms"></param>
        /// <param name="numPrograms"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetProgramsQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetProgramsQCOM(UInt32* programs, Int32 maxPrograms, Int32* numPrograms) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="renderbuffers">[length: maxRenderbuffers]</param>
        /// <param name="maxRenderbuffers"></param>
        /// <param name="numRenderbuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetRenderbuffersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetRenderbuffersQCOM(Int32[] renderbuffers, Int32 maxRenderbuffers, Int32[] numRenderbuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="renderbuffers">[length: maxRenderbuffers]</param>
        /// <param name="maxRenderbuffers"></param>
        /// <param name="numRenderbuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetRenderbuffersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetRenderbuffersQCOM(ref Int32 renderbuffers, Int32 maxRenderbuffers, ref Int32 numRenderbuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="renderbuffers">[length: maxRenderbuffers]</param>
        /// <param name="maxRenderbuffers"></param>
        /// <param name="numRenderbuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetRenderbuffersQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetRenderbuffersQCOM(Int32* renderbuffers, Int32 maxRenderbuffers, Int32* numRenderbuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="renderbuffers">[length: maxRenderbuffers]</param>
        /// <param name="maxRenderbuffers"></param>
        /// <param name="numRenderbuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetRenderbuffersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetRenderbuffersQCOM(UInt32[] renderbuffers, Int32 maxRenderbuffers, Int32[] numRenderbuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="renderbuffers">[length: maxRenderbuffers]</param>
        /// <param name="maxRenderbuffers"></param>
        /// <param name="numRenderbuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetRenderbuffersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetRenderbuffersQCOM(ref UInt32 renderbuffers, Int32 maxRenderbuffers, ref Int32 numRenderbuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="renderbuffers">[length: maxRenderbuffers]</param>
        /// <param name="maxRenderbuffers"></param>
        /// <param name="numRenderbuffers"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetRenderbuffersQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetRenderbuffersQCOM(UInt32* renderbuffers, Int32 maxRenderbuffers, Int32* numRenderbuffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="shaders">[length: maxShaders]</param>
        /// <param name="maxShaders"></param>
        /// <param name="numShaders"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetShadersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetShadersQCOM(Int32[] shaders, Int32 maxShaders, Int32[] numShaders) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="shaders">[length: maxShaders]</param>
        /// <param name="maxShaders"></param>
        /// <param name="numShaders"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetShadersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetShadersQCOM(ref Int32 shaders, Int32 maxShaders, ref Int32 numShaders) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="shaders">[length: maxShaders]</param>
        /// <param name="maxShaders"></param>
        /// <param name="numShaders"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetShadersQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetShadersQCOM(Int32* shaders, Int32 maxShaders, Int32* numShaders) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="shaders">[length: maxShaders]</param>
        /// <param name="maxShaders"></param>
        /// <param name="numShaders"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetShadersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetShadersQCOM(UInt32[] shaders, Int32 maxShaders, Int32[] numShaders) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="shaders">[length: maxShaders]</param>
        /// <param name="maxShaders"></param>
        /// <param name="numShaders"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetShadersQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetShadersQCOM(ref UInt32 shaders, Int32 maxShaders, ref Int32 numShaders) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="shaders">[length: maxShaders]</param>
        /// <param name="maxShaders"></param>
        /// <param name="numShaders"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtGetShadersQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetShadersQCOM(UInt32* shaders, Int32 maxShaders, Int32* numShaders) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="texture"></param>
        /// <param name="face"></param>
        /// <param name="level"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetTexLevelParameterivQCOM(Int32 texture, OpenTK.Graphics.ES10.All face, Int32 level, OpenTK.Graphics.ES10.All pname, Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="texture"></param>
        /// <param name="face"></param>
        /// <param name="level"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetTexLevelParameterivQCOM(Int32 texture, OpenTK.Graphics.ES10.All face, Int32 level, OpenTK.Graphics.ES10.All pname, ref Int32 @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="texture"></param>
        /// <param name="face"></param>
        /// <param name="level"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetTexLevelParameterivQCOM(Int32 texture, OpenTK.Graphics.ES10.All face, Int32 level, OpenTK.Graphics.ES10.All pname, Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="texture"></param>
        /// <param name="face"></param>
        /// <param name="level"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES10.All face, Int32 level, OpenTK.Graphics.ES10.All pname, Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="texture"></param>
        /// <param name="face"></param>
        /// <param name="level"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES10.All face, Int32 level, OpenTK.Graphics.ES10.All pname, ref Int32 @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="texture"></param>
        /// <param name="face"></param>
        /// <param name="level"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexLevelParameterivQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetTexLevelParameterivQCOM(UInt32 texture, OpenTK.Graphics.ES10.All face, Int32 level, OpenTK.Graphics.ES10.All pname, Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="target"></param>
        /// <param name="level"></param>
        /// <param name="xoffset"></param>
        /// <param name="yoffset"></param>
        /// <param name="zoffset"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="depth"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="texels"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexSubImageQCOM")]
        public static void ExtGetTexSubImageQCOM(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, IntPtr texels) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="target"></param>
        /// <param name="level"></param>
        /// <param name="xoffset"></param>
        /// <param name="yoffset"></param>
        /// <param name="zoffset"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="depth"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="texels"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexSubImageQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetTexSubImageQCOM<T10>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T10[] texels)
            where T10 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="target"></param>
        /// <param name="level"></param>
        /// <param name="xoffset"></param>
        /// <param name="yoffset"></param>
        /// <param name="zoffset"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="depth"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="texels"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexSubImageQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetTexSubImageQCOM<T10>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T10[,] texels)
            where T10 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="target"></param>
        /// <param name="level"></param>
        /// <param name="xoffset"></param>
        /// <param name="yoffset"></param>
        /// <param name="zoffset"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="depth"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="texels"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexSubImageQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetTexSubImageQCOM<T10>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T10[,,] texels)
            where T10 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="target"></param>
        /// <param name="level"></param>
        /// <param name="xoffset"></param>
        /// <param name="yoffset"></param>
        /// <param name="zoffset"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="depth"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="texels"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexSubImageQCOM")]
        public static void ExtGetTexSubImageQCOM<T10>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] ref T10 texels)
            where T10 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="textures"></param>
        /// <param name="maxTextures"></param>
        /// <param name="numTextures"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexturesQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetTexturesQCOM(Int32[] textures, Int32 maxTextures, Int32[] numTextures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="textures"></param>
        /// <param name="maxTextures"></param>
        /// <param name="numTextures"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexturesQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetTexturesQCOM(ref Int32 textures, Int32 maxTextures, ref Int32 numTextures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="textures"></param>
        /// <param name="maxTextures"></param>
        /// <param name="numTextures"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexturesQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetTexturesQCOM(Int32* textures, Int32 maxTextures, Int32* numTextures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="textures"></param>
        /// <param name="maxTextures"></param>
        /// <param name="numTextures"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexturesQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetTexturesQCOM(UInt32[] textures, Int32 maxTextures, Int32[] numTextures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="textures"></param>
        /// <param name="maxTextures"></param>
        /// <param name="numTextures"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexturesQCOM")]
        [CLSCompliant(false)]
        public static void ExtGetTexturesQCOM(ref UInt32 textures, Int32 maxTextures, ref Int32 numTextures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="textures"></param>
        /// <param name="maxTextures"></param>
        /// <param name="numTextures"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtGetTexturesQCOM")]
        [CLSCompliant(false)]
        public static unsafe void ExtGetTexturesQCOM(UInt32* textures, Int32 maxTextures, Int32* numTextures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="program"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtIsProgramBinaryQCOM")]
        [CLSCompliant(false)]
        public static bool ExtIsProgramBinaryQCOM(Int32 program) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get2]</summary>
        /// <param name="program"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get2", Version = "1.0", EntryPoint = "glExtIsProgramBinaryQCOM")]
        [CLSCompliant(false)]
        public static bool ExtIsProgramBinaryQCOM(UInt32 program) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_extended_get]</summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_extended_get", Version = "1.0", EntryPoint = "glExtTexObjectStateOverrideiQCOM")]
        public static void ExtTexObjectStateOverrideiQCOM(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, Int32 param) { throw new NotImplementedException(); }

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
        /// Specifies a single-valued fog parameter. FogMode, FogDensity, FogStart, FogEnd, FogIndex, and FogCoordSrc are accepted.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value that pname will be set to.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogf")]
        public static void Fog(OpenTK.Graphics.ES10.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued fog parameter. FogMode, FogDensity, FogStart, FogEnd, FogIndex, and FogCoordSrc are accepted.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value that pname will be set to.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogf")]
        public static void Fog(OpenTK.Graphics.ES10.FogParameter pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued fog parameter. FogMode, FogDensity, FogStart, FogEnd, FogIndex, and FogCoordSrc are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies the value or values to be assigned to pname. FogColor requires an array of four values. All other parameters accept an array containing only a single value.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogfv")]
        [CLSCompliant(false)]
        public static void Fog(OpenTK.Graphics.ES10.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued fog parameter. FogMode, FogDensity, FogStart, FogEnd, FogIndex, and FogCoordSrc are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies the value or values to be assigned to pname. FogColor requires an array of four values. All other parameters accept an array containing only a single value.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogfv")]
        [CLSCompliant(false)]
        public static unsafe void Fog(OpenTK.Graphics.ES10.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued fog parameter. FogMode, FogDensity, FogStart, FogEnd, FogIndex, and FogCoordSrc are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies the value or values to be assigned to pname. FogColor requires an array of four values. All other parameters accept an array containing only a single value.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogfv")]
        [CLSCompliant(false)]
        public static void Fog(OpenTK.Graphics.ES10.FogParameter pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued fog parameter. FogMode, FogDensity, FogStart, FogEnd, FogIndex, and FogCoordSrc are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies the value or values to be assigned to pname. FogColor requires an array of four values. All other parameters accept an array containing only a single value.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogfv")]
        [CLSCompliant(false)]
        public static unsafe void Fog(OpenTK.Graphics.ES10.FogParameter pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogx")]
        public static void Fogx(OpenTK.Graphics.ES10.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="param">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogxv")]
        [CLSCompliant(false)]
        public static void Fogx(OpenTK.Graphics.ES10.All pname, int[] param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="param">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFogxv")]
        [CLSCompliant(false)]
        public static unsafe void Fogx(OpenTK.Graphics.ES10.All pname, int* param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or IMG_multisampled_render_to_texture]</summary>
        /// <param name="target"></param>
        /// <param name="attachment"></param>
        /// <param name="textarget"></param>
        /// <param name="texture"></param>
        /// <param name="level"></param>
        /// <param name="samples"></param>
        [Obsolete("Use GL.Img instead")]
        [AutoGenerated(Category = "IMG_multisampled_render_to_texture", Version = "1.0", EntryPoint = "glFramebufferTexture2DMultisampleIMG")]
        [CLSCompliant(false)]
        public static void FramebufferTexture2DMultisampleIMG(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All attachment, OpenTK.Graphics.ES10.All textarget, Int32 texture, Int32 level, Int32 samples) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or IMG_multisampled_render_to_texture]</summary>
        /// <param name="target"></param>
        /// <param name="attachment"></param>
        /// <param name="textarget"></param>
        /// <param name="texture"></param>
        /// <param name="level"></param>
        /// <param name="samples"></param>
        [Obsolete("Use GL.Img instead")]
        [AutoGenerated(Category = "IMG_multisampled_render_to_texture", Version = "1.0", EntryPoint = "glFramebufferTexture2DMultisampleIMG")]
        [CLSCompliant(false)]
        public static void FramebufferTexture2DMultisampleIMG(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All attachment, OpenTK.Graphics.ES10.All textarget, UInt32 texture, Int32 level, Int32 samples) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define front- and back-facing polygons
        /// </summary>
        /// <param name="mode"> 
        /// Specifies the orientation of front-facing polygons. Cw and Ccw are accepted. The initial value is Ccw.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFrontFace")]
        public static void FrontFace(OpenTK.Graphics.ES10.All mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define front- and back-facing polygons
        /// </summary>
        /// <param name="mode"> 
        /// Specifies the orientation of front-facing polygons. Cw and Ccw are accepted. The initial value is Ccw.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFrontFace")]
        public static void FrontFace(OpenTK.Graphics.ES10.FrontFaceDirection mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a perspective matrix
        /// </summary>
        /// <param name="l"> 
        /// Specify the coordinates for the left and right vertical clipping planes.
        /// </param>
        /// <param name="r"> 
        /// Specify the coordinates for the left and right vertical clipping planes.
        /// </param>
        /// <param name="b"> 
        /// Specify the coordinates for the bottom and top horizontal clipping planes.
        /// </param>
        /// <param name="t"> 
        /// Specify the coordinates for the bottom and top horizontal clipping planes.
        /// </param>
        /// <param name="n"> 
        /// Specify the distances to the near and far depth clipping planes. Both distances must be positive.
        /// </param>
        /// <param name="f"> 
        /// Specify the distances to the near and far depth clipping planes. Both distances must be positive.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFrustumf")]
        public static void Frustum(Single l, Single r, Single b, Single t, Single n, Single f) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <param name="n"></param>
        /// <param name="f"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glFrustumx")]
        public static void Frustumx(int l, int r, int b, int t, int n, int f) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static Int32 GenBuffer() { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer object names to be generated.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array in which the generated buffer object names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static void GenBuffers(Int32 n, [OutAttribute] Int32[] buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer object names to be generated.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array in which the generated buffer object names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static void GenBuffers(Int32 n, [OutAttribute] out Int32 buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer object names to be generated.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array in which the generated buffer object names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static unsafe void GenBuffers(Int32 n, [OutAttribute] Int32* buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer object names to be generated.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array in which the generated buffer object names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static void GenBuffers(Int32 n, [OutAttribute] UInt32[] buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer object names to be generated.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array in which the generated buffer object names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static void GenBuffers(Int32 n, [OutAttribute] out UInt32 buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of buffer object names to be generated.
        /// </param>
        /// <param name="buffers">[length: n] 
        /// Specifies an array in which the generated buffer object names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenBuffers")]
        [CLSCompliant(false)]
        public static unsafe void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static void GenTexture(Int32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static void GenTexture(UInt32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of texture names to be generated.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static void GenTextures(Int32 n, Int32[] textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of texture names to be generated.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static void GenTextures(Int32 n, ref Int32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of texture names to be generated.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static unsafe void GenTextures(Int32 n, Int32* textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of texture names to be generated.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static void GenTextures(Int32 n, UInt32[] textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of texture names to be generated.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static void GenTextures(Int32 n, ref UInt32 textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n"> 
        /// Specifies the number of texture names to be generated.
        /// </param>
        /// <param name="textures">[length: n] 
        /// Specifies an array in which the generated texture names are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGenTextures")]
        [CLSCompliant(false)]
        public static unsafe void GenTextures(Int32 n, UInt32* textures) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static bool GetBoolean(OpenTK.Graphics.ES10.All pname) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static bool GetBoolean(OpenTK.Graphics.ES10.GetPName pname) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static void GetBoolean(OpenTK.Graphics.ES10.All pname, [OutAttribute] bool[] data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static void GetBoolean(OpenTK.Graphics.ES10.All pname, [OutAttribute] out bool data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static unsafe void GetBoolean(OpenTK.Graphics.ES10.All pname, [OutAttribute] bool* data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static void GetBoolean(OpenTK.Graphics.ES10.GetPName pname, [OutAttribute] bool[] data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static void GetBoolean(OpenTK.Graphics.ES10.GetPName pname, [OutAttribute] out bool data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBooleanv")]
        [CLSCompliant(false)]
        public static unsafe void GetBoolean(OpenTK.Graphics.ES10.GetPName pname, [OutAttribute] bool* data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferSize or BufferUsage.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBufferParameteriv")]
        [CLSCompliant(false)]
        public static void GetBufferParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferSize or BufferUsage.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBufferParameteriv")]
        [CLSCompliant(false)]
        public static void GetBufferParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferSize or BufferUsage.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBufferParameteriv")]
        [CLSCompliant(false)]
        public static unsafe void GetBufferParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferSize or BufferUsage.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBufferParameteriv")]
        [CLSCompliant(false)]
        public static void GetBufferParameter(OpenTK.Graphics.ES10.BufferTarget target, OpenTK.Graphics.ES10.BufferParameterName pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferSize or BufferUsage.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBufferParameteriv")]
        [CLSCompliant(false)]
        public static void GetBufferParameter(OpenTK.Graphics.ES10.BufferTarget target, OpenTK.Graphics.ES10.BufferParameterName pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target buffer object. The symbolic constant must be ArrayBuffer or ElementArrayBuffer.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are BufferSize or BufferUsage.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested parameter.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetBufferParameteriv")]
        [CLSCompliant(false)]
        public static unsafe void GetBufferParameter(OpenTK.Graphics.ES10.BufferTarget target, OpenTK.Graphics.ES10.BufferParameterName pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the coefficients of the specified clipping plane
        /// </summary>
        /// <param name="plane"> 
        /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form ClipPlane i where i ranges from 0 to the value of MaxClipPlanes - 1.
        /// </param>
        /// <param name="equation">[length: 4] 
        /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanef")]
        [CLSCompliant(false)]
        public static void GetClipPlane(OpenTK.Graphics.ES10.All plane, [OutAttribute] Single[] equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the coefficients of the specified clipping plane
        /// </summary>
        /// <param name="plane"> 
        /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form ClipPlane i where i ranges from 0 to the value of MaxClipPlanes - 1.
        /// </param>
        /// <param name="equation">[length: 4] 
        /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanef")]
        [CLSCompliant(false)]
        public static void GetClipPlane(OpenTK.Graphics.ES10.All plane, [OutAttribute] out Single equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the coefficients of the specified clipping plane
        /// </summary>
        /// <param name="plane"> 
        /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form ClipPlane i where i ranges from 0 to the value of MaxClipPlanes - 1.
        /// </param>
        /// <param name="equation">[length: 4] 
        /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanef")]
        [CLSCompliant(false)]
        public static unsafe void GetClipPlane(OpenTK.Graphics.ES10.All plane, [OutAttribute] Single* equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="plane"></param>
        /// <param name="equation">[length: 4]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        [CLSCompliant(false)]
        public static void GetClipPlanex(OpenTK.Graphics.ES10.All plane, [OutAttribute] int[] equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="plane"></param>
        /// <param name="equation">[length: 4]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        [CLSCompliant(false)]
        public static void GetClipPlanex(OpenTK.Graphics.ES10.All plane, [OutAttribute] out int equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="plane"></param>
        /// <param name="equation">[length: 4]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetClipPlanex")]
        [CLSCompliant(false)]
        public static unsafe void GetClipPlanex(OpenTK.Graphics.ES10.All plane, [OutAttribute] int* equation) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="num"></param>
        /// <param name="size"></param>
        /// <param name="driverControls">[length: size]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glGetDriverControlsQCOM")]
        [CLSCompliant(false)]
        public static void GetDriverControlsQCOM([OutAttribute] Int32[] num, Int32 size, [OutAttribute] Int32[] driverControls) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="num"></param>
        /// <param name="size"></param>
        /// <param name="driverControls">[length: size]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glGetDriverControlsQCOM")]
        [CLSCompliant(false)]
        public static void GetDriverControlsQCOM([OutAttribute] Int32[] num, Int32 size, [OutAttribute] UInt32[] driverControls) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="num"></param>
        /// <param name="size"></param>
        /// <param name="driverControls">[length: size]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glGetDriverControlsQCOM")]
        [CLSCompliant(false)]
        public static void GetDriverControlsQCOM([OutAttribute] out Int32 num, Int32 size, [OutAttribute] out Int32 driverControls) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="num"></param>
        /// <param name="size"></param>
        /// <param name="driverControls">[length: size]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glGetDriverControlsQCOM")]
        [CLSCompliant(false)]
        public static void GetDriverControlsQCOM([OutAttribute] out Int32 num, Int32 size, [OutAttribute] out UInt32 driverControls) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="num"></param>
        /// <param name="size"></param>
        /// <param name="driverControls">[length: size]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glGetDriverControlsQCOM")]
        [CLSCompliant(false)]
        public static unsafe void GetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] Int32* driverControls) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="num"></param>
        /// <param name="size"></param>
        /// <param name="driverControls">[length: size]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glGetDriverControlsQCOM")]
        [CLSCompliant(false)]
        public static unsafe void GetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="driverControl"></param>
        /// <param name="bufSize"></param>
        /// <param name="length"></param>
        /// <param name="driverControlString">[length: bufSize]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glGetDriverControlStringQCOM")]
        [CLSCompliant(false)]
        public static void GetDriverControlStringQCOM(Int32 driverControl, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] StringBuilder driverControlString) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="driverControl"></param>
        /// <param name="bufSize"></param>
        /// <param name="length"></param>
        /// <param name="driverControlString">[length: bufSize]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glGetDriverControlStringQCOM")]
        [CLSCompliant(false)]
        public static void GetDriverControlStringQCOM(Int32 driverControl, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder driverControlString) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="driverControl"></param>
        /// <param name="bufSize"></param>
        /// <param name="length"></param>
        /// <param name="driverControlString">[length: bufSize]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glGetDriverControlStringQCOM")]
        [CLSCompliant(false)]
        public static unsafe void GetDriverControlStringQCOM(Int32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="driverControl"></param>
        /// <param name="bufSize"></param>
        /// <param name="length"></param>
        /// <param name="driverControlString">[length: bufSize]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glGetDriverControlStringQCOM")]
        [CLSCompliant(false)]
        public static void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] StringBuilder driverControlString) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="driverControl"></param>
        /// <param name="bufSize"></param>
        /// <param name="length"></param>
        /// <param name="driverControlString">[length: bufSize]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glGetDriverControlStringQCOM")]
        [CLSCompliant(false)]
        public static void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder driverControlString) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_driver_control]</summary>
        /// <param name="driverControl"></param>
        /// <param name="bufSize"></param>
        /// <param name="length"></param>
        /// <param name="driverControlString">[length: bufSize]</param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_driver_control", Version = "1.0", EntryPoint = "glGetDriverControlStringQCOM")]
        [CLSCompliant(false)]
        public static unsafe void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return error information
        /// </summary>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetError")]
        public static OpenTK.Graphics.ES10.All GetError() { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        [CLSCompliant(false)]
        public static int GetFixed(OpenTK.Graphics.ES10.All pname) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        [CLSCompliant(false)]
        public static void GetFixed(OpenTK.Graphics.ES10.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        [CLSCompliant(false)]
        public static void GetFixed(OpenTK.Graphics.ES10.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFixedv")]
        [CLSCompliant(false)]
        public static unsafe void GetFixed(OpenTK.Graphics.ES10.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static Single GetFloat(OpenTK.Graphics.ES10.All pname) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static Single GetFloat(OpenTK.Graphics.ES10.GetPName pname) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static void GetFloat(OpenTK.Graphics.ES10.All pname, [OutAttribute] Single[] data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static void GetFloat(OpenTK.Graphics.ES10.All pname, [OutAttribute] out Single data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static unsafe void GetFloat(OpenTK.Graphics.ES10.All pname, [OutAttribute] Single* data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static void GetFloat(OpenTK.Graphics.ES10.GetPName pname, [OutAttribute] Single[] data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static void GetFloat(OpenTK.Graphics.ES10.GetPName pname, [OutAttribute] out Single data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetFloatv")]
        [CLSCompliant(false)]
        public static unsafe void GetFloat(OpenTK.Graphics.ES10.GetPName pname, [OutAttribute] Single* data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="data">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static void GetInteger(Int32 data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static void GetInteger(OpenTK.Graphics.ES10.All pname, Int32[] data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static void GetInteger(OpenTK.Graphics.ES10.All pname, ref Int32 data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static unsafe void GetInteger(OpenTK.Graphics.ES10.All pname, Int32* data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static void GetInteger(OpenTK.Graphics.ES10.GetPName pname, Int32[] data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static void GetInteger(OpenTK.Graphics.ES10.GetPName pname, ref Int32 data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="data">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetIntegerv")]
        [CLSCompliant(false)]
        public static unsafe void GetInteger(OpenTK.Graphics.ES10.GetPName pname, Int32* data) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light"> 
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light i where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname"> 
        /// Specifies a light source parameter for light. Accepted symbolic names are Ambient, Diffuse, Specular, Position, SpotDirection, SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        [CLSCompliant(false)]
        public static void GetLight(OpenTK.Graphics.ES10.All light, OpenTK.Graphics.ES10.All pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light"> 
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light i where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname"> 
        /// Specifies a light source parameter for light. Accepted symbolic names are Ambient, Diffuse, Specular, Position, SpotDirection, SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        [CLSCompliant(false)]
        public static void GetLight(OpenTK.Graphics.ES10.All light, OpenTK.Graphics.ES10.All pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light"> 
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light i where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname"> 
        /// Specifies a light source parameter for light. Accepted symbolic names are Ambient, Diffuse, Specular, Position, SpotDirection, SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        [CLSCompliant(false)]
        public static unsafe void GetLight(OpenTK.Graphics.ES10.All light, OpenTK.Graphics.ES10.All pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light"> 
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light i where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname"> 
        /// Specifies a light source parameter for light. Accepted symbolic names are Ambient, Diffuse, Specular, Position, SpotDirection, SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        [CLSCompliant(false)]
        public static void GetLight(OpenTK.Graphics.ES10.LightName light, OpenTK.Graphics.ES10.LightParameter pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light"> 
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light i where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname"> 
        /// Specifies a light source parameter for light. Accepted symbolic names are Ambient, Diffuse, Specular, Position, SpotDirection, SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        [CLSCompliant(false)]
        public static void GetLight(OpenTK.Graphics.ES10.LightName light, OpenTK.Graphics.ES10.LightParameter pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light"> 
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light i where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname"> 
        /// Specifies a light source parameter for light. Accepted symbolic names are Ambient, Diffuse, Specular, Position, SpotDirection, SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightfv")]
        [CLSCompliant(false)]
        public static unsafe void GetLight(OpenTK.Graphics.ES10.LightName light, OpenTK.Graphics.ES10.LightParameter pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="light"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightxv")]
        [CLSCompliant(false)]
        public static void GetLightx(OpenTK.Graphics.ES10.All light, OpenTK.Graphics.ES10.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="light"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightxv")]
        [CLSCompliant(false)]
        public static void GetLightx(OpenTK.Graphics.ES10.All light, OpenTK.Graphics.ES10.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="light"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetLightxv")]
        [CLSCompliant(false)]
        public static unsafe void GetLightx(OpenTK.Graphics.ES10.All light, OpenTK.Graphics.ES10.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face"> 
        /// Specifies which of the two materials is being queried. Front or Back are accepted, representing the front and back materials, respectively.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the material parameter to return. Ambient, Diffuse, Specular, Emission, Shininess, and ColorIndexes are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        [CLSCompliant(false)]
        public static void GetMaterial(OpenTK.Graphics.ES10.All face, OpenTK.Graphics.ES10.All pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face"> 
        /// Specifies which of the two materials is being queried. Front or Back are accepted, representing the front and back materials, respectively.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the material parameter to return. Ambient, Diffuse, Specular, Emission, Shininess, and ColorIndexes are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        [CLSCompliant(false)]
        public static void GetMaterial(OpenTK.Graphics.ES10.All face, OpenTK.Graphics.ES10.All pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face"> 
        /// Specifies which of the two materials is being queried. Front or Back are accepted, representing the front and back materials, respectively.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the material parameter to return. Ambient, Diffuse, Specular, Emission, Shininess, and ColorIndexes are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        [CLSCompliant(false)]
        public static unsafe void GetMaterial(OpenTK.Graphics.ES10.All face, OpenTK.Graphics.ES10.All pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face"> 
        /// Specifies which of the two materials is being queried. Front or Back are accepted, representing the front and back materials, respectively.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the material parameter to return. Ambient, Diffuse, Specular, Emission, Shininess, and ColorIndexes are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        [CLSCompliant(false)]
        public static void GetMaterial(OpenTK.Graphics.ES10.MaterialFace face, OpenTK.Graphics.ES10.MaterialParameter pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face"> 
        /// Specifies which of the two materials is being queried. Front or Back are accepted, representing the front and back materials, respectively.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the material parameter to return. Ambient, Diffuse, Specular, Emission, Shininess, and ColorIndexes are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        [CLSCompliant(false)]
        public static void GetMaterial(OpenTK.Graphics.ES10.MaterialFace face, OpenTK.Graphics.ES10.MaterialParameter pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face"> 
        /// Specifies which of the two materials is being queried. Front or Back are accepted, representing the front and back materials, respectively.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the material parameter to return. Ambient, Diffuse, Specular, Emission, Shininess, and ColorIndexes are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialfv")]
        [CLSCompliant(false)]
        public static unsafe void GetMaterial(OpenTK.Graphics.ES10.MaterialFace face, OpenTK.Graphics.ES10.MaterialParameter pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="face"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialxv")]
        [CLSCompliant(false)]
        public static void GetMaterialx(OpenTK.Graphics.ES10.All face, OpenTK.Graphics.ES10.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="face"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialxv")]
        [CLSCompliant(false)]
        public static void GetMaterialx(OpenTK.Graphics.ES10.All face, OpenTK.Graphics.ES10.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="face"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetMaterialxv")]
        [CLSCompliant(false)]
        public static unsafe void GetMaterialx(OpenTK.Graphics.ES10.All face, OpenTK.Graphics.ES10.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or OES_fixed_point]</summary>
        /// <param name="map"></param>
        /// <param name="size"></param>
        /// <param name="values">[length: size]</param>
        [AutoGenerated(Category = "OES_fixed_point", Version = "1.0", EntryPoint = "glGetPixelMapxv")]
        [CLSCompliant(false)]
        public static void GetPixelMapx(OpenTK.Graphics.ES10.All map, Int32 size, [OutAttribute] int[] values) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or OES_fixed_point]</summary>
        /// <param name="map"></param>
        /// <param name="size"></param>
        /// <param name="values">[length: size]</param>
        [AutoGenerated(Category = "OES_fixed_point", Version = "1.0", EntryPoint = "glGetPixelMapxv")]
        [CLSCompliant(false)]
        public static void GetPixelMapx(OpenTK.Graphics.ES10.All map, Int32 size, [OutAttribute] out int values) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or OES_fixed_point]</summary>
        /// <param name="map"></param>
        /// <param name="size"></param>
        /// <param name="values">[length: size]</param>
        [AutoGenerated(Category = "OES_fixed_point", Version = "1.0", EntryPoint = "glGetPixelMapxv")]
        [CLSCompliant(false)]
        public static unsafe void GetPixelMapx(OpenTK.Graphics.ES10.All map, Int32 size, [OutAttribute] int* values) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the array or buffer pointer to be returned. Symbolic constants ColorArrayPointer, EdgeFlagArrayPointer, FogCoordArrayPointer, FeedbackBufferPointer, IndexArrayPointer, NormalArrayPointer, SecondaryColorArrayPointer, SelectionBufferPointer, TextureCoordArrayPointer, or VertexArrayPointer are accepted.
        /// </param>
        /// <param name="params">[length: 1] 
        /// Returns the pointer value specified by pname.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        public static void GetPointer(OpenTK.Graphics.ES10.All pname, [OutAttribute] IntPtr @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the array or buffer pointer to be returned. Symbolic constants ColorArrayPointer, EdgeFlagArrayPointer, FogCoordArrayPointer, FeedbackBufferPointer, IndexArrayPointer, NormalArrayPointer, SecondaryColorArrayPointer, SelectionBufferPointer, TextureCoordArrayPointer, or VertexArrayPointer are accepted.
        /// </param>
        /// <param name="params">[length: 1] 
        /// Returns the pointer value specified by pname.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        [CLSCompliant(false)]
        public static void GetPointer<T1>(OpenTK.Graphics.ES10.All pname, [InAttribute, OutAttribute] T1[] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the array or buffer pointer to be returned. Symbolic constants ColorArrayPointer, EdgeFlagArrayPointer, FogCoordArrayPointer, FeedbackBufferPointer, IndexArrayPointer, NormalArrayPointer, SecondaryColorArrayPointer, SelectionBufferPointer, TextureCoordArrayPointer, or VertexArrayPointer are accepted.
        /// </param>
        /// <param name="params">[length: 1] 
        /// Returns the pointer value specified by pname.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        [CLSCompliant(false)]
        public static void GetPointer<T1>(OpenTK.Graphics.ES10.All pname, [InAttribute, OutAttribute] T1[,] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the array or buffer pointer to be returned. Symbolic constants ColorArrayPointer, EdgeFlagArrayPointer, FogCoordArrayPointer, FeedbackBufferPointer, IndexArrayPointer, NormalArrayPointer, SecondaryColorArrayPointer, SelectionBufferPointer, TextureCoordArrayPointer, or VertexArrayPointer are accepted.
        /// </param>
        /// <param name="params">[length: 1] 
        /// Returns the pointer value specified by pname.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        [CLSCompliant(false)]
        public static void GetPointer<T1>(OpenTK.Graphics.ES10.All pname, [InAttribute, OutAttribute] T1[,,] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the array or buffer pointer to be returned. Symbolic constants ColorArrayPointer, EdgeFlagArrayPointer, FogCoordArrayPointer, FeedbackBufferPointer, IndexArrayPointer, NormalArrayPointer, SecondaryColorArrayPointer, SelectionBufferPointer, TextureCoordArrayPointer, or VertexArrayPointer are accepted.
        /// </param>
        /// <param name="params">[length: 1] 
        /// Returns the pointer value specified by pname.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        public static void GetPointer<T1>(OpenTK.Graphics.ES10.All pname, [InAttribute, OutAttribute] ref T1 @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the array or buffer pointer to be returned. Symbolic constants ColorArrayPointer, EdgeFlagArrayPointer, FogCoordArrayPointer, FeedbackBufferPointer, IndexArrayPointer, NormalArrayPointer, SecondaryColorArrayPointer, SelectionBufferPointer, TextureCoordArrayPointer, or VertexArrayPointer are accepted.
        /// </param>
        /// <param name="params">[length: 1] 
        /// Returns the pointer value specified by pname.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        public static void GetPointer(OpenTK.Graphics.ES10.GetPointervPName pname, [OutAttribute] IntPtr @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the array or buffer pointer to be returned. Symbolic constants ColorArrayPointer, EdgeFlagArrayPointer, FogCoordArrayPointer, FeedbackBufferPointer, IndexArrayPointer, NormalArrayPointer, SecondaryColorArrayPointer, SelectionBufferPointer, TextureCoordArrayPointer, or VertexArrayPointer are accepted.
        /// </param>
        /// <param name="params">[length: 1] 
        /// Returns the pointer value specified by pname.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        [CLSCompliant(false)]
        public static void GetPointer<T1>(OpenTK.Graphics.ES10.GetPointervPName pname, [InAttribute, OutAttribute] T1[] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the array or buffer pointer to be returned. Symbolic constants ColorArrayPointer, EdgeFlagArrayPointer, FogCoordArrayPointer, FeedbackBufferPointer, IndexArrayPointer, NormalArrayPointer, SecondaryColorArrayPointer, SelectionBufferPointer, TextureCoordArrayPointer, or VertexArrayPointer are accepted.
        /// </param>
        /// <param name="params">[length: 1] 
        /// Returns the pointer value specified by pname.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        [CLSCompliant(false)]
        public static void GetPointer<T1>(OpenTK.Graphics.ES10.GetPointervPName pname, [InAttribute, OutAttribute] T1[,] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the array or buffer pointer to be returned. Symbolic constants ColorArrayPointer, EdgeFlagArrayPointer, FogCoordArrayPointer, FeedbackBufferPointer, IndexArrayPointer, NormalArrayPointer, SecondaryColorArrayPointer, SelectionBufferPointer, TextureCoordArrayPointer, or VertexArrayPointer are accepted.
        /// </param>
        /// <param name="params">[length: 1] 
        /// Returns the pointer value specified by pname.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        [CLSCompliant(false)]
        public static void GetPointer<T1>(OpenTK.Graphics.ES10.GetPointervPName pname, [InAttribute, OutAttribute] T1[,,] @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the array or buffer pointer to be returned. Symbolic constants ColorArrayPointer, EdgeFlagArrayPointer, FogCoordArrayPointer, FeedbackBufferPointer, IndexArrayPointer, NormalArrayPointer, SecondaryColorArrayPointer, SelectionBufferPointer, TextureCoordArrayPointer, or VertexArrayPointer are accepted.
        /// </param>
        /// <param name="params">[length: 1] 
        /// Returns the pointer value specified by pname.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetPointerv")]
        public static void GetPointer<T1>(OpenTK.Graphics.ES10.GetPointervPName pname, [InAttribute, OutAttribute] ref T1 @params)
            where T1 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return a string describing the current GL connection
        /// </summary>
        /// <param name="name"> 
        /// Specifies a symbolic constant, one of Vendor, Renderer, Version, ShadingLanguageVersion, or Extensions.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetString")]
        public static String GetString(OpenTK.Graphics.ES10.All name) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return a string describing the current GL connection
        /// </summary>
        /// <param name="name"> 
        /// Specifies a symbolic constant, one of Vendor, Renderer, Version, ShadingLanguageVersion, or Extensions.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetString")]
        public static String GetString(OpenTK.Graphics.ES10.StringName name) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl, or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are TextureEnvMode, TextureEnvColor, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl, or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are TextureEnvMode, TextureEnvColor, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl, or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are TextureEnvMode, TextureEnvColor, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexEnv(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl, or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are TextureEnvMode, TextureEnvColor, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES10.TextureEnvTarget target, OpenTK.Graphics.ES10.TextureEnvParameter pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl, or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are TextureEnvMode, TextureEnvColor, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES10.TextureEnvTarget target, OpenTK.Graphics.ES10.TextureEnvParameter pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl, or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are TextureEnvMode, TextureEnvColor, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvfv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexEnv(OpenTK.Graphics.ES10.TextureEnvTarget target, OpenTK.Graphics.ES10.TextureEnvParameter pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl, or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are TextureEnvMode, TextureEnvColor, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl, or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are TextureEnvMode, TextureEnvColor, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl, or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are TextureEnvMode, TextureEnvColor, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexEnv(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl, or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are TextureEnvMode, TextureEnvColor, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES10.TextureEnvTarget target, OpenTK.Graphics.ES10.TextureEnvParameter pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl, or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are TextureEnvMode, TextureEnvColor, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        [CLSCompliant(false)]
        public static void GetTexEnv(OpenTK.Graphics.ES10.TextureEnvTarget target, OpenTK.Graphics.ES10.TextureEnvParameter pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl, or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are TextureEnvMode, TextureEnvColor, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the requested data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnviv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexEnv(OpenTK.Graphics.ES10.TextureEnvTarget target, OpenTK.Graphics.ES10.TextureEnvParameter pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvxv")]
        [CLSCompliant(false)]
        public static void GetTexEnvx(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvxv")]
        [CLSCompliant(false)]
        public static void GetTexEnvx(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexEnvxv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexEnvx(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES10.TextureTarget target, OpenTK.Graphics.ES10.GetTextureParameter pname, [OutAttribute] Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES10.TextureTarget target, OpenTK.Graphics.ES10.GetTextureParameter pname, [OutAttribute] out Single @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterfv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexParameter(OpenTK.Graphics.ES10.TextureTarget target, OpenTK.Graphics.ES10.GetTextureParameter pname, [OutAttribute] Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES10.TextureTarget target, OpenTK.Graphics.ES10.GetTextureParameter pname, [OutAttribute] Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        [CLSCompliant(false)]
        public static void GetTexParameter(OpenTK.Graphics.ES10.TextureTarget target, OpenTK.Graphics.ES10.GetTextureParameter pname, [OutAttribute] out Int32 @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target"> 
        /// Specifies the symbolic name of the target texture of the active texture unit. Texture2D and TextureCubeMap are accepted.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a texture parameter. TextureMagFilter, TextureMinFilter, TextureWrapS, and TextureWrapT are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Returns the texture parameter.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameteriv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexParameter(OpenTK.Graphics.ES10.TextureTarget target, OpenTK.Graphics.ES10.GetTextureParameter pname, [OutAttribute] Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterxv")]
        [CLSCompliant(false)]
        public static void GetTexParameterx(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterxv")]
        [CLSCompliant(false)]
        public static void GetTexParameterx(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] out int @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glGetTexParameterxv")]
        [CLSCompliant(false)]
        public static unsafe void GetTexParameterx(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, [OutAttribute] int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify implementation-specific hints
        /// </summary>
        /// <param name="target"> 
        /// Specifies a symbolic constant indicating the behavior to be controlled. GenerateMipmapHint is accepted.
        /// </param>
        /// <param name="mode"> 
        /// Specifies a symbolic constant indicating the desired behavior. Fastest, Nicest, and DontCare are accepted.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glHint")]
        public static void Hint(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify implementation-specific hints
        /// </summary>
        /// <param name="target"> 
        /// Specifies a symbolic constant indicating the behavior to be controlled. GenerateMipmapHint is accepted.
        /// </param>
        /// <param name="mode"> 
        /// Specifies a symbolic constant indicating the desired behavior. Fastest, Nicest, and DontCare are accepted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glHint")]
        public static void Hint(OpenTK.Graphics.ES10.HintTarget target, OpenTK.Graphics.ES10.HintMode mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a buffer object
        /// </summary>
        /// <param name="buffer"> 
        /// Specifies a value that may be the name of a buffer object.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsBuffer")]
        [CLSCompliant(false)]
        public static bool IsBuffer(Int32 buffer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a buffer object
        /// </summary>
        /// <param name="buffer"> 
        /// Specifies a value that may be the name of a buffer object.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsBuffer")]
        [CLSCompliant(false)]
        public static bool IsBuffer(UInt32 buffer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Test whether a capability is enabled
        /// </summary>
        /// <param name="cap"> 
        /// Specifies a symbolic constant indicating a GL capability.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsEnabled")]
        public static bool IsEnabled(OpenTK.Graphics.ES10.All cap) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Test whether a capability is enabled
        /// </summary>
        /// <param name="cap"> 
        /// Specifies a symbolic constant indicating a GL capability.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsEnabled")]
        public static bool IsEnabled(OpenTK.Graphics.ES10.EnableCap cap) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a texture
        /// </summary>
        /// <param name="texture"> 
        /// Specifies a value that may be the name of a texture.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsTexture")]
        [CLSCompliant(false)]
        public static bool IsTexture(Int32 texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a texture
        /// </summary>
        /// <param name="texture"> 
        /// Specifies a value that may be the name of a texture.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glIsTexture")]
        [CLSCompliant(false)]
        public static bool IsTexture(UInt32 texture) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light"> 
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light i, where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname"> 
        /// Specifies a single-valued light source parameter for light. SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation are accepted.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value that parameter pname of light source light will be set to.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightf")]
        public static void Light(OpenTK.Graphics.ES10.All light, OpenTK.Graphics.ES10.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light"> 
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light i, where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname"> 
        /// Specifies a single-valued light source parameter for light. SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation are accepted.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value that parameter pname of light source light will be set to.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightf")]
        public static void Light(OpenTK.Graphics.ES10.LightName light, OpenTK.Graphics.ES10.LightParameter pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light"> 
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light i, where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname"> 
        /// Specifies a single-valued light source parameter for light. SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to the value or values that parameter pname of light source light will be set to.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightfv")]
        [CLSCompliant(false)]
        public static void Light(OpenTK.Graphics.ES10.All light, OpenTK.Graphics.ES10.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light"> 
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light i, where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname"> 
        /// Specifies a single-valued light source parameter for light. SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to the value or values that parameter pname of light source light will be set to.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightfv")]
        [CLSCompliant(false)]
        public static unsafe void Light(OpenTK.Graphics.ES10.All light, OpenTK.Graphics.ES10.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light"> 
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light i, where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname"> 
        /// Specifies a single-valued light source parameter for light. SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to the value or values that parameter pname of light source light will be set to.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightfv")]
        [CLSCompliant(false)]
        public static void Light(OpenTK.Graphics.ES10.LightName light, OpenTK.Graphics.ES10.LightParameter pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light"> 
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light i, where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname"> 
        /// Specifies a single-valued light source parameter for light. SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to the value or values that parameter pname of light source light will be set to.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightfv")]
        [CLSCompliant(false)]
        public static unsafe void Light(OpenTK.Graphics.ES10.LightName light, OpenTK.Graphics.ES10.LightParameter pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued lighting model parameter. LightModelLocalViewer, LightModelColorControl, and LightModelTwoSide are accepted.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value that param will be set to.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelf")]
        public static void LightModel(OpenTK.Graphics.ES10.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued lighting model parameter. LightModelLocalViewer, LightModelColorControl, and LightModelTwoSide are accepted.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value that param will be set to.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelf")]
        public static void LightModel(OpenTK.Graphics.ES10.LightModelParameter pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued lighting model parameter. LightModelLocalViewer, LightModelColorControl, and LightModelTwoSide are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to the value or values that params will be set to.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelfv")]
        [CLSCompliant(false)]
        public static void LightModel(OpenTK.Graphics.ES10.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued lighting model parameter. LightModelLocalViewer, LightModelColorControl, and LightModelTwoSide are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to the value or values that params will be set to.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelfv")]
        [CLSCompliant(false)]
        public static unsafe void LightModel(OpenTK.Graphics.ES10.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued lighting model parameter. LightModelLocalViewer, LightModelColorControl, and LightModelTwoSide are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to the value or values that params will be set to.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelfv")]
        [CLSCompliant(false)]
        public static void LightModel(OpenTK.Graphics.ES10.LightModelParameter pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued lighting model parameter. LightModelLocalViewer, LightModelColorControl, and LightModelTwoSide are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to the value or values that params will be set to.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelfv")]
        [CLSCompliant(false)]
        public static unsafe void LightModel(OpenTK.Graphics.ES10.LightModelParameter pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelx")]
        public static void LightModelx(OpenTK.Graphics.ES10.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="param">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelxv")]
        [CLSCompliant(false)]
        public static void LightModelx(OpenTK.Graphics.ES10.All pname, int[] param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="param">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightModelxv")]
        [CLSCompliant(false)]
        public static unsafe void LightModelx(OpenTK.Graphics.ES10.All pname, int* param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="light"></param>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightx")]
        public static void Lightx(OpenTK.Graphics.ES10.All light, OpenTK.Graphics.ES10.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="light"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightxv")]
        [CLSCompliant(false)]
        public static void Lightx(OpenTK.Graphics.ES10.All light, OpenTK.Graphics.ES10.All pname, int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="light"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLightxv")]
        [CLSCompliant(false)]
        public static unsafe void Lightx(OpenTK.Graphics.ES10.All light, OpenTK.Graphics.ES10.All pname, int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the width of rasterized lines
        /// </summary>
        /// <param name="width"> 
        /// Specifies the width of rasterized lines. The initial value is 1.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLineWidth")]
        public static void LineWidth(Single width) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="width"></param>
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
        /// <param name="m">[length: 16] 
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4  times  4 column-major matrix.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixf")]
        [CLSCompliant(false)]
        public static void LoadMatrix(Single[] m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">[length: 16] 
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4  times  4 column-major matrix.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixf")]
        [CLSCompliant(false)]
        public static void LoadMatrix(ref Single m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">[length: 16] 
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4  times  4 column-major matrix.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixf")]
        [CLSCompliant(false)]
        public static unsafe void LoadMatrix(Single* m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="m">[length: 16]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixx")]
        [CLSCompliant(false)]
        public static void LoadMatrixx(int[] m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="m">[length: 16]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixx")]
        [CLSCompliant(false)]
        public static void LoadMatrixx(ref int m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="m">[length: 16]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLoadMatrixx")]
        [CLSCompliant(false)]
        public static unsafe void LoadMatrixx(int* m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a logical pixel operation for rendering
        /// </summary>
        /// <param name="opcode"> 
        /// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: Clear, Set, Copy, CopyInverted, Noop, Invert, And, Nand, Or, Nor, Xor, Equiv, AndReverse, AndInverted, OrReverse, and OrInverted. The initial value is Copy.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLogicOp")]
        public static void LogicOp(OpenTK.Graphics.ES10.All opcode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a logical pixel operation for rendering
        /// </summary>
        /// <param name="opcode"> 
        /// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: Clear, Set, Copy, CopyInverted, Noop, Invert, And, Nand, Or, Nor, Xor, Equiv, AndReverse, AndInverted, OrReverse, and OrInverted. The initial value is Copy.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glLogicOp")]
        public static void LogicOp(OpenTK.Graphics.ES10.LogicOp opcode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face"> 
        /// Specifies which face or faces are being updated. Must be one of Front, Back, or FrontAndBack.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Shininess.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value that parameter Shininess will be set to.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialf")]
        public static void Material(OpenTK.Graphics.ES10.All face, OpenTK.Graphics.ES10.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face"> 
        /// Specifies which face or faces are being updated. Must be one of Front, Back, or FrontAndBack.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Shininess.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value that parameter Shininess will be set to.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialf")]
        public static void Material(OpenTK.Graphics.ES10.MaterialFace face, OpenTK.Graphics.ES10.MaterialParameter pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face"> 
        /// Specifies which face or faces are being updated. Must be one of Front, Back, or FrontAndBack.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Shininess.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to the value or values that pname will be set to.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialfv")]
        [CLSCompliant(false)]
        public static void Material(OpenTK.Graphics.ES10.All face, OpenTK.Graphics.ES10.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face"> 
        /// Specifies which face or faces are being updated. Must be one of Front, Back, or FrontAndBack.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Shininess.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to the value or values that pname will be set to.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialfv")]
        [CLSCompliant(false)]
        public static unsafe void Material(OpenTK.Graphics.ES10.All face, OpenTK.Graphics.ES10.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face"> 
        /// Specifies which face or faces are being updated. Must be one of Front, Back, or FrontAndBack.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Shininess.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to the value or values that pname will be set to.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialfv")]
        [CLSCompliant(false)]
        public static void Material(OpenTK.Graphics.ES10.MaterialFace face, OpenTK.Graphics.ES10.MaterialParameter pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face"> 
        /// Specifies which face or faces are being updated. Must be one of Front, Back, or FrontAndBack.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Shininess.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to the value or values that pname will be set to.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialfv")]
        [CLSCompliant(false)]
        public static unsafe void Material(OpenTK.Graphics.ES10.MaterialFace face, OpenTK.Graphics.ES10.MaterialParameter pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="face"></param>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialx")]
        public static void Materialx(OpenTK.Graphics.ES10.All face, OpenTK.Graphics.ES10.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="face"></param>
        /// <param name="pname"></param>
        /// <param name="param">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialxv")]
        [CLSCompliant(false)]
        public static void Materialx(OpenTK.Graphics.ES10.All face, OpenTK.Graphics.ES10.All pname, int[] param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="face"></param>
        /// <param name="pname"></param>
        /// <param name="param">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMaterialxv")]
        [CLSCompliant(false)]
        public static unsafe void Materialx(OpenTK.Graphics.ES10.All face, OpenTK.Graphics.ES10.All pname, int* param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify which matrix is the current matrix
        /// </summary>
        /// <param name="mode"> 
        /// Specifies which matrix stack is the target for subsequent matrix operations. Three values are accepted: Modelview, Projection, and Texture. The initial value is Modelview. Additionally, if the ARB_imaging extension is supported, Color is also accepted.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMatrixMode")]
        public static void MatrixMode(OpenTK.Graphics.ES10.All mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify which matrix is the current matrix
        /// </summary>
        /// <param name="mode"> 
        /// Specifies which matrix stack is the target for subsequent matrix operations. Three values are accepted: Modelview, Projection, and Texture. The initial value is Modelview. Additionally, if the ARB_imaging extension is supported, Color is also accepted.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMatrixMode")]
        public static void MatrixMode(OpenTK.Graphics.ES10.MatrixMode mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the current texture coordinates
        /// </summary>
        /// <param name="target"> 
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of Texturei, where i ranges from 0 to MaxTextureCoords - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s"> 
        /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t"> 
        /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r"> 
        /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="q"> 
        /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultiTexCoord4f")]
        public static void MultiTexCoord4(OpenTK.Graphics.ES10.All target, Single s, Single t, Single r, Single q) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the current texture coordinates
        /// </summary>
        /// <param name="target"> 
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of Texturei, where i ranges from 0 to MaxTextureCoords - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="s"> 
        /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t"> 
        /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r"> 
        /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="q"> 
        /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultiTexCoord4f")]
        public static void MultiTexCoord4(OpenTK.Graphics.ES10.TextureUnit target, Single s, Single t, Single r, Single q) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="texture"></param>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <param name="r"></param>
        /// <param name="q"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultiTexCoord4x")]
        public static void MultiTexCoord4x(OpenTK.Graphics.ES10.All texture, int s, int t, int r, int q) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">[length: 16] 
        /// Points to 16 consecutive values that are used as the elements of a 4  times  4 column-major matrix.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixf")]
        [CLSCompliant(false)]
        public static void MultMatrix(Single[] m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">[length: 16] 
        /// Points to 16 consecutive values that are used as the elements of a 4  times  4 column-major matrix.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixf")]
        [CLSCompliant(false)]
        public static void MultMatrix(ref Single m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">[length: 16] 
        /// Points to 16 consecutive values that are used as the elements of a 4  times  4 column-major matrix.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixf")]
        [CLSCompliant(false)]
        public static unsafe void MultMatrix(Single* m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="m">[length: 16]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixx")]
        [CLSCompliant(false)]
        public static void MultMatrixx(int[] m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="m">[length: 16]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixx")]
        [CLSCompliant(false)]
        public static void MultMatrixx(ref int m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="m">[length: 16]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glMultMatrixx")]
        [CLSCompliant(false)]
        public static unsafe void MultMatrixx(int* m) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the current normal vector
        /// </summary>
        /// <param name="nx"> 
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit vector, (0, 0, 1).
        /// </param>
        /// <param name="ny"> 
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit vector, (0, 0, 1).
        /// </param>
        /// <param name="nz"> 
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit vector, (0, 0, 1).
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormal3f")]
        public static void Normal3(Single nx, Single ny, Single nz) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="nx"></param>
        /// <param name="ny"></param>
        /// <param name="nz"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormal3x")]
        public static void Normal3x(int nx, int ny, int nz) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Byte, Short, Int, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: type,stride] 
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        public static void NormalPointer(OpenTK.Graphics.ES10.All type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Byte, Short, Int, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: type,stride] 
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        [CLSCompliant(false)]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] T2[] pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Byte, Short, Int, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: type,stride] 
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        [CLSCompliant(false)]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] T2[,] pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Byte, Short, Int, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: type,stride] 
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        [CLSCompliant(false)]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] T2[,,] pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Byte, Short, Int, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: type,stride] 
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] ref T2 pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Byte, Short, Int, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: type,stride] 
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        public static void NormalPointer(OpenTK.Graphics.ES10.NormalPointerType type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Byte, Short, Int, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: type,stride] 
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        [CLSCompliant(false)]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES10.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[] pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Byte, Short, Int, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: type,stride] 
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        [CLSCompliant(false)]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES10.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[,] pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Byte, Short, Int, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: type,stride] 
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        [CLSCompliant(false)]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES10.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[,,] pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Byte, Short, Int, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: type,stride] 
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glNormalPointer")]
        public static void NormalPointer<T2>(OpenTK.Graphics.ES10.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T2 pointer)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with an orthographic matrix
        /// </summary>
        /// <param name="l"> 
        /// Specify the coordinates for the left and right vertical clipping planes.
        /// </param>
        /// <param name="r"> 
        /// Specify the coordinates for the left and right vertical clipping planes.
        /// </param>
        /// <param name="b"> 
        /// Specify the coordinates for the bottom and top horizontal clipping planes.
        /// </param>
        /// <param name="t"> 
        /// Specify the coordinates for the bottom and top horizontal clipping planes.
        /// </param>
        /// <param name="n"> 
        /// Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.
        /// </param>
        /// <param name="f"> 
        /// Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glOrthof")]
        public static void Ortho(Single l, Single r, Single b, Single t, Single n, Single f) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <param name="n"></param>
        /// <param name="f"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glOrthox")]
        public static void Orthox(int l, int r, int b, int t, int n, int f) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or OES_fixed_point]</summary>
        /// <param name="map"></param>
        /// <param name="size"></param>
        /// <param name="values">[length: size]</param>
        [AutoGenerated(Category = "OES_fixed_point", Version = "1.0", EntryPoint = "glPixelMapx")]
        [CLSCompliant(false)]
        public static void PixelMapx(OpenTK.Graphics.ES10.All map, Int32 size, int[] values) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or OES_fixed_point]</summary>
        /// <param name="map"></param>
        /// <param name="size"></param>
        /// <param name="values">[length: size]</param>
        [AutoGenerated(Category = "OES_fixed_point", Version = "1.0", EntryPoint = "glPixelMapx")]
        [CLSCompliant(false)]
        public static void PixelMapx(OpenTK.Graphics.ES10.All map, Int32 size, ref int values) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or OES_fixed_point]</summary>
        /// <param name="map"></param>
        /// <param name="size"></param>
        /// <param name="values">[length: size]</param>
        [AutoGenerated(Category = "OES_fixed_point", Version = "1.0", EntryPoint = "glPixelMapx")]
        [CLSCompliant(false)]
        public static unsafe void PixelMapx(OpenTK.Graphics.ES10.All map, Int32 size, int* values) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set pixel storage modes
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the parameter to be set. One value affects the packing of pixel data into memory: PackAlignment. The other affects the unpacking of pixel data from memory: UnpackAlignment.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value that pname is set to.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPixelStorei")]
        public static void PixelStore(OpenTK.Graphics.ES10.All pname, Int32 param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set pixel storage modes
        /// </summary>
        /// <param name="pname"> 
        /// Specifies the symbolic name of the parameter to be set. One value affects the packing of pixel data into memory: PackAlignment. The other affects the unpacking of pixel data from memory: UnpackAlignment.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value that pname is set to.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPixelStorei")]
        public static void PixelStore(OpenTK.Graphics.ES10.PixelStoreParameter pname, Int32 param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or OES_fixed_point]</summary>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        [AutoGenerated(Category = "OES_fixed_point", Version = "1.0", EntryPoint = "glPixelStorex")]
        public static void PixelStorex(OpenTK.Graphics.ES10.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify point parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued point parameter. PointFadeThresholdSize, and PointSpriteCoordOrigin are accepted.
        /// </param>
        /// <param name="param"> 
        /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterf")]
        public static void PointParameter(OpenTK.Graphics.ES10.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify point parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued point parameter. PointFadeThresholdSize, and PointSpriteCoordOrigin are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// For glPointParameterfv and glPointParameteriv, specifies a pointer to an array where the value or values to be assigned to pname are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterfv")]
        [CLSCompliant(false)]
        public static void PointParameter(OpenTK.Graphics.ES10.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify point parameters
        /// </summary>
        /// <param name="pname"> 
        /// Specifies a single-valued point parameter. PointFadeThresholdSize, and PointSpriteCoordOrigin are accepted.
        /// </param>
        /// <param name="params">[length: pname] 
        /// For glPointParameterfv and glPointParameteriv, specifies a pointer to an array where the value or values to be assigned to pname are stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterfv")]
        [CLSCompliant(false)]
        public static unsafe void PointParameter(OpenTK.Graphics.ES10.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterx")]
        public static void PointParameterx(OpenTK.Graphics.ES10.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterxv")]
        [CLSCompliant(false)]
        public static void PointParameterx(OpenTK.Graphics.ES10.All pname, int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointParameterxv")]
        [CLSCompliant(false)]
        public static unsafe void PointParameterx(OpenTK.Graphics.ES10.All pname, int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify the diameter of rasterized points
        /// </summary>
        /// <param name="size"> 
        /// Specifies the diameter of rasterized points. The initial value is 1.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointSize")]
        public static void PointSize(Single size) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="size"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPointSizex")]
        public static void PointSizex(int size) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the scale and units used to calculate depth values
        /// </summary>
        /// <param name="factor"> 
        /// Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0.
        /// </param>
        /// <param name="units"> 
        /// Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glPolygonOffset")]
        public static void PolygonOffset(Single factor, Single units) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="factor"></param>
        /// <param name="units"></param>
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
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="width"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="height"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, and Rgba.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. Must be one of UnsignedByte, UnsignedShort565, UnsignedShort4444, or UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Returns the pixel data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        public static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [OutAttribute] IntPtr pixels) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="width"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="height"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, and Rgba.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. Must be one of UnsignedByte, UnsignedShort565, UnsignedShort4444, or UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Returns the pixel data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        [CLSCompliant(false)]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T6[] pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="width"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="height"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, and Rgba.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. Must be one of UnsignedByte, UnsignedShort565, UnsignedShort4444, or UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Returns the pixel data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        [CLSCompliant(false)]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T6[,] pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="width"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="height"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, and Rgba.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. Must be one of UnsignedByte, UnsignedShort565, UnsignedShort4444, or UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Returns the pixel data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        [CLSCompliant(false)]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T6[,,] pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="width"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="height"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, and Rgba.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. Must be one of UnsignedByte, UnsignedShort565, UnsignedShort4444, or UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Returns the pixel data.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] ref T6 pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="width"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="height"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, and Rgba.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. Must be one of UnsignedByte, UnsignedShort565, UnsignedShort4444, or UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Returns the pixel data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        public static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, [OutAttribute] IntPtr pixels) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="width"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="height"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, and Rgba.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. Must be one of UnsignedByte, UnsignedShort565, UnsignedShort4444, or UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Returns the pixel data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        [CLSCompliant(false)]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, [InAttribute, OutAttribute] T6[] pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="width"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="height"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, and Rgba.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. Must be one of UnsignedByte, UnsignedShort565, UnsignedShort4444, or UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Returns the pixel data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        [CLSCompliant(false)]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, [InAttribute, OutAttribute] T6[,] pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="width"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="height"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, and Rgba.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. Must be one of UnsignedByte, UnsignedShort565, UnsignedShort4444, or UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Returns the pixel data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        [CLSCompliant(false)]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, [InAttribute, OutAttribute] T6[,,] pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="y"> 
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </param>
        /// <param name="width"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="height"> 
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, and Rgba.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. Must be one of UnsignedByte, UnsignedShort565, UnsignedShort4444, or UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Returns the pixel data.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glReadPixels")]
        public static void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, [InAttribute, OutAttribute] ref T6 pixels)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or IMG_multisampled_render_to_texture]</summary>
        /// <param name="target"></param>
        /// <param name="samples"></param>
        /// <param name="internalformat"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        [Obsolete("Use GL.Img instead")]
        [AutoGenerated(Category = "IMG_multisampled_render_to_texture", Version = "1.0", EntryPoint = "glRenderbufferStorageMultisampleIMG")]
        public static void RenderbufferStorageMultisampleIMG(OpenTK.Graphics.ES10.All target, Int32 samples, OpenTK.Graphics.ES10.All internalformat, Int32 width, Int32 height) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a rotation matrix
        /// </summary>
        /// <param name="angle"> 
        /// Specifies the angle of rotation, in degrees.
        /// </param>
        /// <param name="x"> 
        /// Specify the x, y, and z coordinates of a vector, respectively.
        /// </param>
        /// <param name="y"> 
        /// Specify the x, y, and z coordinates of a vector, respectively.
        /// </param>
        /// <param name="z"> 
        /// Specify the x, y, and z coordinates of a vector, respectively.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glRotatef")]
        public static void Rotate(Single angle, Single x, Single y, Single z) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="angle"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glRotatex")]
        public static void Rotatex(int angle, int x, int y, int z) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify multisample coverage parameters
        /// </summary>
        /// <param name="value"> 
        /// Specify a single floating-point sample coverage value.  The value is clamped to the range [0 ,1]. The initial value is 1.0.
        /// </param>
        /// <param name="invert"> 
        /// Specify a single boolean value representing if the coverage masks should be inverted.  True and False are accepted.  The initial value is False.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glSampleCoverage")]
        public static void SampleCoverage(Single value, bool invert) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="value"></param>
        /// <param name="invert"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glSampleCoveragex")]
        public static void SampleCoveragex(int value, bool invert) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a general scaling matrix
        /// </summary>
        /// <param name="x"> 
        /// Specify scale factors along the x, y, and z axes, respectively.
        /// </param>
        /// <param name="y"> 
        /// Specify scale factors along the x, y, and z axes, respectively.
        /// </param>
        /// <param name="z"> 
        /// Specify scale factors along the x, y, and z axes, respectively.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glScalef")]
        public static void Scale(Single x, Single y, Single z) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glScalex")]
        public static void Scalex(int x, int y, int z) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define the scissor box
        /// </summary>
        /// <param name="x"> 
        /// Specify the lower left corner of the scissor box. Initially (0, 0).
        /// </param>
        /// <param name="y"> 
        /// Specify the lower left corner of the scissor box. Initially (0, 0).
        /// </param>
        /// <param name="width"> 
        /// Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window.
        /// </param>
        /// <param name="height"> 
        /// Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glScissor")]
        public static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Select flat or smooth shading
        /// </summary>
        /// <param name="mode"> 
        /// Specifies a symbolic value representing a shading technique. Accepted values are Flat and Smooth. The initial value is Smooth.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glShadeModel")]
        public static void ShadeModel(OpenTK.Graphics.ES10.All mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Select flat or smooth shading
        /// </summary>
        /// <param name="mode"> 
        /// Specifies a symbolic value representing a shading technique. Accepted values are Flat and Smooth. The initial value is Smooth.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glShadeModel")]
        public static void ShadeModel(OpenTK.Graphics.ES10.ShadingModel mode) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_tiled_rendering]</summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="preserveMask"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "1.0", EntryPoint = "glStartTilingQCOM")]
        [CLSCompliant(false)]
        public static void StartTilingQCOM(Int32 x, Int32 y, Int32 width, Int32 height, Int32 preserveMask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0 or QCOM_tiled_rendering]</summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="preserveMask"></param>
        [Obsolete("Use GL.Qcom instead")]
        [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "1.0", EntryPoint = "glStartTilingQCOM")]
        [CLSCompliant(false)]
        public static void StartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where n is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilFunc")]
        [CLSCompliant(false)]
        public static void StencilFunc(OpenTK.Graphics.ES10.All func, Int32 @ref, Int32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where n is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilFunc")]
        [CLSCompliant(false)]
        public static void StencilFunc(OpenTK.Graphics.ES10.All func, Int32 @ref, UInt32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where n is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilFunc")]
        [CLSCompliant(false)]
        public static void StencilFunc(OpenTK.Graphics.ES10.StencilFunction func, Int32 @ref, Int32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func"> 
        /// Specifies the test function. Eight symbolic constants are valid: Never, Less, Lequal, Greater, Gequal, Equal, Notequal, and Always. The initial value is Always.
        /// </param>
        /// <param name="ref"> 
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where n is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask"> 
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilFunc")]
        [CLSCompliant(false)]
        public static void StencilFunc(OpenTK.Graphics.ES10.StencilFunction func, Int32 @ref, UInt32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Control the front and back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="mask"> 
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilMask")]
        [CLSCompliant(false)]
        public static void StencilMask(Int32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Control the front and back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="mask"> 
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilMask")]
        [CLSCompliant(false)]
        public static void StencilMask(UInt32 mask) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set front and back stencil test actions
        /// </summary>
        /// <param name="fail"> 
        /// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: Keep, Zero, Replace, Incr, IncrWrap, Decr, DecrWrap, and Invert. The initial value is Keep.
        /// </param>
        /// <param name="zfail"> 
        /// Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        /// <param name="zpass"> 
        /// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilOp")]
        public static void StencilOp(OpenTK.Graphics.ES10.All fail, OpenTK.Graphics.ES10.All zfail, OpenTK.Graphics.ES10.All zpass) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set front and back stencil test actions
        /// </summary>
        /// <param name="fail"> 
        /// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: Keep, Zero, Replace, Incr, IncrWrap, Decr, DecrWrap, and Invert. The initial value is Keep.
        /// </param>
        /// <param name="zfail"> 
        /// Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        /// <param name="zpass"> 
        /// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is Keep.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glStencilOp")]
        public static void StencilOp(OpenTK.Graphics.ES10.StencilOp fail, OpenTK.Graphics.ES10.StencilOp zfail, OpenTK.Graphics.ES10.StencilOp zpass) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each texture coordinate. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        public static void TexCoordPointer(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each texture coordinate. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        [CLSCompliant(false)]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each texture coordinate. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        [CLSCompliant(false)]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each texture coordinate. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        [CLSCompliant(false)]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each texture coordinate. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each texture coordinate. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        public static void TexCoordPointer(Int32 size, OpenTK.Graphics.ES10.TexCoordPointerType type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each texture coordinate. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        [CLSCompliant(false)]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES10.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each texture coordinate. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        [CLSCompliant(false)]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES10.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each texture coordinate. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        [CLSCompliant(false)]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES10.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each texture coordinate. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexCoordPointer")]
        public static void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES10.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="param"> 
        /// Specifies a single symbolic constant, one of Add, AddSigned, Interpolate, Modulate, Decal, Blend, Replace, Subtract, Combine, Texture, Constant, PrimaryColor, Previous, SrcColor, OneMinusSrcColor, SrcAlpha, OneMinusSrcAlpha, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the RgbScale or AlphaScale.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvf")]
        public static void TexEnv(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="param"> 
        /// Specifies a single symbolic constant, one of Add, AddSigned, Interpolate, Modulate, Decal, Blend, Replace, Subtract, Combine, Texture, Constant, PrimaryColor, Previous, SrcColor, OneMinusSrcColor, SrcAlpha, OneMinusSrcAlpha, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the RgbScale or AlphaScale.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvf")]
        public static void TexEnv(OpenTK.Graphics.ES10.TextureEnvTarget target, OpenTK.Graphics.ES10.TextureEnvParameter pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to a parameter array that contains either a single symbolic constant, single floating-point number, or an RGBA color.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        [CLSCompliant(false)]
        public static void TexEnv(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to a parameter array that contains either a single symbolic constant, single floating-point number, or an RGBA color.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        [CLSCompliant(false)]
        public static unsafe void TexEnv(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to a parameter array that contains either a single symbolic constant, single floating-point number, or an RGBA color.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        [CLSCompliant(false)]
        public static void TexEnv(OpenTK.Graphics.ES10.TextureEnvTarget target, OpenTK.Graphics.ES10.TextureEnvParameter pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to a parameter array that contains either a single symbolic constant, single floating-point number, or an RGBA color.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvfv")]
        [CLSCompliant(false)]
        public static unsafe void TexEnv(OpenTK.Graphics.ES10.TextureEnvTarget target, OpenTK.Graphics.ES10.TextureEnvParameter pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="param"> 
        /// Specifies a single symbolic constant, one of Add, AddSigned, Interpolate, Modulate, Decal, Blend, Replace, Subtract, Combine, Texture, Constant, PrimaryColor, Previous, SrcColor, OneMinusSrcColor, SrcAlpha, OneMinusSrcAlpha, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the RgbScale or AlphaScale.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvi")]
        public static void TexEnv(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, Int32 param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="param"> 
        /// Specifies a single symbolic constant, one of Add, AddSigned, Interpolate, Modulate, Decal, Blend, Replace, Subtract, Combine, Texture, Constant, PrimaryColor, Previous, SrcColor, OneMinusSrcColor, SrcAlpha, OneMinusSrcAlpha, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the RgbScale or AlphaScale.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvi")]
        public static void TexEnv(OpenTK.Graphics.ES10.TextureEnvTarget target, OpenTK.Graphics.ES10.TextureEnvParameter pname, Int32 param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to a parameter array that contains either a single symbolic constant, single floating-point number, or an RGBA color.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        [CLSCompliant(false)]
        public static void TexEnv(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to a parameter array that contains either a single symbolic constant, single floating-point number, or an RGBA color.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        [CLSCompliant(false)]
        public static unsafe void TexEnv(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to a parameter array that contains either a single symbolic constant, single floating-point number, or an RGBA color.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        [CLSCompliant(false)]
        public static void TexEnv(OpenTK.Graphics.ES10.TextureEnvTarget target, OpenTK.Graphics.ES10.TextureEnvParameter pname, Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, or CoordReplace.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to a parameter array that contains either a single symbolic constant, single floating-point number, or an RGBA color.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnviv")]
        [CLSCompliant(false)]
        public static unsafe void TexEnv(OpenTK.Graphics.ES10.TextureEnvTarget target, OpenTK.Graphics.ES10.TextureEnvParameter pname, Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvx")]
        public static void TexEnvx(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvxv")]
        [CLSCompliant(false)]
        public static void TexEnvx(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexEnvxv")]
        [CLSCompliant(false)]
        public static unsafe void TexEnvx(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, Rgba.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the texel data.  Must match internalformat. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the texel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        public static void TexImage2D(OpenTK.Graphics.ES10.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, IntPtr pixels) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, Rgba.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the texel data.  Must match internalformat. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the texel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        [CLSCompliant(false)]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, Rgba.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the texel data.  Must match internalformat. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the texel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        [CLSCompliant(false)]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, Rgba.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the texel data.  Must match internalformat. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the texel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        [CLSCompliant(false)]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, Rgba.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the texel data.  Must match internalformat. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the texel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, Rgba.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the texel data.  Must match internalformat. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the texel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        public static void TexImage2D(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, IntPtr pixels) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, Rgba.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the texel data.  Must match internalformat. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the texel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        [CLSCompliant(false)]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, Rgba.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the texel data.  Must match internalformat. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the texel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        [CLSCompliant(false)]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, Rgba.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the texel data.  Must match internalformat. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the texel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        [CLSCompliant(false)]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalformat"> 
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: Alpha, Luminance, LuminanceAlpha, Rgb, Rgba.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture image. All implementations support 2D texture images that are at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture image All implementations support 2D texture images that are at least 64 texels high and cube-mapped texture images that are at least 16 texels high.
        /// </param>
        /// <param name="border"> 
        /// Specifies the width of the border. Must be 0.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the texel data.  Must match internalformat. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the texel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexImage2D")]
        public static void TexImage2D<T8>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value of pname.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterf")]
        public static void TexParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value of pname.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterf")]
        public static void TexParameter(OpenTK.Graphics.ES10.TextureTarget target, OpenTK.Graphics.ES10.TextureParameterName pname, Single param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to an array where the value of pname is stored.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        [CLSCompliant(false)]
        public static void TexParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to an array where the value of pname is stored.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        [CLSCompliant(false)]
        public static unsafe void TexParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to an array where the value of pname is stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        [CLSCompliant(false)]
        public static void TexParameter(OpenTK.Graphics.ES10.TextureTarget target, OpenTK.Graphics.ES10.TextureParameterName pname, Single[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to an array where the value of pname is stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterfv")]
        [CLSCompliant(false)]
        public static unsafe void TexParameter(OpenTK.Graphics.ES10.TextureTarget target, OpenTK.Graphics.ES10.TextureParameterName pname, Single* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value of pname.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteri")]
        public static void TexParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, Int32 param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="param"> 
        /// Specifies the value of pname.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteri")]
        public static void TexParameter(OpenTK.Graphics.ES10.TextureTarget target, OpenTK.Graphics.ES10.TextureParameterName pname, Int32 param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to an array where the value of pname is stored.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        [CLSCompliant(false)]
        public static void TexParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to an array where the value of pname is stored.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        [CLSCompliant(false)]
        public static unsafe void TexParameter(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to an array where the value of pname is stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        [CLSCompliant(false)]
        public static void TexParameter(OpenTK.Graphics.ES10.TextureTarget target, OpenTK.Graphics.ES10.TextureParameterName pname, Int32[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit, which must be either Texture2D or TextureCubeMap.
        /// </param>
        /// <param name="pname"> 
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: TextureMinFilter, TextureMagFilter, TextureWrapS, or TextureWrapT.
        /// </param>
        /// <param name="params">[length: pname] 
        /// Specifies a pointer to an array where the value of pname is stored.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameteriv")]
        [CLSCompliant(false)]
        public static unsafe void TexParameter(OpenTK.Graphics.ES10.TextureTarget target, OpenTK.Graphics.ES10.TextureParameterName pname, Int32* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterx")]
        public static void TexParameterx(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, int param) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterxv")]
        [CLSCompliant(false)]
        public static void TexParameterx(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, int[] @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="params">[length: pname]</param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexParameterxv")]
        [CLSCompliant(false)]
        public static unsafe void TexParameterx(OpenTK.Graphics.ES10.All target, OpenTK.Graphics.ES10.All pname, int* @params) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        public static void TexSubImage2D(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, IntPtr pixels) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        [CLSCompliant(false)]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        [CLSCompliant(false)]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        [CLSCompliant(false)]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES10.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.All format, OpenTK.Graphics.ES10.All type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        public static void TexSubImage2D(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, IntPtr pixels) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        [CLSCompliant(false)]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        [CLSCompliant(false)]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        [CLSCompliant(false)]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target"> 
        /// Specifies the target texture of the active texture unit. Must be Texture2D, TextureCubeMapPositiveX, TextureCubeMapNegativeX, TextureCubeMapPositiveY, TextureCubeMapNegativeY, TextureCubeMapPositiveZ, or TextureCubeMapNegativeZ.
        /// </param>
        /// <param name="level"> 
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="xoffset"> 
        /// Specifies a texel offset in the x direction within the texture array.
        /// </param>
        /// <param name="yoffset"> 
        /// Specifies a texel offset in the y direction within the texture array.
        /// </param>
        /// <param name="width"> 
        /// Specifies the width of the texture subimage.
        /// </param>
        /// <param name="height"> 
        /// Specifies the height of the texture subimage.
        /// </param>
        /// <param name="format"> 
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Alpha, Rgb, Rgba, Luminance, and LuminanceAlpha.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, UnsignedShort565, UnsignedShort4444, and UnsignedShort5551.
        /// </param>
        /// <param name="pixels">[length: format,type,width,height] 
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTexSubImage2D")]
        public static void TexSubImage2D<T8>(OpenTK.Graphics.ES10.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES10.PixelFormat format, OpenTK.Graphics.ES10.PixelType type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a translation matrix
        /// </summary>
        /// <param name="x"> 
        /// Specify the x, y, and z coordinates of a translation vector.
        /// </param>
        /// <param name="y"> 
        /// Specify the x, y, and z coordinates of a translation vector.
        /// </param>
        /// <param name="z"> 
        /// Specify the x, y, and z coordinates of a translation vector.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTranslatef")]
        public static void Translate(Single x, Single y, Single z) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]</summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glTranslatex")]
        public static void Translatex(int x, int y, int z) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        public static void VertexPointer(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        [CLSCompliant(false)]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        [CLSCompliant(false)]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        [CLSCompliant(false)]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </param>
        [Obsolete("Use strongly-typed overload instead")]
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES10.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        public static void VertexPointer(Int32 size, OpenTK.Graphics.ES10.VertexPointerType type, Int32 stride, IntPtr pointer) { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        [CLSCompliant(false)]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES10.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        [CLSCompliant(false)]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES10.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        [CLSCompliant(false)]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES10.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size"> 
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type"> 
        /// Specifies the data type of each coordinate in the array. Symbolic constants Short, Int, Float, or Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride"> 
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="pointer">[length: size,type,stride] 
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glVertexPointer")]
        public static void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES10.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
         { throw new NotImplementedException(); }

        /// <summary>[requires: v1.0]
        /// Set the viewport
        /// </summary>
        /// <param name="x"> 
        /// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
        /// </param>
        /// <param name="y"> 
        /// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
        /// </param>
        /// <param name="width"> 
        /// Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window.
        /// </param>
        /// <param name="height"> 
        /// Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window.
        /// </param>
        [AutoGenerated(Category = "VERSION_ES_CM_1_0", Version = "1.0", EntryPoint = "glViewport")]
        public static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height) { throw new NotImplementedException(); }

        [Slot(0)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glActiveTexture(System.Int32 texture);
        [Slot(1)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glAlphaFunc(System.Int32 func, Single @ref);
        [Slot(2)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glAlphaFuncx(System.Int32 func, int @ref);
        [Slot(3)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBindBuffer(System.Int32 target, UInt32 buffer);
        [Slot(4)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBindTexture(System.Int32 target, UInt32 texture);
        [Slot(5)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBlendFunc(System.Int32 sfactor, System.Int32 dfactor);
        [Slot(6)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBufferData(System.Int32 target, IntPtr size, IntPtr data, System.Int32 usage);
        [Slot(7)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glBufferSubData(System.Int32 target, IntPtr offset, IntPtr size, IntPtr data);
        [Slot(8)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClear(System.Int32 mask);
        [Slot(9)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearColor(Single red, Single green, Single blue, Single alpha);
        [Slot(10)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearColorx(int red, int green, int blue, int alpha);
        [Slot(11)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearDepthf(Single d);
        [Slot(12)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearDepthx(int depth);
        [Slot(13)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClearStencil(Int32 s);
        [Slot(14)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glClientActiveTexture(System.Int32 texture);
        [Slot(15)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glClipPlanef(System.Int32 p, Single* eqn);
        [Slot(16)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glClipPlanefIMG(System.Int32 p, Single* eqn);
        [Slot(17)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glClipPlanex(System.Int32 plane, int* equation);
        [Slot(18)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glClipPlanexIMG(System.Int32 p, int* eqn);
        [Slot(19)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glColor4f(Single red, Single green, Single blue, Single alpha);
        [Slot(20)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glColor4ub(Byte red, Byte green, Byte blue, Byte alpha);
        [Slot(21)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glColor4x(int red, int green, int blue, int alpha);
        [Slot(22)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glColorMask(bool red, bool green, bool blue, bool alpha);
        [Slot(23)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glColorPointer(Int32 size, System.Int32 type, Int32 stride, IntPtr pointer);
        [Slot(24)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glCompressedTexImage2D(System.Int32 target, Int32 level, System.Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
        [Slot(25)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glCompressedTexSubImage2D(System.Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, System.Int32 format, Int32 imageSize, IntPtr data);
        [Slot(26)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glCopyTexImage2D(System.Int32 target, Int32 level, System.Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
        [Slot(27)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glCopyTexSubImage2D(System.Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
        [Slot(28)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glCullFace(System.Int32 mode);
        [Slot(29)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glDeleteBuffers(Int32 n, UInt32* buffers);
        [Slot(30)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glDeleteTextures(Int32 n, UInt32* textures);
        [Slot(31)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDepthFunc(System.Int32 func);
        [Slot(32)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDepthMask(bool flag);
        [Slot(33)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDepthRangef(Single n, Single f);
        [Slot(34)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDepthRangex(int n, int f);
        [Slot(35)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDisable(System.Int32 cap);
        [Slot(36)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDisableClientState(System.Int32 array);
        [Slot(37)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDisableDriverControlQCOM(UInt32 driverControl);
        [Slot(38)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDrawArrays(System.Int32 mode, Int32 first, Int32 count);
        [Slot(39)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glDrawElements(System.Int32 mode, Int32 count, System.Int32 type, IntPtr indices);
        [Slot(40)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glEnable(System.Int32 cap);
        [Slot(41)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glEnableClientState(System.Int32 array);
        [Slot(42)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glEnableDriverControlQCOM(UInt32 driverControl);
        [Slot(43)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glEndTilingQCOM(UInt32 preserveMask);
        [Slot(44)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glExtGetBufferPointervQCOM(System.Int32 target, IntPtr @params);
        [Slot(45)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetBuffersQCOM(UInt32* buffers, Int32 maxBuffers, Int32* numBuffers);
        [Slot(46)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetFramebuffersQCOM(UInt32* framebuffers, Int32 maxFramebuffers, Int32* numFramebuffers);
        [Slot(47)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetProgramBinarySourceQCOM(UInt32 program, System.Int32 shadertype, IntPtr source, Int32* length);
        [Slot(48)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetProgramsQCOM(UInt32* programs, Int32 maxPrograms, Int32* numPrograms);
        [Slot(49)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetRenderbuffersQCOM(UInt32* renderbuffers, Int32 maxRenderbuffers, Int32* numRenderbuffers);
        [Slot(50)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetShadersQCOM(UInt32* shaders, Int32 maxShaders, Int32* numShaders);
        [Slot(51)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetTexLevelParameterivQCOM(UInt32 texture, System.Int32 face, Int32 level, System.Int32 pname, Int32* @params);
        [Slot(52)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glExtGetTexSubImageQCOM(System.Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, System.Int32 format, System.Int32 type, IntPtr texels);
        [Slot(53)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glExtGetTexturesQCOM(UInt32* textures, Int32 maxTextures, Int32* numTextures);
        [Slot(54)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern byte glExtIsProgramBinaryQCOM(UInt32 program);
        [Slot(55)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glExtTexObjectStateOverrideiQCOM(System.Int32 target, System.Int32 pname, Int32 param);
        [Slot(56)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFinish();
        [Slot(57)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFlush();
        [Slot(58)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFogf(System.Int32 pname, Single param);
        [Slot(59)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glFogfv(System.Int32 pname, Single* @params);
        [Slot(60)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFogx(System.Int32 pname, int param);
        [Slot(61)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glFogxv(System.Int32 pname, int* param);
        [Slot(62)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFramebufferTexture2DMultisampleIMG(System.Int32 target, System.Int32 attachment, System.Int32 textarget, UInt32 texture, Int32 level, Int32 samples);
        [Slot(63)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFrontFace(System.Int32 mode);
        [Slot(64)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFrustumf(Single l, Single r, Single b, Single t, Single n, Single f);
        [Slot(65)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glFrustumx(int l, int r, int b, int t, int n, int f);
        [Slot(66)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
        [Slot(67)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGenTextures(Int32 n, UInt32* textures);
        [Slot(68)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetBooleanv(System.Int32 pname, [OutAttribute] bool* data);
        [Slot(69)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetBufferParameteriv(System.Int32 target, System.Int32 pname, [OutAttribute] Int32* @params);
        [Slot(70)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetClipPlanef(System.Int32 plane, [OutAttribute] Single* equation);
        [Slot(71)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetClipPlanex(System.Int32 plane, [OutAttribute] int* equation);
        [Slot(72)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetDriverControlsQCOM([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls);
        [Slot(73)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] IntPtr driverControlString);
        [Slot(74)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 glGetError();
        [Slot(75)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetFixedv(System.Int32 pname, [OutAttribute] int* @params);
        [Slot(76)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetFloatv(System.Int32 pname, [OutAttribute] Single* data);
        [Slot(77)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetIntegerv(System.Int32 pname, Int32* data);
        [Slot(78)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetLightfv(System.Int32 light, System.Int32 pname, [OutAttribute] Single* @params);
        [Slot(79)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetLightxv(System.Int32 light, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(80)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetMaterialfv(System.Int32 face, System.Int32 pname, [OutAttribute] Single* @params);
        [Slot(81)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetMaterialxv(System.Int32 face, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(82)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetPixelMapxv(System.Int32 map, Int32 size, [OutAttribute] int* values);
        [Slot(83)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glGetPointerv(System.Int32 pname, [OutAttribute] IntPtr @params);
        [Slot(84)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern IntPtr glGetString(System.Int32 name);
        [Slot(85)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexEnvfv(System.Int32 target, System.Int32 pname, [OutAttribute] Single* @params);
        [Slot(86)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexEnviv(System.Int32 target, System.Int32 pname, [OutAttribute] Int32* @params);
        [Slot(87)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexEnvxv(System.Int32 target, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(88)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexParameterfv(System.Int32 target, System.Int32 pname, [OutAttribute] Single* @params);
        [Slot(89)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexParameteriv(System.Int32 target, System.Int32 pname, [OutAttribute] Int32* @params);
        [Slot(90)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glGetTexParameterxv(System.Int32 target, System.Int32 pname, [OutAttribute] int* @params);
        [Slot(91)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glHint(System.Int32 target, System.Int32 mode);
        [Slot(92)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern byte glIsBuffer(UInt32 buffer);
        [Slot(93)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern byte glIsEnabled(System.Int32 cap);
        [Slot(94)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern byte glIsTexture(UInt32 texture);
        [Slot(95)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLightf(System.Int32 light, System.Int32 pname, Single param);
        [Slot(96)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLightfv(System.Int32 light, System.Int32 pname, Single* @params);
        [Slot(97)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLightModelf(System.Int32 pname, Single param);
        [Slot(98)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLightModelfv(System.Int32 pname, Single* @params);
        [Slot(99)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLightModelx(System.Int32 pname, int param);
        [Slot(100)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLightModelxv(System.Int32 pname, int* param);
        [Slot(101)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLightx(System.Int32 light, System.Int32 pname, int param);
        [Slot(102)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLightxv(System.Int32 light, System.Int32 pname, int* @params);
        [Slot(103)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLineWidth(Single width);
        [Slot(104)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLineWidthx(int width);
        [Slot(105)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLoadIdentity();
        [Slot(106)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLoadMatrixf(Single* m);
        [Slot(107)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glLoadMatrixx(int* m);
        [Slot(108)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glLogicOp(System.Int32 opcode);
        [Slot(109)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMaterialf(System.Int32 face, System.Int32 pname, Single param);
        [Slot(110)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMaterialfv(System.Int32 face, System.Int32 pname, Single* @params);
        [Slot(111)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMaterialx(System.Int32 face, System.Int32 pname, int param);
        [Slot(112)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMaterialxv(System.Int32 face, System.Int32 pname, int* param);
        [Slot(113)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMatrixMode(System.Int32 mode);
        [Slot(114)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMultiTexCoord4f(System.Int32 target, Single s, Single t, Single r, Single q);
        [Slot(115)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glMultiTexCoord4x(System.Int32 texture, int s, int t, int r, int q);
        [Slot(116)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultMatrixf(Single* m);
        [Slot(117)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glMultMatrixx(int* m);
        [Slot(118)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glNormal3f(Single nx, Single ny, Single nz);
        [Slot(119)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glNormal3x(int nx, int ny, int nz);
        [Slot(120)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glNormalPointer(System.Int32 type, Int32 stride, IntPtr pointer);
        [Slot(121)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glOrthof(Single l, Single r, Single b, Single t, Single n, Single f);
        [Slot(122)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glOrthox(int l, int r, int b, int t, int n, int f);
        [Slot(123)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glPixelMapx(System.Int32 map, Int32 size, int* values);
        [Slot(124)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPixelStorei(System.Int32 pname, Int32 param);
        [Slot(125)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPixelStorex(System.Int32 pname, int param);
        [Slot(126)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPointParameterf(System.Int32 pname, Single param);
        [Slot(127)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glPointParameterfv(System.Int32 pname, Single* @params);
        [Slot(128)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPointParameterx(System.Int32 pname, int param);
        [Slot(129)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glPointParameterxv(System.Int32 pname, int* @params);
        [Slot(130)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPointSize(Single size);
        [Slot(131)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPointSizex(int size);
        [Slot(132)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPolygonOffset(Single factor, Single units);
        [Slot(133)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPolygonOffsetx(int factor, int units);
        [Slot(134)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPopMatrix();
        [Slot(135)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glPushMatrix();
        [Slot(136)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, System.Int32 format, System.Int32 type, [OutAttribute] IntPtr pixels);
        [Slot(137)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRenderbufferStorageMultisampleIMG(System.Int32 target, Int32 samples, System.Int32 internalformat, Int32 width, Int32 height);
        [Slot(138)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRotatef(Single angle, Single x, Single y, Single z);
        [Slot(139)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glRotatex(int angle, int x, int y, int z);
        [Slot(140)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glSampleCoverage(Single value, bool invert);
        [Slot(141)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glSampleCoveragex(int value, bool invert);
        [Slot(142)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glScalef(Single x, Single y, Single z);
        [Slot(143)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glScalex(int x, int y, int z);
        [Slot(144)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glScissor(Int32 x, Int32 y, Int32 width, Int32 height);
        [Slot(145)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glShadeModel(System.Int32 mode);
        [Slot(146)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glStartTilingQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask);
        [Slot(147)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glStencilFunc(System.Int32 func, Int32 @ref, UInt32 mask);
        [Slot(148)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glStencilMask(UInt32 mask);
        [Slot(149)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glStencilOp(System.Int32 fail, System.Int32 zfail, System.Int32 zpass);
        [Slot(150)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexCoordPointer(Int32 size, System.Int32 type, Int32 stride, IntPtr pointer);
        [Slot(151)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexEnvf(System.Int32 target, System.Int32 pname, Single param);
        [Slot(152)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexEnvfv(System.Int32 target, System.Int32 pname, Single* @params);
        [Slot(153)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexEnvi(System.Int32 target, System.Int32 pname, Int32 param);
        [Slot(154)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexEnviv(System.Int32 target, System.Int32 pname, Int32* @params);
        [Slot(155)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexEnvx(System.Int32 target, System.Int32 pname, int param);
        [Slot(156)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexEnvxv(System.Int32 target, System.Int32 pname, int* @params);
        [Slot(157)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexImage2D(System.Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, System.Int32 format, System.Int32 type, IntPtr pixels);
        [Slot(158)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexParameterf(System.Int32 target, System.Int32 pname, Single param);
        [Slot(159)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexParameterfv(System.Int32 target, System.Int32 pname, Single* @params);
        [Slot(160)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexParameteri(System.Int32 target, System.Int32 pname, Int32 param);
        [Slot(161)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexParameteriv(System.Int32 target, System.Int32 pname, Int32* @params);
        [Slot(162)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexParameterx(System.Int32 target, System.Int32 pname, int param);
        [Slot(163)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void glTexParameterxv(System.Int32 target, System.Int32 pname, int* @params);
        [Slot(164)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTexSubImage2D(System.Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, System.Int32 format, System.Int32 type, IntPtr pixels);
        [Slot(165)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTranslatef(Single x, Single y, Single z);
        [Slot(166)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glTranslatex(int x, int y, int z);
        [Slot(167)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glVertexPointer(Int32 size, System.Int32 type, Int32 stride, IntPtr pointer);
        [Slot(168)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void glViewport(Int32 x, Int32 y, Int32 width, Int32 height);
    }
}
