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
    /// Used in GL.DrawBuffer and GL.EXT.FramebufferDrawBuffer, as well as 2 other functions.
    /// </summary>
    public enum DrawBufferMode
    {
        /// <summary>
        /// Original was GL_NONE = 0x0
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Original was GL_NONE_OES = 0x0
        /// </summary>
        NoneOes = 0x0,

        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x400
        /// </summary>
        FrontLeft = 0x400,

        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x401
        /// </summary>
        FrontRight = 0x401,

        /// <summary>
        /// Original was GL_BACK_LEFT = 0x402
        /// </summary>
        BackLeft = 0x402,

        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x403
        /// </summary>
        BackRight = 0x403,

        /// <summary>
        /// Original was GL_FRONT = 0x404
        /// </summary>
        Front = 0x404,

        /// <summary>
        /// Original was GL_BACK = 0x405
        /// </summary>
        Back = 0x405,

        /// <summary>
        /// Original was GL_LEFT = 0x406
        /// </summary>
        Left = 0x406,

        /// <summary>
        /// Original was GL_RIGHT = 0x407
        /// </summary>
        Right = 0x407,

        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x408
        /// </summary>
        FrontAndBack = 0x408
    }
}
