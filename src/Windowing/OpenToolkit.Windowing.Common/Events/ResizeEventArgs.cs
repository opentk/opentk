//
// ResizeEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the event data for the window resize event.
    /// </summary>
    public readonly struct ResizeEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResizeEventArgs"/> struct.
        /// </summary>
        /// <param name="width">The new window width.</param>
        /// <param name="height">The new window height.</param>
        public ResizeEventArgs(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Gets the new window width.
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Gets the new window height.
        /// </summary>
        public int Height { get; }
    }
}
