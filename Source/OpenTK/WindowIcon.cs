#region License
//
// WindowIcon.cs
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
using System.Runtime.InteropServices;

namespace OpenTK
{
    /// <summary>
    /// Stores a window icon. A window icon is defined
    /// as a 2-dimensional buffer of RGBA values.
    /// </summary>
    public class WindowIcon
    {
        byte[] data;
        int width;
        int height;

        /// \internal
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenTK.WindowIcon"/> class.
        /// </summary>
        internal protected WindowIcon()
        {
        }

        WindowIcon(int width, int height)
        {
            if (width < 0 || width > 256 || height < 0 || height > 256)
                throw new ArgumentOutOfRangeException();

            this.width = width;
            this.height = height;
        }

        internal WindowIcon(int width, int height, byte[] data)
            : this(width, height)
        {
            if (data == null)
                throw new ArgumentNullException();
            if (data.Length < Width * Height * 4)
                throw new ArgumentOutOfRangeException();

            this.data = data;
        }

        internal WindowIcon(int width, int height, IntPtr data)
            : this(width, height)
        {
            if (data == IntPtr.Zero)
                throw new ArgumentNullException();

            // We assume that width and height are correctly set.
            // If they are not, we will read garbage and probably
            // crash.
            this.data = new byte[width * height * 4];
            Marshal.Copy(data, this.data, 0, this.data.Length);
        }

        internal byte[] Data { get { return data; } }
        internal int Width { get { return width; } }
        internal int Height { get { return height; } }
    }
}

