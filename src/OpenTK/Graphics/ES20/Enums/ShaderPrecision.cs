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
    /// Used in GL.GetShaderPrecisionFormat
    /// </summary>
    public enum ShaderPrecision
    {
        /// <summary>
        /// Original was GL_LowFloat = 0X8df0
        /// </summary>
        LowFloat = 0X8df0,

        /// <summary>
        /// Original was GL_MediumFloat = 0X8df1
        /// </summary>
        MediumFloat = 0X8df1,

        /// <summary>
        /// Original was GL_HighFloat = 0X8df2
        /// </summary>
        HighFloat = 0X8df2,

        /// <summary>
        /// Original was GL_LowInt = 0X8df3
        /// </summary>
        LowInt = 0X8df3,

        /// <summary>
        /// Original was GL_MediumInt = 0X8df4
        /// </summary>
        MediumInt = 0X8df4,

        /// <summary>
        /// Original was GL_HighInt = 0X8df5
        /// </summary>
        HighInt = 0X8df5
    }
}
