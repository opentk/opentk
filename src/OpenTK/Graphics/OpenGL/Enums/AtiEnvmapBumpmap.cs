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
    /// Used in GL.Ati.GetTexBumpParameter, GL.Ati.TexBumpParameter
    /// </summary>
    public enum AtiEnvmapBumpmap
    {
        /// <summary>
        /// Original was GL_BUMP_ROT_MATRIX_ATI = 0x8775
        /// </summary>
        BumpRotMatrixAti = 0x8775,

        /// <summary>
        /// Original was GL_BUMP_ROT_MATRIX_SIZE_ATI = 0x8776
        /// </summary>
        BumpRotMatrixSizeAti = 0x8776,

        /// <summary>
        /// Original was GL_BUMP_NUM_TEX_UNITS_ATI = 0x8777
        /// </summary>
        BumpNumTexUnitsAti = 0x8777,

        /// <summary>
        /// Original was GL_BUMP_TEX_UNITS_ATI = 0x8778
        /// </summary>
        BumpTexUnitsAti = 0x8778,

        /// <summary>
        /// Original was GL_DUDV_ATI = 0x8779
        /// </summary>
        DudvAti = 0x8779,

        /// <summary>
        /// Original was GL_DU8DV8_ATI = 0x877A
        /// </summary>
        Du8Dv8Ati = 0x877a,

        /// <summary>
        /// Original was GL_BUMP_ENVMAP_ATI = 0x877B
        /// </summary>
        BumpEnvmapAti = 0x877b,

        /// <summary>
        /// Original was GL_BUMP_TARGET_ATI = 0x877C
        /// </summary>
        BumpTargetAti = 0x877c
    }
}
