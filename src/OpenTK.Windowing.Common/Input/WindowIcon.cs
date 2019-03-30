//
// WindowIcon.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.Windowing.Common.Input
{
    /// <summary>
    /// Stores a window icon. A window icon is defined
    /// as a 2-dimensional buffer of RGBA values.
    /// </summary>
    public class WindowIcon
    {
        /// \internal
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowIcon" /> class.
        /// </summary>
        protected internal WindowIcon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowIcon" /> class.
        /// </summary>
        /// <param name="width">The icon pixel width.</param>
        /// <param name="height">The icon pixel height.</param>
        private WindowIcon(int width, int height)
        {
            if (width < 0 || width > 256 || height < 0 || height > 256)
            {
                throw new ArgumentOutOfRangeException();
            }

            Width = width;
            Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowIcon" /> class.
        /// </summary>
        /// <param name="width">The icon pixel width.</param>
        /// <param name="height">The icon pixel height.</param>
        /// <param name="data">The RGBA pixel data of the icon.</param>
        internal WindowIcon(int width, int height, byte[] data)
            : this(width, height)
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }

            if (data.Length < Width * Height * 4)
            {
                throw new ArgumentOutOfRangeException();
            }

            Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowIcon" /> class.
        /// </summary>
        /// <param name="width">The icon pixel width.</param>
        /// <param name="height">The icon pixel height.</param>
        /// <param name="data">Pointer to the RGBA pixel data of the icon.</param>
        internal WindowIcon(int width, int height, IntPtr data)
            : this(width, height)
        {
            if (data == IntPtr.Zero)
            {
                throw new ArgumentNullException();
            }

            // We assume that width and height are correctly set.
            // If they are not, we will read garbage and probably
            // crash.
            Data = new byte[width * height * 4];
            Marshal.Copy(data, Data, 0, Data.Length);
        }

        /// <summary>
        /// Gets the RGBA pixel data of the icon.
        /// </summary>
        internal byte[] Data { get; }

        /// <summary>
        /// Gets the icon pixel width.
        /// </summary>
        internal int Width { get; }

        /// <summary>
        /// Gets the icon pixel height.
        /// </summary>
        internal int Height { get; }
    }
}
