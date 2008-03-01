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
    public class GraphicsMode
    {
        ColorDepth color_format, accumulator_format;
        int depth, stencil, buffers, samples;
        bool stereo;

        #region --- Constructors ---

        #region internal GraphicsFormat(GraphicsFormat mode)

        /// <internal />
        /// <summary>Constructs a new GraphicsFormat from the given GraphicsFormat.</summary>
        /// <param name="mode"></param>
        internal GraphicsMode(GraphicsMode mode)
            : this(mode.ColorDepth, mode.Depth, mode.Stencil, mode.Samples, mode.AccumulatorFormat, mode.Buffers, mode.Stereo) { }

        #endregion

        #region public GraphicsFormat()

        /// <summary>Constructs a new GraphicsFormat with sensible default parameters.</summary>
        public GraphicsMode()
            : this(Default)
        { }

        #endregion

        #region public GraphicsFormat(ColorDepth color)

        /// <summary>Constructs a new GraphicsFormat with the specified parameters.</summary>
        /// <param name="color">The ColorDepth of the color buffer.</param>
        public GraphicsMode(ColorDepth color)
            : this(color, Default.Depth, Default.Stencil, Default.Samples, Default.AccumulatorFormat, Default.Buffers, Default.Stereo)
        { }

        #endregion

        #region public GraphicsFormat(ColorDepth color, int depth)

        /// <summary>Constructs a new GraphicsFormat with the specified parameters.</summary>
        /// <param name="color">The ColorDepth of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        public GraphicsMode(ColorDepth color, int depth)
            : this(color, depth, Default.Stencil, Default.Samples, Default.AccumulatorFormat, Default.Buffers, Default.Stereo)
        { }

        #endregion

        #region public GraphicsFormat(ColorDepth color, int depth, int stencil)

        /// <summary>Constructs a new GraphicsFormat with the specified parameters.</summary>
        /// <param name="color">The ColorDepth of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        public GraphicsMode(ColorDepth color, int depth, int stencil)
            : this(color, depth, stencil, Default.Samples, Default.AccumulatorFormat, Default.Buffers, Default.Stereo)
        { }

        #endregion

        #region public GraphicsFormat(ColorDepth color, int depth, int stencil, int samples)

        /// <summary>Constructs a new GraphicsFormat with the specified parameters.</summary>
        /// <param name="color">The ColorDepth of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        /// <param name="samples">The number of samples for FSAA.</param>
        public GraphicsMode(ColorDepth color, int depth, int stencil, int samples)
            : this(color, depth, stencil, samples, Default.AccumulatorFormat, Default.Buffers, Default.Stereo)
        { }

        #endregion

        #region public GraphicsFormat(ColorDepth color, int depth, int stencil, int samples, ColorDepth accum)

        /// <summary>Constructs a new GraphicsFormat with the specified parameters.</summary>
        /// <param name="color">The ColorDepth of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        /// <param name="samples">The number of samples for FSAA.</param>
        /// <param name="accum">The ColorDepth of the accumilliary buffer.</param>
        public GraphicsMode(ColorDepth color, int depth, int stencil, int samples, ColorDepth accum)
            : this(color, depth, stencil, samples, accum, Default.Buffers, Default.Stereo)
        { }

        #endregion

        #region public GraphicsFormat(ColorDepth color, int depth, int stencil, int samples, ColorDepth accum, int buffers)

        /// <summary>Constructs a new GraphicsFormat with the specified parameters.</summary>
        /// <param name="color">The ColorDepth of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        /// <param name="samples">The number of samples for FSAA.</param>
        /// <param name="accum">The ColorDepth of the accumilliary buffer.</param>
        /// <param name="buffers">The number of render buffers. Typical values include one (single-), two (double-) or three (triple-buffering).</param>
        public GraphicsMode(ColorDepth color, int depth, int stencil, int samples, ColorDepth accum, int buffers)
            : this(color, depth, stencil, samples, accum, buffers, Default.Stereo)
        { }

        #endregion

        #region public GraphicsFormat(ColorDepth color, int depth, int stencil, int samples, ColorDepth accum, int buffers, bool stereo)

        /// <summary>Constructs a new GraphicsFormat with the specified parameters.</summary>
        /// <param name="color">The ColorDepth of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        /// <param name="samples">The number of samples for FSAA.</param>
        /// <param name="accum">The ColorDepth of the accumilliary buffer.</param>
        /// <param name="stereo">Set to true for a GraphicsFormat with stereographic capabilities.</param>
        /// <param name="buffers">The number of render buffers. Typical values include one (single-), two (double-) or three (triple-buffering).</param>
        public GraphicsMode(ColorDepth color, int depth, int stencil, int samples, ColorDepth accum, int buffers, bool stereo)
        {
            if (depth < 0) throw new ArgumentOutOfRangeException("depth", "Must be greater than, or equal to zero.");
            if (stencil < 0) throw new ArgumentOutOfRangeException("stencil", "Must be greater than, or equal to zero.");
            if (buffers <= 0) throw new ArgumentOutOfRangeException("buffers", "Must be greater than zero.");
            if (samples < 0) throw new ArgumentOutOfRangeException("samples", "Must be greater than, or equal to zero.");

            this.ColorDepth = color;
            this.Depth = depth;
            this.Stencil = stencil;
            this.AccumulatorFormat = accum;
            this.Buffers = buffers;
            this.Stereo = stereo;
        }

        #endregion

        #endregion

        #region --- Public Methods ---

        #region public int ColorDepth

        /// <summary>
        /// Gets an OpenTK.Graphics.ColorDepth that describes the color format for this GraphicsFormat.
        /// </summary>
        public ColorDepth ColorDepth
        {
            get { return color_format; }
            private set { color_format = value; }
        }

        #endregion

        #region public int AccumulatorFormat

        /// <summary>
        /// Gets an OpenTK.Graphics.ColorDepth that describes the accumulator format for this GraphicsFormat.
        /// </summary>
        public ColorDepth AccumulatorFormat
        {
            get { return accumulator_format; }
            private set { accumulator_format = value; }
        }

        #endregion

        #region public int Depth

        /// <summary>
        /// Gets a System.Int32 that contains the bits per pixel for the depth buffer
        /// for this GraphicsFormat.
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
        /// of this GraphicsFormat.
        /// </summary>
        public int Stencil
        {
            get { return stencil; }
            private set { stencil = value; }
        }

        #endregion

        /// <summary>
        /// Gets a System.Int32 that contains the number of FSAA samples per pixel for this GraphicsFormat.
        /// </summary>
        public int Samples
        {
            get { return samples; }
            private set { samples = value; }
        }

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
        public static GraphicsMode Default
        {
            get { return new GraphicsMode(DisplayDevice.Default.BitsPerPixel, 16, 0, 0, 0, 2, false); }
        }

        #endregion

        #endregion

        #region --- Overrides ---

        /// <summary>Returns a System.String describing the current GraphicsFormat.</summary>
        /// <returns>! System.String describing the current GraphicsFormat.</returns>
        public override string ToString()
        {
            return String.Format("Color: {0}, Depth: {1}, Stencil: {2}, Samples: {3}, Accum: {4}, Buffers: {5}, Stereo: {6}",
                ColorDepth, Depth, Stereo, Samples, AccumulatorFormat, Buffers, Stereo);
        }

        #endregion
    }
}
