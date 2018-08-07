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
    /// Used in GL.EXT.WindowRectangles.
    /// </summary>
    public enum ExtWindowRectangles
    {
        /// <summary>
        /// Original was GL_INCLUSIVE_EXT = 0x8F10
        /// </summary>
        InclusiveExt = 0x8F10,

        /// <summary>
        /// Original was GL_EXCLUSIVE_EXT = 0x8F11
        /// </summary>
        ExclusiveExt = 0x8F11,

        /// <summary>
        /// Original was GL_WINDOW_RECTANGLE_EXT = 0x8F12
        /// </summary>
        WindowRectangleExt = 0x8F12,

        /// <summary>
        /// Original was GL_WINDOW_RECTANGLE_MODE_EXT = 0x8F13
        /// </summary>
        WindowRectangleModeExt = 0x8F13,

        /// <summary>
        /// Original was GL_MAX_WINDOW_RECTANGLES_EXT = 0x8F14
        /// </summary>
        MaxWindowRectanglesExt = 0x8F14,

        /// <summary>
        /// Original was GL_NUM_WINDOW_RECTANGLES_EXT = 0x8F15
        /// </summary>
        NumWindowRectanglesExt = 0x8F15
    }
}
