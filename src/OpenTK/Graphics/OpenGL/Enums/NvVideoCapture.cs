//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
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

using System;

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// Used in GL.NV.BindVideoCaptureStreamBuffer, GL.NV.BindVideoCaptureStreamTexture and 3 other functions
    /// </summary>
    public enum NvVideoCapture
    {
        /// <summary>
        /// Original was GL_VIDEO_BUFFER_NV = 0x9020
        /// </summary>
        VideoBufferNv = 0x9020,

        /// <summary>
        /// Original was GL_VIDEO_BUFFER_BINDING_NV = 0x9021
        /// </summary>
        VideoBufferBindingNv = 0x9021,

        /// <summary>
        /// Original was GL_FIELD_UPPER_NV = 0x9022
        /// </summary>
        FieldUpperNv = 0x9022,

        /// <summary>
        /// Original was GL_FIELD_LOWER_NV = 0x9023
        /// </summary>
        FieldLowerNv = 0x9023,

        /// <summary>
        /// Original was GL_NUM_VIDEO_CAPTURE_STREAMS_NV = 0x9024
        /// </summary>
        NumVideoCaptureStreamsNv = 0x9024,

        /// <summary>
        /// Original was GL_NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV = 0x9025
        /// </summary>
        NextVideoCaptureBufferStatusNv = 0x9025,

        /// <summary>
        /// Original was GL_VIDEO_CAPTURE_TO_422_SUPPORTED_NV = 0x9026
        /// </summary>
        VideoCaptureTo422SupportedNv = 0x9026,

        /// <summary>
        /// Original was GL_LAST_VIDEO_CAPTURE_STATUS_NV = 0x9027
        /// </summary>
        LastVideoCaptureStatusNv = 0x9027,

        /// <summary>
        /// Original was GL_VIDEO_BUFFER_PITCH_NV = 0x9028
        /// </summary>
        VideoBufferPitchNv = 0x9028,

        /// <summary>
        /// Original was GL_VIDEO_COLOR_CONVERSION_MATRIX_NV = 0x9029
        /// </summary>
        VideoColorConversionMatrixNv = 0x9029,

        /// <summary>
        /// Original was GL_VIDEO_COLOR_CONVERSION_MAX_NV = 0x902A
        /// </summary>
        VideoColorConversionMaxNv = 0x902a,

        /// <summary>
        /// Original was GL_VIDEO_COLOR_CONVERSION_MIN_NV = 0x902B
        /// </summary>
        VideoColorConversionMinNv = 0x902b,

        /// <summary>
        /// Original was GL_VIDEO_COLOR_CONVERSION_OFFSET_NV = 0x902C
        /// </summary>
        VideoColorConversionOffsetNv = 0x902c,

        /// <summary>
        /// Original was GL_VIDEO_BUFFER_INTERNAL_FORMAT_NV = 0x902D
        /// </summary>
        VideoBufferInternalFormatNv = 0x902d,

        /// <summary>
        /// Original was GL_PARTIAL_SUCCESS_NV = 0x902E
        /// </summary>
        PartialSuccessNv = 0x902e,

        /// <summary>
        /// Original was GL_SUCCESS_NV = 0x902F
        /// </summary>
        SuccessNv = 0x902f,

        /// <summary>
        /// Original was GL_FAILURE_NV = 0x9030
        /// </summary>
        FailureNv = 0x9030,

        /// <summary>
        /// Original was GL_YCBYCR8_422_NV = 0x9031
        /// </summary>
        Ycbycr8422Nv = 0x9031,

        /// <summary>
        /// Original was GL_YCBAYCR8A_4224_NV = 0x9032
        /// </summary>
        Ycbaycr8A4224Nv = 0x9032,

        /// <summary>
        /// Original was GL_Z6Y10Z6CB10Z6Y10Z6CR10_422_NV = 0x9033
        /// </summary>
        Z6y10z6cb10z6y10z6cr10422Nv = 0x9033,

        /// <summary>
        /// Original was GL_Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV = 0x9034
        /// </summary>
        Z6y10z6cb10z6A10z6y10z6cr10z6A104224Nv = 0x9034,

        /// <summary>
        /// Original was GL_Z4Y12Z4CB12Z4Y12Z4CR12_422_NV = 0x9035
        /// </summary>
        Z4y12z4cb12z4y12z4cr12422Nv = 0x9035,

        /// <summary>
        /// Original was GL_Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV = 0x9036
        /// </summary>
        Z4y12z4cb12z4A12z4y12z4cr12z4A124224Nv = 0x9036,

        /// <summary>
        /// Original was GL_Z4Y12Z4CB12Z4CR12_444_NV = 0x9037
        /// </summary>
        Z4y12z4cb12z4cr12444Nv = 0x9037,

        /// <summary>
        /// Original was GL_VIDEO_CAPTURE_FRAME_WIDTH_NV = 0x9038
        /// </summary>
        VideoCaptureFrameWidthNv = 0x9038,

        /// <summary>
        /// Original was GL_VIDEO_CAPTURE_FRAME_HEIGHT_NV = 0x9039
        /// </summary>
        VideoCaptureFrameHeightNv = 0x9039,

        /// <summary>
        /// Original was GL_VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV = 0x903A
        /// </summary>
        VideoCaptureFieldUpperHeightNv = 0x903a,

        /// <summary>
        /// Original was GL_VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV = 0x903B
        /// </summary>
        VideoCaptureFieldLowerHeightNv = 0x903b,

        /// <summary>
        /// Original was GL_VIDEO_CAPTURE_SURFACE_ORIGIN_NV = 0x903C
        /// </summary>
        VideoCaptureSurfaceOriginNv = 0x903c
    }
}
