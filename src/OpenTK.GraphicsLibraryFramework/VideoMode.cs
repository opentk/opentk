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
        private int _width;
        private int _height;
        private int _redBits;
        private int _greenBits;
        private int _blueBits;
        private int _refreshRate;

        /// <summary>
        /// Gets the width, in screen coordinates, of the <see cref="VideoMode"/>.
        /// </summary>
        public int Width => _width;

        /// <summary>
        /// Gets the height, in screen coordinates, of the <see cref="VideoMode"/>.
        /// </summary>
        public int Height => _height;

        /// <summary>
        /// Gets the bit depth of the red channel of the <see cref="VideoMode"/>.
        /// </summary>
        public int RedBits => _redBits;

        /// <summary>
        /// Gets the bit depth of the green channel of the <see cref="VideoMode"/>.
        /// </summary>
        public int GreenBits => _greenBits;

        /// <summary>
        /// Gets the bit depth of the blue channel of the <see cref="VideoMode"/>.
        /// </summary>
        public int BlueBits => _blueBits;

        /// <summary>
        /// Gets the refresh rate, in Hz, of the <see cref="VideoMode"/>.
        /// </summary>
        public int RefreshRate => _refreshRate;
    }
}
