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

namespace OpenTK.Graphics.ES20
{
    /// <summary>
    /// Used in GL.BlendFunc, GL.BlendFuncSeparate
    /// </summary>
    public enum BlendingFactorDest
    {
        /// <summary>
        /// Original was GL_Zero = 0
        /// </summary>
        Zero = 0,

        /// <summary>
        /// Original was GL_SrcColor = 0X0300
        /// </summary>
        SrcColor = 0X0300,

        /// <summary>
        /// Original was GL_OneMinusSrcColor = 0X0301
        /// </summary>
        OneMinusSrcColor = 0X0301,

        /// <summary>
        /// Original was GL_SrcAlpha = 0X0302
        /// </summary>
        SrcAlpha = 0X0302,

        /// <summary>
        /// Original was GL_OneMinusSrcAlpha = 0X0303
        /// </summary>
        OneMinusSrcAlpha = 0X0303,

        /// <summary>
        /// Original was GL_DstAlpha = 0X0304
        /// </summary>
        DstAlpha = 0X0304,

        /// <summary>
        /// Original was GL_OneMinusDstAlpha = 0X0305
        /// </summary>
        OneMinusDstAlpha = 0X0305,

        /// <summary>
        /// Original was GL_DstColor = 0X0306
        /// </summary>
        DstColor = 0X0306,

        /// <summary>
        /// Original was GL_OneMinusDstColor = 0X0307
        /// </summary>
        OneMinusDstColor = 0X0307,

        /// <summary>
        /// Original was GL_SrcAlphaSaturate = 0X0308
        /// </summary>
        SrcAlphaSaturate = 0X0308,

        /// <summary>
        /// Original was GL_ConstantColor = 0X8001
        /// </summary>
        ConstantColor = 0X8001,

        /// <summary>
        /// Original was GL_OneMinusConstantColor = 0X8002
        /// </summary>
        OneMinusConstantColor = 0X8002,

        /// <summary>
        /// Original was GL_ConstantAlpha = 0X8003
        /// </summary>
        ConstantAlpha = 0X8003,

        /// <summary>
        /// Original was GL_OneMinusConstantAlpha = 0X8004
        /// </summary>
        OneMinusConstantAlpha = 0X8004,

        /// <summary>
        /// Original was GL_One = 1
        /// </summary>
        One = 1
    }
}
