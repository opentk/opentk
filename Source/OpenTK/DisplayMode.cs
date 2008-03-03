#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

#region --- Using directives ---

using System;
using System.Drawing;
using System.Globalization;

#endregion

namespace OpenTK
{
    using OpenTK.Graphics;

    /// <summary>Defines the display mode for a render window.</summary>
    [Obsolete]
    public sealed class DisplayMode
    {
        #region --- Private Variables ---

        private int width, height;
        private ColorMode color_format, auxilliary_color_format;

        private int depthBits, stencilBits;

        private float refreshRate;
        private bool vsync;
        private bool fullscreen;
        private int buffers;
        private bool stereo;

        #endregion

        #region --- Constructors ---

        public DisplayMode(DisplayMode mode)
            : this(mode.width, mode.height, mode.color_format, mode.depthBits, mode.stencilBits, mode.auxilliary_color_format.BitsPerPixel,
                   mode.buffers, mode.fullscreen, mode.stereo, mode.vsync, mode.refreshRate) { }

        public DisplayMode() : this(640, 480) { }

        /// <summary>
        /// Constructs a new DisplayMode from the specified parameters.
        /// </summary>
        /// <param name="width">The Width of the DisplayMode, in pixels.</param>
        /// <param name="height">The Height of the DisplayMode, in pixels.</param>
        /// <param name="color">The ColorMode of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        /// <param name="aux">The number of bits in the auxilliary buffer.</param>
        /// <param name="fullscreen">Set to true for a fullscreen DisplayMode.</param>
        /// <param name="stereo">Set to true for a DisplayMode with stereographic capabilities.</param>
        /// <param name="buffers">The number of render buffers. Typical values include one (single-), two (double-) or three (triple-buffering).</param>
        /// <param name="vsync">Set to true to sync the updates to the screen refresh rate.</param>
        /// <param name="refresh">The desired RefreshRate. Taken into account only for Fullscreen DisplayModes.</param>
        public DisplayMode(int width, int height, ColorMode color, int depth, int stencil, int aux, int buffers,
            bool fullscreen, bool stereo, bool vsync, float refresh)
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
        /// Constructs a new DisplayMode.
        /// </summary>
        /// <param name="width">The Width of the DisplayMode in pixels.</param>
        /// <param name="height">The Height of the DisplayMode in pixels.</param>
        public DisplayMode(int width, int height)
            : this(width, height, DisplayDevice.Default.BitsPerPixel, 16, 0, 0, 2, false, false, false, 0.0f)
        {
        }

        /// <summary>
        /// Constructs a new DisplayMode.
        /// </summary>
        /// <param name="width">The Width of the DisplayMode in pixels.</param>
        /// <param name="height">The Height of the DisplayMode in pixels.</param>
        /// <param name="color">The ColorMode of the color buffer.</param>
        public DisplayMode(int width, int height, ColorMode color)
            : this(width, height, color, 16, 0, 0, 2, false, false, false, 0.0f)
        {
        }

        /// <summary>
        /// Constructs a new DisplayMode.
        /// </summary>
        /// <param name="width">The Width of the DisplayMode in pixels.</param>
        /// <param name="height">The Height of the DisplayMode in pixels.</param>
        /// <param name="color">The ColorMode of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        public DisplayMode(int width, int height, ColorMode color, int depth)
            : this(width, height, color, depth, 0, 0, 2, false, false, false, 0.0f)
        {
        }

        /// <summary>
        /// Constructs a new DisplayMode.
        /// </summary>
        /// <param name="width">The Width of the DisplayMode in pixels.</param>
        /// <param name="height">The Height of the DisplayMode in pixels.</param>
        /// <param name="color">The ColorMode of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="fullscreen">True for a fullscreen DisplayMode, false otherwise.</param>
        public DisplayMode(int width, int height, ColorMode color, int depth, bool fullscreen)
            : this(width, height, color, depth, 0, 0, 2, fullscreen, false, false, 0.0f)
        {
        }

        #endregion

        #region --- Public Properties ---
#if false
        #region public int ColorDepth

        /// <summary>
        /// Gets an OpenTK.Graphics.ColorMode that describes the color format of this DisplayMode.
        /// </summary>
        public ColorMode ColorDepth
        {
            get { return color_format; }
            private set { color_format = value; }
        }

