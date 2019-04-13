//
// MouseCursor.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.Common.Input
{
    /// <summary>
    /// Represents a predefined or custom mouse cursor.
    /// </summary>
    public sealed class MouseCursor : Image
    {
        /// <summary>
        /// Gets the default mouse cursor for this platform.
        /// </summary>
        public static MouseCursor Default { get; } = new MouseCursor();

        /// <summary>
        /// Gets an empty (invisible) mouse cursor.
        /// </summary>
        public static MouseCursor Empty { get; } = new MouseCursor(
            0, 0, 16, 16, new byte[16 * 16 * 4]);

        private MouseCursor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseCursor" /> class from a
        /// contiguous array of RGBA pixels.
        /// Each pixel is composed of 4 bytes, representing R, G, B and A values,
        /// respectively. On some backends, the R, G, and B components should be premultiplied with the A component
        /// for correct antialiasing of translucent cursors:
        /// <code>
        /// B = (byte)((B * A) / 255)
        /// G = (byte)((G * A) / 255)
        /// R = (byte)((R * A) / 255)
        /// </code>
        /// </summary>
        /// <param name="hotX">The x-coordinate of the cursor hotspot, in the range [0, width].</param>
        /// <param name="hotY">The y-coordinate of the cursor hotspot, in the range [0, height].</param>
        /// <param name="width">The width of the cursor data, in pixels.</param>
        /// <param name="height">The height of the cursor data, in pixels.</param>
        /// <param name="data">
        /// A byte array representing the cursor image,
        /// laid out as a contiguous array of RGBA pixels.
        /// </param>
        public MouseCursor(int hotX, int hotY, int width, int height, byte[] data)
            : base(width, height, data)
        {
            if (hotX < 0 || hotX >= Width || hotY < 0 || hotY >= Height)
            {
                throw new ArgumentOutOfRangeException();
            }

            X = hotX;
            Y = hotY;
        }

        /// <summary>
        /// Gets the x-coordinate of the cursor hotspot.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Gets the y-coordinate of the cursor hotspot.
        /// </summary>
        public int Y { get; }
    }
}
