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
    public enum ArbTextureView
    {
        /// <summary>
        /// Original was GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB
        /// </summary>
        TextureViewMinLevel = 0x82db,

        /// <summary>
        /// Original was GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC
        /// </summary>
        TextureViewNumLevels = 0x82dc,

        /// <summary>
        /// Original was GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD
        /// </summary>
        TextureViewMinLayer = 0x82dd,

        /// <summary>
        /// Original was GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE
        /// </summary>
        TextureViewNumLayers = 0x82de,

        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF
        /// </summary>
        TextureImmutableLevels = 0x82df
    }
}
