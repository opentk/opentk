#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using directives ---

using System;
using System.Drawing;
using System.Globalization;

#endregion

namespace OpenTK.Platform
{
    public sealed class DisplayMode
    {
        #region --- Private Variables ---

        private int width, height;
        private ColorDepth color;

        private int depthBits, stencilBits, auxBits;

        private float refreshRate;
        private bool vsync;
        private bool fullscreen;
        private int buffers;
        private bool stereo;

        #endregion

        #region --- Constructors ---

        /// <summary>
        /// Constructs a new DisplayMode from the given parameters.
        /// </summary>
        /// <param name="width">The Width of the DisplayMode, in pixels.</param>
        /// <param name="height">The Height of the DisplayMode, in pixels.</param>
        /// <param name="color">The ColorDepth of the DisplayMode.</param>
        /// <param name="depth">The size of the Depth Buffer, in bits.</param>
        /// <param name="stencil">The size of Stencil Buffer, in bits.</param>
        /// <param name="aux">The size of the Auxilliary Buffer, in bits.</param>
        /// <param name="fullscreen">Set to true for a fullscreen DisplayMode.</param>
        /// <param name="stereo">Set to true for a DisplayMode with stereographic capabilities.</param>
        /// <param name="buffers">The number of Display Buffers. Usually one, two or three.</param>
        /// <param name="vsync">Set to true to sync the updates to the screen refresh rate.</param>
        /// <param name="refresh">The desired RefreshRate. Taken into account only for Fullscreen DisplayModes.</param>
        public DisplayMode(
            int width,
            int height,
            ColorDepth color,
            int depth,
            int stencil,
            int aux,
            int buffers,
            bool fullscreen,
            bool stereo,
            bool vsync,
            float refresh
        )
        {
            this.Width = width;
            this.Height = height;
            this.Color = color;
            this.DepthBits = depth;
            this.StencilBits = stencil;
            this.AuxBits = aux;
            this.Buffers = buffers;
            this.Fullscreen = fullscreen;
            this.Stereo = stereo;
            this.Vsync = vsync;
            this.RefreshRate = refresh;
        }

        /// <summary>
        /// Constructs a new DisplayMode with default values.
        /// </summary>
        public DisplayMode()
            : this(0, 0, new ColorDepth(0), 0, 0, 0, 0, false, false, false, 0.0f)
        {
        }

        /// <summary>
        /// Creates a DisplayMode.
        /// </summary>
        /// <param name="width">The Width of the DisplayMode in pixels.</param>
        /// <param name="height">The Height of the DisplayMode in pixels.</param>
        public DisplayMode(int width, int height)
            : this(width, height, new ColorDepth(0), 0, 0, 0, 0, false, false, false, 0.0f)
        {
        }
        /*
        public DisplayMode(int width, int height, int bpp, int frequency)
            : this(width, height, 0, 0, 0, 0, frequency)
        {
            color = new ColorDepth(bpp);
        }
        */
        /*
        public DisplayMode(int width, int height, int r, int g, int b, int a, int frequency)
        {
            size = new Size(width, height);
            color = new ColorDepth(r, g, b, a);
            displayFrequency = frequency;
        }
        */
        #endregion

        #region --- Public Properties ---

        #region public int Height

        /// <summary>
        /// Gets or sets the Height of the DisplayMode. Height is the vertical span measured in pixels.
        /// </summary>
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0 /* && (value < Screen[0].Height) */)
                {
                    height = value;
                }
            }
        }

        #endregion

        #region public int Width

        /// <summary>
        /// Gets or sets the Width of the DisplayMode. Width is the horizontal span measured in pixels.
        /// </summary>
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0 /* && (value < Screen[0].Width) */)
                {
                    width = value;
                }
            }
        }

        #endregion

        #region public ColorDepth Color

        public ColorDepth Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        #endregion

        public int DepthBits
        {
            get { return this.depthBits; }
            set { this.depthBits = value; }
        }

        public int StencilBits
        {
            get { return this.stencilBits; }
            set { this.stencilBits = value; }
        }

        public int AuxBits
        {
            get { return this.auxBits; }
            set { this.auxBits = value; }
        }

        public bool Stereo
        {
            get { return this.stereo; }
            set { this.stereo = value; }
        }

        public bool Fullscreen
        {
            get { return this.fullscreen; }
            set { this.fullscreen = value; }
        }

        public bool Vsync
        {
            get { return this.vsync; }
            set { this.vsync = value; }
        }

        public int Buffers
        {
            get { return this.buffers; }
            set { this.buffers = value; }
        }

        public float RefreshRate
        {
            get { return this.refreshRate; }
            set { this.refreshRate = value; }
        }


        #endregion

        public override string ToString()
        {
            return string.Format(
                CultureInfo.CurrentCulture,
                "{0}x{1}, {2}, {3}Hz",
                Width, Height,
                Color,
                RefreshRate
            );
        }

    }

    public class DisplayModeMatchOptions { }
}
