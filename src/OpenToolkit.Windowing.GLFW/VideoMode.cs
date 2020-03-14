//
// VideoMode.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Runtime.InteropServices;

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Replicated handle to a GLFW VideoMode.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VideoMode
    {
        /// <summary>
        /// The width, in screen coordinates, of the <see cref="VideoMode"/>.
        /// </summary>
        public int Width;

        /// <summary>
        /// The height, in screen coordinates, of the <see cref="VideoMode"/>.
        /// </summary>
        public int Height;

        /// <summary>
        /// The bit depth of the red channel of the <see cref="VideoMode"/>.
        /// </summary>
        public int RedBits;

        /// <summary>
        /// The bit depth of the green channel of the <see cref="VideoMode"/>.
        /// </summary>
        public int GreenBits;

        /// <summary>
        /// The bit depth of the blue channel of the <see cref="VideoMode"/>.
        /// </summary>
        public int BlueBits;

        /// <summary>
        /// The refresh rate, in Hz, of the <see cref="VideoMode"/>.
        /// </summary>
        public int RefreshRate;
    }
}