        #endregion

        #region public int AuxilliaryColorDepth

        /// <summary>
        /// Gets an OpenTK.Graphics.ColorMode that describes the color format of this DisplayMode.
        /// </summary>
        public ColorMode AuxilliaryColorDepth
        {
            get { return auxilliary_color_format; }
            private set { auxilliary_color_format = value; }
        }

        #endregion

        #region public int Depth

        /// <summary>
        /// Gets a System.Int32 that contains the bits per pixel for the depth buffer
        /// of this DisplayMode.
        /// </summary>
        public int Depth
        {
            get { return depthBits; }
            private set { depthBits = value; }
        }

        #endregion

        #region public int Stencil

        /// <summary>
        /// Gets a System.Int32 that contains the bits per pixel for the stencil buffer
        /// of this DisplayMode.
        /// </summary>
        public int Stencil
        {
            get { return stencilBits; }
            private set { stencilBits = value; }
        }

        #endregion
#endif
        #region Obsolete Properties

        #region public bool Stereo

        /// <summary>
        /// Gets a System.Boolean indicating whether this DisplayMode is stereoscopic.
        /// </summary>
        [Obsolete("Use GraphicsMode.Stereo instead.")]
        public bool Stereo
        {
            get { return this.stereo; }
            private set { this.stereo = value; }
        }

        #endregion

        #region public int Buffers

        /// <summary>
        /// Gets a System.Int32 containing the number of buffers associated with this
        /// DisplayMode.
        /// </summary>
        [Obsolete("Use GraphicsMode.Buffers instead.")]
        public int Buffers
        {
            get { return this.buffers; }
            private set { this.buffers = value; }
        }

        #endregion

        [Obsolete("Use GameWindow.Fullscreen instead.")]
        public bool Fullscreen
        {
            get { return this.fullscreen; }
            internal set { this.fullscreen = value; }
        }

        [Obsolete("Use GraphicsContext.VSync, GLControl.VSync or GameWindow.VSync instead.")]
        public bool Vsync
        {
            get { return this.vsync; }
            internal set { this.vsync = value; }
        }

        [Obsolete("Use OpenTK.Graphics.DisplayDevice.RefreshRate instead.")]
        public float RefreshRate
        {
            get { return this.refreshRate; }
            private set { this.refreshRate = value; }
        }

        #region public ColorFormat Color
        
        [Obsolete("Use GraphicsMode.Color instead.")]
        public ColorMode Color
        {
            get { return this.color_format; }
            internal set { this.color_format = value; }
        }

        #endregion

        #region public int Height

        /// <summary>
        /// Gets or sets the Height of the DisplayMode. Height is the vertical span measured in pixels.
        /// </summary>
        [Obsolete("Use GameWindow.Height or GLControl.Height instead.")]
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
        [Obsolete("Use GameWindow.Width or GLControl.Width instead.")]
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
            }
        }

        #endregion

        [Obsolete("Use GraphicsMode.Depth instead.")]
        public int DepthBits
        {
            get { return this.depthBits; }
            internal set { this.depthBits = value; }
        }

        [Obsolete("Use GraphicsMode.Stencil instead.")]
        public int StencilBits
        {
            get { return this.stencilBits; }
            internal set { this.stencilBits = value; }
        }

        [Obsolete("Use GraphicsMode.AuxilliaryColorDepth instead.")]
        public int AuxBits
        {
            get { return this.auxilliary_color_format.BitsPerPixel; }
            internal set { this.auxilliary_color_format = value; }
        }

        #endregion

        #endregion

        internal GraphicsMode ToGraphicsMode()
        {
            return new GraphicsMode(this.Color.BitsPerPixel, this.DepthBits, this.StencilBits, 0, this.AuxBits, this.Buffers, this.Stereo);
        }

        #region --- Overrides ---

        /// <summary>
        /// Describes this DisplayMode instance.
        /// </summary>
        /// <returns>Returns a System.String that describes this DisplayMode instance.</returns>
        public override string ToString()
        {
            return string.Format("Display Mode: {0}, depth: {1}, stencil {2}, aux {3} refresh {4}Hz",
                Color.ToString(),
                DepthBits,
                StencilBits,
                AuxBits,
                RefreshRate
            );
        }

        #endregion
    }

    public class DisplayModeMatchOptions { }
}
