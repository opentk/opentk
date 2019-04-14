//
// ResizeEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the event data for the window resize event.
    /// </summary>
    public class ResizeEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResizeEventArgs"/> class.
        /// </summary>
        public ResizeEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResizeEventArgs"/> class
        /// from a second <see cref="ResizeEventArgs"/> which is copied.
        /// </summary>
        /// <param name="other">The <see cref="ResizeEventArgs"/> to copy.</param>
        public ResizeEventArgs(ResizeEventArgs other)
        {
            this.Width = other.Width;
            this.Height = other.Height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResizeEventArgs"/> class.
        /// </summary>
        /// <param name="width">The new window width.</param>
        /// <param name="height">The new window height.</param>
        internal ResizeEventArgs(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets the new window width.
        /// </summary>
        public int Width { get; internal set; }

        /// <summary>
        /// Gets the new window height.
        /// </summary>
        public int Height { get; internal set; }
    }
}
