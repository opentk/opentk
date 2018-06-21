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
    /// Used in GL.Apple.GetObjectParameter, GL.Apple.ObjectPurgeable and 1 other function
    /// </summary>
    public enum AppleObjectPurgeable
    {
        /// <summary>
        /// Original was GL_BUFFER_OBJECT_APPLE = 0x85B3
        /// </summary>
        BufferObjectApple = 0x85b3,

        /// <summary>
        /// Original was GL_RELEASED_APPLE = 0x8A19
        /// </summary>
        ReleasedApple = 0x8a19,

        /// <summary>
        /// Original was GL_VOLATILE_APPLE = 0x8A1A
        /// </summary>
        VolatileApple = 0x8a1a,

        /// <summary>
        /// Original was GL_RETAINED_APPLE = 0x8A1B
        /// </summary>
        RetainedApple = 0x8a1b,

        /// <summary>
        /// Original was GL_UNDEFINED_APPLE = 0x8A1C
        /// </summary>
        UndefinedApple = 0x8a1c,

        /// <summary>
        /// Original was GL_PURGEABLE_APPLE = 0x8A1D
        /// </summary>
        PurgeableApple = 0x8a1d
    }
}
