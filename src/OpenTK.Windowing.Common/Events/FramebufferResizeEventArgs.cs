//
// FramebufferResizeEventArgs.cs
//
// Copyright (C) 2023 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//
using OpenTK.Mathematics;

namespace OpenTK.Windowing.Common
{
    /// <summary>
    /// Defines the event data for the framebuffer resize event.
    /// </summary>
    public readonly struct FramebufferResizeEventArgs
    {
        /// <summary>
        /// Gets the new framebuffer size.
        /// </summary>
        public Vector2i Size { get; }

        /// <summary>
        /// Gets the new framebuffer width.
        /// </summary>
        public int Width => Size.X;

        /// <summary>
        /// Gets the new framebuffer height.
        /// </summary>
        public int Height => Size.Y;

        /// <summary>
        /// Initializes a new instance of the <see cref="FramebufferResizeEventArgs"/> struct.
        /// </summary>
        /// <param name="size">the new framebuffer size.</param>
        public FramebufferResizeEventArgs(Vector2i size)
        {
            Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FramebufferResizeEventArgs"/> struct.
        /// </summary>
        /// <param name="width">The new framebuffer width.</param>
        /// <param name="height">The new framebuffer height.</param>
        public FramebufferResizeEventArgs(int width, int height)
            : this(new Vector2i(width, height))
        {
        }
    }
}
