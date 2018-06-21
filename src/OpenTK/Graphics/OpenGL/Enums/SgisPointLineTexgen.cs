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
    /// Not used directly.
    /// </summary>
    public enum SgisPointLineTexgen
    {
        /// <summary>
        /// Original was GL_EYE_DISTANCE_TO_POINT_SGIS = 0x81F0
        /// </summary>
        EyeDistanceToPointSgis = 0x81f0,

        /// <summary>
        /// Original was GL_OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1
        /// </summary>
        ObjectDistanceToPointSgis = 0x81f1,

        /// <summary>
        /// Original was GL_EYE_DISTANCE_TO_LINE_SGIS = 0x81F2
        /// </summary>
        EyeDistanceToLineSgis = 0x81f2,

        /// <summary>
        /// Original was GL_OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3
        /// </summary>
        ObjectDistanceToLineSgis = 0x81f3,

        /// <summary>
        /// Original was GL_EYE_POINT_SGIS = 0x81F4
        /// </summary>
        EyePointSgis = 0x81f4,

        /// <summary>
        /// Original was GL_OBJECT_POINT_SGIS = 0x81F5
        /// </summary>
        ObjectPointSgis = 0x81f5,

        /// <summary>
        /// Original was GL_EYE_LINE_SGIS = 0x81F6
        /// </summary>
        EyeLineSgis = 0x81f6,

        /// <summary>
        /// Original was GL_OBJECT_LINE_SGIS = 0x81F7
        /// </summary>
        ObjectLineSgis = 0x81f7
    }
}
