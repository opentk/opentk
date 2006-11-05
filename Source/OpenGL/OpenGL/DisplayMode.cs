#region --- License ---
/* This source file is released under the MIT license. See License.txt for more information.
 * Coded by Stephen Apostolopoulos.
 */
#endregion

using System;
using System.Drawing;
using System.Globalization;

namespace OpenTK.OpenGL
{
    public class DisplayMode
    {
        #region --- Private Variables ---

        private Size size;
        private ColorDepth color;
        private int displayFrequency;

        #endregion

        #region --- Public Properties ---

        /// <summary>
        /// Gets or sets the Size of the DisplayMode.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Gets or sets the Height of the DisplayMode. Height is the vertical span measured in pixels.
        /// </summary>
        public int Height
        {
            get { return size.Height; }
            set { size.Height = value; }
        }

        /// <summary>
        /// Gets or sets the Width of the DisplayMode. Width is the horizontal span measured in pixels.
        /// </summary>
        public int Width
        {
            get { return size.Width; }
            set { size.Width = value; }
        }

        /// <summary>
        /// Creates a DisplayMode.
        /// </summary>
        /// <param name="width">The Width of the DisplayMode in pixels.</param>
        /// <param name="height">The Height of the DisplayMode in pixels.</param>
        public DisplayMode(int width, int height)
            :this(width, height, 0, 0, 0, 0, 0)
        {
        }

        public DisplayMode(int width, int height, int bpp, int frequency)
            :this(width, height, 0, 0, 0, 0, frequency)
        {
            color = new ColorDepth(bpp);
        }

        public DisplayMode(int width, int height, int r, int g, int b, int a, int frequency)
        {
            size = new Size(width, height);
            color = new ColorDepth(r, g, b, a);
            displayFrequency = frequency;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{0}x{1}, {2}, {3}Hz", Width, Height, color, displayFrequency);
        }

        #endregion
    }
}
