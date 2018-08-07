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
    /// Not used directly.
    /// </summary>
    public enum GetColorTableParameterPName
    {
        /// <summary>
        /// Original was GL_COLOR_TABLE_SCALE = 0x80D6
        /// </summary>
        ColorTableScale = 0x80D6,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BIAS = 0x80D7
        /// </summary>
        ColorTableBias = 0x80D7,

        /// <summary>
        /// Original was GL_COLOR_TABLE_FORMAT = 0x80D8
        /// </summary>
        ColorTableFormat = 0x80D8,

        /// <summary>
        /// Original was GL_COLOR_TABLE_WIDTH = 0x80D9
        /// </summary>
        ColorTableWidth = 0x80D9,

        /// <summary>
        /// Original was GL_COLOR_TABLE_RED_SIZE = 0x80DA
        /// </summary>
        ColorTableRedSize = 0x80DA,

        /// <summary>
        /// Original was GL_COLOR_TABLE_GREEN_SIZE = 0x80DB
        /// </summary>
        ColorTableGreenSize = 0x80DB,

        /// <summary>
        /// Original was GL_COLOR_TABLE_BLUE_SIZE = 0x80DC
        /// </summary>
        ColorTableBlueSize = 0x80DC,

        /// <summary>
        /// Original was GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD
        /// </summary>
        ColorTableAlphaSize = 0x80DD,

        /// <summary>
        /// Original was GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE
        /// </summary>
        ColorTableLuminanceSize = 0x80DE,

        /// <summary>
        /// Original was GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF
        /// </summary>
        ColorTableIntensitySize = 0x80DF
    }
}
