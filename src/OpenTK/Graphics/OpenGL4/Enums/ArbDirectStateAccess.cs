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

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbDirectStateAccess
    {
        /// <summary>
        /// Original was GL_TEXTURE_TARGET = 0x1006
        /// </summary>
        TextureTarget = 0x1006,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_1D = 0x8068
        /// </summary>
        TextureBinding1D = 0x8068,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D = 0x8069
        /// </summary>
        TextureBinding2D = 0x8069,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_3D = 0x806A
        /// </summary>
        TextureBinding3D = 0x806a,

        /// <summary>
        /// Original was GL_QUERY_TARGET = 0x82EA
        /// </summary>
        QueryTarget = 0x82ea,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_RECTANGLE = 0x84F6
        /// </summary>
        TextureBindingRectangle = 0x84f6,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP = 0x8514
        /// </summary>
        TextureBindingCubeMap = 0x8514,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C
        /// </summary>
        TextureBinding1DArray = 0x8c1c,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D
        /// </summary>
        TextureBinding2DArray = 0x8c1d,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_BUFFER = 0x8C2C
        /// </summary>
        TextureBindingBuffer = 0x8c2c,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A
        /// </summary>
        TextureBindingCubeMapArray = 0x900a,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104
        /// </summary>
        TextureBinding2DMultisample = 0x9104,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105
        /// </summary>
        TextureBinding2DMultisampleArray = 0x9105
    }
}
