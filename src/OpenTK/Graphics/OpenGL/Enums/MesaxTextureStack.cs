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
    public enum MesaxTextureStack
    {
        /// <summary>
        /// Original was GL_TEXTURE_1D_STACK_MESAX = 0x8759
        /// </summary>
        Texture1DStackMesax = 0x8759,

        /// <summary>
        /// Original was GL_TEXTURE_2D_STACK_MESAX = 0x875A
        /// </summary>
        Texture2DStackMesax = 0x875a,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_STACK_MESAX = 0x875B
        /// </summary>
        ProxyTexture1DStackMesax = 0x875b,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_STACK_MESAX = 0x875C
        /// </summary>
        ProxyTexture2DStackMesax = 0x875c,

        /// <summary>
        /// Original was GL_TEXTURE_1D_STACK_BINDING_MESAX = 0x875D
        /// </summary>
        Texture1DStackBindingMesax = 0x875d,

        /// <summary>
        /// Original was GL_TEXTURE_2D_STACK_BINDING_MESAX = 0x875E
        /// </summary>
        Texture2DStackBindingMesax = 0x875e
    }
}
