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
    public enum KhrContextFlushControl
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Original was GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB
        /// </summary>
        ContextReleaseBehavior = 0x82fb,

        /// <summary>
        /// Original was GL_CONTEXT_RELEASE_BEHAVIOR_KHR = 0x82FB
        /// </summary>
        ContextReleaseBehaviorKhr = 0x82fb,

        /// <summary>
        /// Original was GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC
        /// </summary>
        ContextReleaseBehaviorFlush = 0x82fc,

        /// <summary>
        /// Original was GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR = 0x82FC
        /// </summary>
        ContextReleaseBehaviorFlushKhr = 0x82fc
    }
}
