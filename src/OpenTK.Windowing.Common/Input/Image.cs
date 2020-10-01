//
// WindowIcon.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenTK.Windowing.Common.Input
{
    /// <summary>
    ///     Stores a window icon. A window icon is defined
    ///     as a 2-dimensional buffer of RGBA values.
    /// </summary>
    public class Image
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="width">The icon pixel width.</param>
        /// <param name="height">The icon pixel height.</param>
        /// <param name="data">The RGBA pixel data of the icon.</param>
        public Image(int width, int height, byte[] data)
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }

            if (data.Length < Width * Height * 4)
            {
                throw new ArgumentOutOfRangeException();
            }

            Width = width;
            Height = height;
            Data = data;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        protected Image()
        {
        }

        /// <summary>
        ///     Gets the icon pixel width.
        /// </summary>
        public int Width { get; }

        /// <summary>
        ///     Gets the icon pixel height.
        /// </summary>
        public int Height { get; }

        /// <summary>
        ///     Gets the RGBA pixel data of the icon.
        /// </summary>
        public byte[] Data { get; }
    }
}
