#region License
//
// Cursor.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;

namespace OpenTK
{
    /// <summary>
    /// Represents a predefined or custom mouse cursor.
    /// </summary>
    public sealed class MouseCursor : WindowIcon
    {
        static readonly MouseCursor default_cursor = new MouseCursor();
        static readonly MouseCursor empty_cursor = new MouseCursor(
            0, 0, 16, 16, new byte[16 * 16 * 4]);

        int x;
        int y;

        MouseCursor()
        {
        }

        /// <summary>
        /// Initializes a new <see cref="MouseCursor"/> instance from a
        /// contiguous array of BGRA pixels.
        /// Each pixel is composed of 4 bytes, representing B, G, R and A values,
        /// respectively. For correct antialiasing of translucent cursors,
        /// the B, G and R components should be premultiplied with the A component:
        /// <code>
        /// B = (byte)((B * A) / 255)
        /// G = (byte)((G * A) / 255)
        /// R = (byte)((R * A) / 255)
        /// </code>
        /// </summary>
        /// <param name="hotx">The x-coordinate of the cursor hotspot, in the range [0, width]</param>
        /// <param name="hoty">The y-coordinate of the cursor hotspot, in the range [0, height]</param>
        /// <param name="width">The width of the cursor data, in pixels.</param>
        /// <param name="height">The height of the cursor data, in pixels.</param>
        /// <param name="data">
        /// A byte array representing the cursor image,
        /// laid out as a contiguous array of BGRA pixels.
        /// </param>
        public MouseCursor(int hotx, int hoty, int width, int height, byte[] data)
            : base(width, height, data)
        {
            if (hotx < 0 || hotx >= Width || hoty < 0 || hoty >= Height)
                throw new ArgumentOutOfRangeException();

            x = hotx;
            y = hoty;
        }

        /// <summary>
        /// Initializes a new <see cref="MouseCursor"/> instance from a
        /// contiguous array of BGRA pixels.
        /// Each pixel is composed of 4 bytes, representing B, G, R and A values,
        /// respectively. For correct antialiasing of translucent cursors,
        /// the B, G and R components should be premultiplied with the A component:
        /// <code>
        /// B = (byte)((B * A) / 255)
        /// G = (byte)((G * A) / 255)
        /// R = (byte)((R * A) / 255)
        /// </code>
        /// </summary>
        /// <param name="hotx">The x-coordinate of the cursor hotspot, in the range [0, width]</param>
        /// <param name="hoty">The y-coordinate of the cursor hotspot, in the range [0, height]</param>
        /// <param name="width">The width of the cursor data, in pixels.</param>
        /// <param name="height">The height of the cursor data, in pixels.</param>
        /// <param name="data">
        /// A pointer to the cursor image, laid out as a contiguous array of BGRA pixels.
        /// </param>
        public MouseCursor(int hotx, int hoty, int width, int height, IntPtr data)
            : base(width, height, data)
        {
            if (hotx < 0 || hotx >= Width || hoty < 0 || hoty >= Height)
                throw new ArgumentOutOfRangeException();

            x = hotx;
            y = hoty;
        }

        internal int X { get { return x; } }
        internal int Y { get { return y; } }

        /// <summary>
        /// Gets the default mouse cursor for this platform.
        /// </summary>
        public static MouseCursor Default
        {
            get
            {
                return default_cursor;
            }
        }

        /// <summary>
        /// Gets an empty (invisible) mouse cursor.
        /// </summary>
        public static MouseCursor Empty
        {
            get
            {
                return empty_cursor;
            }
        }
    }
}

