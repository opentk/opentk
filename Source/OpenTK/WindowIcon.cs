// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

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

