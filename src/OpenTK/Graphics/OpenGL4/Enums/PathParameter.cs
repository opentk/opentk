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

// ReSharper disable InconsistentNaming
#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Used in GL.NV.GetPathParameter and GL.NV.PathParameter.
    /// </summary>
    public enum PathParameter
    {
        /// <summary>
        /// Original was GL_PATH_STROKE_WIDTH_NV = 0x9075
        /// </summary>
        PathStrokeWidthNV = 0x9075,

        /// <summary>
        /// Original was GL_PATH_END_CAPS_NV = 0x9076
        /// </summary>
        PathEndCapsNV = 0x9076,

        /// <summary>
        /// Original was GL_PATH_INITIAL_END_CAP_NV = 0x9077
        /// </summary>
        PathInitialEndCapNV = 0x9077,

        /// <summary>
        /// Original was GL_PATH_TERMINAL_END_CAP_NV = 0x9078
        /// </summary>
        PathTerminalEndCapNV = 0x9078,

        /// <summary>
        /// Original was GL_PATH_JOIN_STYLE_NV = 0x9079
        /// </summary>
        PathJoinStyleNV = 0x9079,

        /// <summary>
        /// Original was GL_PATH_MITER_LIMIT_NV = 0x907A
        /// </summary>
        PathMiterLimitNV = 0x907a,

        /// <summary>
        /// Original was GL_PATH_DASH_CAPS_NV = 0x907B
        /// </summary>
        PathDashCapsNV = 0x907b,

        /// <summary>
        /// Original was GL_PATH_INITIAL_DASH_CAP_NV = 0x907C
        /// </summary>
        PathInitialDashCapNV = 0x907c,

        /// <summary>
        /// Original was GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D
        /// </summary>
        PathTerminalDashCapNV = 0x907d,

        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_NV = 0x907E
        /// </summary>
        PathDashOffsetNV = 0x907e,

        /// <summary>
        /// Original was GL_PATH_CLIENT_LENGTH_NV = 0x907F
        /// </summary>
        PathClientLengthNV = 0x907f,

        /// <summary>
        /// Original was GL_PATH_FILL_MODE_NV = 0x9080
        /// </summary>
        PathFillModeNV = 0x9080,

        /// <summary>
        /// Original was GL_PATH_FILL_MASK_NV = 0x9081
        /// </summary>
        PathFillMaskNV = 0x9081,

        /// <summary>
        /// Original was GL_PATH_FILL_COVER_MODE_NV = 0x9082
        /// </summary>
        PathFillCoverModeNV = 0x9082,

        /// <summary>
        /// Original was GL_PATH_STROKE_COVER_MODE_NV = 0x9083
        /// </summary>
        PathStrokeCoverModeNV = 0x9083,

        /// <summary>
        /// Original was GL_PATH_STROKE_MASK_NV = 0x9084
        /// </summary>
        PathStrokeMaskNV = 0x9084,

        /// <summary>
        /// Original was GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A
        /// </summary>
        PathObjectBoundingBoxNV = 0x908a,

        /// <summary>
        /// Original was GL_PATH_COMMAND_COUNT_NV = 0x909D
        /// </summary>
        PathCommandCountNV = 0x909d,

        /// <summary>
        /// Original was GL_PATH_COORD_COUNT_NV = 0x909E
        /// </summary>
        PathCoordCountNV = 0x909e,

        /// <summary>
        /// Original was GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F
        /// </summary>
        PathDashArrayCountNV = 0x909f,

        /// <summary>
        /// Original was GL_PATH_COMPUTED_LENGTH_NV = 0x90A0
        /// </summary>
        PathComputedLengthNV = 0x90a0,

        /// <summary>
        /// Original was GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1
        /// </summary>
        PathFillBoundingBoxNV = 0x90a1,

        /// <summary>
        /// Original was GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2
        /// </summary>
        PathStrokeBoundingBoxNV = 0x90a2,

        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4
        /// </summary>
        PathDashOffsetResetNV = 0x90b4
    }
}
