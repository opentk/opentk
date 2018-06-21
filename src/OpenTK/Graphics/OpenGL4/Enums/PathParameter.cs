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

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Used in GL.NV.GetPathParameter, GL.NV.PathParameter
    /// </summary>
    public enum PathParameter
    {
        /// <summary>
        /// Original was GL_PATH_STROKE_WIDTH_NV = 0x9075
        /// </summary>
        PathStrokeWidthNv = 0x9075,

        /// <summary>
        /// Original was GL_PATH_END_CAPS_NV = 0x9076
        /// </summary>
        PathEndCapsNv = 0x9076,

        /// <summary>
        /// Original was GL_PATH_INITIAL_END_CAP_NV = 0x9077
        /// </summary>
        PathInitialEndCapNv = 0x9077,

        /// <summary>
        /// Original was GL_PATH_TERMINAL_END_CAP_NV = 0x9078
        /// </summary>
        PathTerminalEndCapNv = 0x9078,

        /// <summary>
        /// Original was GL_PATH_JOIN_STYLE_NV = 0x9079
        /// </summary>
        PathJoinStyleNv = 0x9079,

        /// <summary>
        /// Original was GL_PATH_MITER_LIMIT_NV = 0x907A
        /// </summary>
        PathMiterLimitNv = 0x907a,

        /// <summary>
        /// Original was GL_PATH_DASH_CAPS_NV = 0x907B
        /// </summary>
        PathDashCapsNv = 0x907b,

        /// <summary>
        /// Original was GL_PATH_INITIAL_DASH_CAP_NV = 0x907C
        /// </summary>
        PathInitialDashCapNv = 0x907c,

        /// <summary>
        /// Original was GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D
        /// </summary>
        PathTerminalDashCapNv = 0x907d,

        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_NV = 0x907E
        /// </summary>
        PathDashOffsetNv = 0x907e,

        /// <summary>
        /// Original was GL_PATH_CLIENT_LENGTH_NV = 0x907F
        /// </summary>
        PathClientLengthNv = 0x907f,

        /// <summary>
        /// Original was GL_PATH_FILL_MODE_NV = 0x9080
        /// </summary>
        PathFillModeNv = 0x9080,

        /// <summary>
        /// Original was GL_PATH_FILL_MASK_NV = 0x9081
        /// </summary>
        PathFillMaskNv = 0x9081,

        /// <summary>
        /// Original was GL_PATH_FILL_COVER_MODE_NV = 0x9082
        /// </summary>
        PathFillCoverModeNv = 0x9082,

        /// <summary>
        /// Original was GL_PATH_STROKE_COVER_MODE_NV = 0x9083
        /// </summary>
        PathStrokeCoverModeNv = 0x9083,

        /// <summary>
        /// Original was GL_PATH_STROKE_MASK_NV = 0x9084
        /// </summary>
        PathStrokeMaskNv = 0x9084,

        /// <summary>
        /// Original was GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A
        /// </summary>
        PathObjectBoundingBoxNv = 0x908a,

        /// <summary>
        /// Original was GL_PATH_COMMAND_COUNT_NV = 0x909D
        /// </summary>
        PathCommandCountNv = 0x909d,

        /// <summary>
        /// Original was GL_PATH_COORD_COUNT_NV = 0x909E
        /// </summary>
        PathCoordCountNv = 0x909e,

        /// <summary>
        /// Original was GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F
        /// </summary>
        PathDashArrayCountNv = 0x909f,

        /// <summary>
        /// Original was GL_PATH_COMPUTED_LENGTH_NV = 0x90A0
        /// </summary>
        PathComputedLengthNv = 0x90a0,

        /// <summary>
        /// Original was GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1
        /// </summary>
        PathFillBoundingBoxNv = 0x90a1,

        /// <summary>
        /// Original was GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2
        /// </summary>
        PathStrokeBoundingBoxNv = 0x90a2,

        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4
        /// </summary>
        PathDashOffsetResetNv = 0x90b4
    }
}
