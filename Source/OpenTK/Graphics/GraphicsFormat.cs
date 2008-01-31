#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    /// <summary>Defines the format for graphics operations.</summary>
    public class GraphicsFormat
    {
        private ColorMode color_format, auxilliary_color_format;
        int depth, stencil, buffers;
        bool stereo;

        #region --- Constructors ---

        /// <summary>Constructs a new GraphicsFormat from the given GraphicsFormat.</summary>
        /// <param name="mode"></param>

        #region public GraphicsFormat(GraphicsFormat mode)

        public GraphicsFormat(GraphicsFormat mode)
            : this(mode.ColorMode, mode.Depth, mode.Stencil, mode.AuxilliaryColorFormat, mode.Buffers, mode.Stereo) { }

        #endregion

        #region public GraphicsFormat()

        /// <summary>Constructs a new GraphicsFormat with sensible default parameters.</summary>
        public GraphicsFormat()
            : this(DisplayDevice.PrimaryDisplay.BitsPerPixel, 16, 0, 0, 2, false)
        {
        }

        #endregion

        #region public GraphicsFormat(ColorMode color)

        /// <summary>Constructs a new GraphicsFormat with the specified parameters.</summary>
        /// <param name="color">The ColorMode of the color buffer.</param>
        public GraphicsFormat(ColorMode color)
            : this(color, 16, 0, 0, 2, false) { }

        #endregion

        #region public GraphicsFormat(ColorMode color, int depth)

        /// <summary>Constructs a new GraphicsFormat with the specified parameters.</summary>
        /// <param name="color">The ColorMode of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        public GraphicsFormat(ColorMode color, int depth)
            : this(color, depth, 0, 0, 2, false) { }

        #endregion

        #region public GraphicsFormat(ColorMode color, int depth, int stencil)

        /// <summary>Constructs a new GraphicsFormat with the specified parameters.</summary>
        /// <param name="color">The ColorMode of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        public GraphicsFormat(ColorMode color, int depth, int stencil)
            : this(color, depth, stencil, 0, 2, false) { }

        #endregion

        #region public GraphicsFormat(ColorMode color, int depth, int stencil, ColorMode aux)

        /// <summary>Constructs a new GraphicsFormat with the specified parameters.</summary>
        /// <param name="color">The ColorMode of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        /// <param name="aux">The ColorMode of the auxilliary buffer.</param>
        public GraphicsFormat(ColorMode color, int depth, int stencil, ColorMode aux)
            : this(color, depth, stencil, aux, 2, false) { }

        #endregion

        #region public GraphicsFormat(ColorMode color, int depth, int stencil, ColorMode aux, int buffers)

        /// <summary>Constructs a new GraphicsFormat with the specified parameters.</summary>
        /// <param name="color">The ColorMode of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        /// <param name="aux">The ColorMode of the auxilliary buffer.</param>
        /// <param name="buffers">The number of render buffers. Typical values include one (single-), two (double-) or three (triple-buffering).</param>
        public GraphicsFormat(ColorMode color, int depth, int stencil, ColorMode aux, int buffers)
            : this(color, depth, stencil, aux, buffers, false) { }

        #endregion

        #region public GraphicsFormat(ColorMode color, int depth, int stencil, ColorMode aux, int buffers, bool stereo)

        /// <summary>Constructs a new GraphicsFormat with the specified parameters.</summary>
        /// <param name="color">The ColorMode of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        /// <param name="aux">The ColorMode of the auxilliary buffer.</param>
        /// <param name="stereo">Set to true for a GraphicsFormat with stereographic capabilities.</param>
        /// <param name="buffers">The number of render buffers. Typical values include one (single-), two (double-) or three (triple-buffering).</param>
        public GraphicsFormat(ColorMode color, int depth, int stencil, ColorMode aux, int buffers, bool stereo)
        {
            this.ColorMode = color;
            this.Depth = depth;
            this.Stencil = stencil;
            this.AuxilliaryColorFormat = aux;
            this.Buffers = buffers;
            this.Stereo = stereo;
        }

        #endregion

        #endregion

        #region --- Public Methods ---

        #region public int ColorMode

        /// <summary>
        /// Gets an OpenTK.Graphics.ColorMode that describes the color format of this DisplayMode.
        /// </summary>
        public ColorMode ColorMode
        {
            get { return color_format; }
            private set { color_format = value; }
        }

        #endregion

        #region public int AuxilliaryColorFormat

        /// <summary>
        /// Gets an OpenTK.Graphics.ColorMode that describes the color format of this DisplayMode.
        /// </summary>
        public ColorMode AuxilliaryColorFormat
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
            get { return depth; }
            private set { depth = value; }
        }

        #endregion

        #region public int Stencil

        /// <summary>
        /// Gets a System.Int32 that contains the bits per pixel for the stencil buffer
        /// of this DisplayMode.
        /// </summary>
        public int Stencil
        {
            get { return stencil; }
            private set { stencil = value; }
        }

        #endregion

        #region public bool Stereo

        /// <summary>
        /// Gets a System.Boolean indicating whether this DisplayMode is stereoscopic.
        /// </summary>
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
        public int Buffers
        {
            get { return this.buffers; }
            private set { this.buffers = value; }
        }

        #endregion

        #region public static GraphicsFormat Default

        /// <summary>Returns an OpenTK.GraphicsFormat compatible with the underlying platform.</summary>
        public static GraphicsFormat Default
        {
            get { return new GraphicsFormat(DisplayDevice.PrimaryDisplay.BitsPerPixel, 16, 0, 0, 2, false); }
        }

        #endregion

        #endregion
    }
}
