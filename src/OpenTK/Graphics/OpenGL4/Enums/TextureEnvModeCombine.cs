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

#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureEnvModeCombine
    {
        /// <summary>
        /// Original was GL_ADD = 0x0104
        /// </summary>
        Add = 0x0104,

        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = 0x1e01,

        /// <summary>
        /// Original was GL_MODULATE = 0x2100
        /// </summary>
        Modulate = 0x2100,

        /// <summary>
        /// Original was GL_SUBTRACT = 0x84E7
        /// </summary>
        Subtract = 0x84e7,

        /// <summary>
        /// Original was GL_ADD_SIGNED = 0x8574
        /// </summary>
        AddSigned = 0x8574,

        /// <summary>
        /// Original was GL_INTERPOLATE = 0x8575
        /// </summary>
        Interpolate = 0x8575,

        /// <summary>
        /// Original was GL_DOT3_RGB = 0x86AE
        /// </summary>
        Dot3Rgb = 0x86ae,

        /// <summary>
        /// Original was GL_DOT3_RGBA = 0x86AF
        /// </summary>
        Dot3Rgba = 0x86af
    }
}
