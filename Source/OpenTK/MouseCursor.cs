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
            new byte[16 * 16 * 4], 16, 16, 0, 0);

        byte[] rgba;
        int width;
        int height;
        int x;
        int y;

        MouseCursor()
        {
        }

        // Todo: make public when byte-order issues are resolved
        internal MouseCursor(byte[] rgba, int width, int height, int x, int y)
        {
            if (rgba == null)
                throw new ArgumentNullException();
            if (width < 0 || width > 256 || height < 0 || height > 256)
                throw new ArgumentOutOfRangeException();
            if (rgba.Length < width * height * 4)
                throw new ArgumentOutOfRangeException();
            if (x < 0 || x >= width || y < 0 || y >= height)
                throw new ArgumentOutOfRangeException();

            this.rgba = rgba;
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }

        internal byte[] Rgba { get { return rgba; } }
        internal int Width { get { return width; } }
        internal int Height { get { return height; } }
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

