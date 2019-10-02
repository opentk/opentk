//
// Image.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    ///     Contains GLFW Image data.
    /// </summary>
    public unsafe struct Image
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Image"/> struct.
        /// </summary>
        /// <param name="width">The width of the image in pixels.</param>
        /// <param name="height">The height of the image in pixels.</param>
        /// <param name="pixels"><see cref="IntPtr"/> pointing to the RGBA pixel data of the image.</param>
        public Image(int width, int height, byte* pixels)
        {
            Width = width;
            Height = height;
            Pixels = pixels;
        }

        /// <summary>
        /// The width, in pixels, of this <see cref="Image"/>.
        /// </summary>
        public int Width;

        /// <summary>
        /// The height, in pixels, of this <see cref="Image"/>.
        /// </summary>
        public int Height;

        /// <summary>
        /// A <see cref="byte"/> pointer pointing to the RGBA pixel data.
        /// </summary>
        public byte* Pixels;
    }
}
