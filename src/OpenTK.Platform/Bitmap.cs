using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// Represents a simple bitmap in a RGBA8 format.
    /// </summary>
    public class Bitmap
    {
        // FIXME: Add stuff like colorspace info?

        /// <summary>
        /// The width of the bitmap in pixels.
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        /// The height of the bitmap in pixels.
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// An array of RGBA8 bytes.
        /// </summary>
        public byte[] Data { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bitmap"/> class with the specified width, height and pixel data.
        /// </summary>
        /// <param name="width">The width of the bitmap.</param>
        /// <param name="height">The height of the bitmap.</param>
        /// <param name="data">The pixel data of the bitmap.</param>
        // FIXME: Document the format of the data!
        public Bitmap(int width, int height, byte[] data)
        {
            if (width * height * 4 > data.Length)
            {
                throw new ArgumentException($"Not enough pixel data provided for bitmap dimentions ({width}x{height}). Expected {width * height * 4}, got: {data.Length}");
            }

            Width = width;
            Height = height;
            Data = data;
        }
    }
}
