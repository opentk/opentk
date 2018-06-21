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
    /// Used in GL.Sun.ReplacementCodePointer
    /// </summary>
    public enum SunTriangleList
    {
        /// <summary>
        /// Original was GL_RESTART_SUN = 0x0001
        /// </summary>
        RestartSun = 0x0001,

        /// <summary>
        /// Original was GL_REPLACE_MIDDLE_SUN = 0x0002
        /// </summary>
        ReplaceMiddleSun = 0x0002,

        /// <summary>
        /// Original was GL_REPLACE_OLDEST_SUN = 0x0003
        /// </summary>
        ReplaceOldestSun = 0x0003,

        /// <summary>
        /// Original was GL_TRIANGLE_LIST_SUN = 0x81D7
        /// </summary>
        TriangleListSun = 0x81d7,

        /// <summary>
        /// Original was GL_REPLACEMENT_CODE_SUN = 0x81D8
        /// </summary>
        ReplacementCodeSun = 0x81d8,

        /// <summary>
        /// Original was GL_REPLACEMENT_CODE_ARRAY_SUN = 0x85C0
        /// </summary>
        ReplacementCodeArraySun = 0x85c0,

        /// <summary>
        /// Original was GL_REPLACEMENT_CODE_ARRAY_TYPE_SUN = 0x85C1
        /// </summary>
        ReplacementCodeArrayTypeSun = 0x85c1,

        /// <summary>
        /// Original was GL_REPLACEMENT_CODE_ARRAY_STRIDE_SUN = 0x85C2
        /// </summary>
        ReplacementCodeArrayStrideSun = 0x85c2,

        /// <summary>
        /// Original was GL_REPLACEMENT_CODE_ARRAY_POINTER_SUN = 0x85C3
        /// </summary>
        ReplacementCodeArrayPointerSun = 0x85c3,

        /// <summary>
        /// Original was GL_R1UI_V3F_SUN = 0x85C4
        /// </summary>
        R1uiV3fSun = 0x85c4,

        /// <summary>
        /// Original was GL_R1UI_C4UB_V3F_SUN = 0x85C5
        /// </summary>
        R1uiC4ubV3fSun = 0x85c5,

        /// <summary>
        /// Original was GL_R1UI_C3F_V3F_SUN = 0x85C6
        /// </summary>
        R1uiC3fV3fSun = 0x85c6,

        /// <summary>
        /// Original was GL_R1UI_N3F_V3F_SUN = 0x85C7
        /// </summary>
        R1uiN3fV3fSun = 0x85c7,

        /// <summary>
        /// Original was GL_R1UI_C4F_N3F_V3F_SUN = 0x85C8
        /// </summary>
        R1uiC4fN3fV3fSun = 0x85c8,

        /// <summary>
        /// Original was GL_R1UI_T2F_V3F_SUN = 0x85C9
        /// </summary>
        R1uiT2fV3fSun = 0x85c9,

        /// <summary>
        /// Original was GL_R1UI_T2F_N3F_V3F_SUN = 0x85CA
        /// </summary>
        R1uiT2fN3fV3fSun = 0x85ca,

        /// <summary>
        /// Original was GL_R1UI_T2F_C4F_N3F_V3F_SUN = 0x85CB
        /// </summary>
        R1uiT2fC4fN3fV3fSun = 0x85cb
    }
}
