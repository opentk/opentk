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
        /// Initializes a new instance of the <see cref="OpenToolkit.Windowing.Common.Input.WindowIcon" /> class.
        /// </summary>
        protected internal WindowIcon()
        {
        }

        private WindowIcon(int width, int height)
        {
            if (width < 0 || width > 256 || height < 0 || height > 256)
            {
                throw new ArgumentOutOfRangeException();
            }

            Width = width;
            Height = height;
        }

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

        internal byte[] Data { get; }
        internal int Width { get; }
        internal int Height { get; }
    }
}
