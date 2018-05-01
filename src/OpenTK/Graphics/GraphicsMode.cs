/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */

using System;
using System.Diagnostics;
using OpenTK.Mathematics;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Defines the format for graphics operations.
    /// </summary>
    public class GraphicsMode : IEquatable<GraphicsMode>
    {
        private static GraphicsMode defaultMode;
        private static readonly object SyncRoot = new object();
        private int samples;

        // Disable BeforeFieldInit
        static GraphicsMode()
        {
        }

        internal GraphicsMode(GraphicsMode mode)
            : this(mode.ColorFormat, mode.Depth, mode.Stencil, mode.Samples, mode.AccumulatorFormat, mode.Buffers,
                mode.Stereo)
        {
        }

        internal GraphicsMode(IntPtr? index, ColorFormat color, int depth, int stencil, int samples, ColorFormat accum,
            int buffers, bool stereo)
        {
            if (depth < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(depth), "Must be greater than, or equal to zero.");
            }

            if (stencil < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(stencil), "Must be greater than, or equal to zero.");
            }

            if (buffers < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(buffers), "Must be greater than, or equal to zero.");
            }

            if (samples < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(samples), "Must be greater than, or equal to zero.");
            }

            Index = index;
            ColorFormat = color;
            Depth = depth;
            Stencil = stencil;
            Samples = samples;
            AccumulatorFormat = accum;
            Buffers = buffers;
            Stereo = stereo;
        }

        /// <summary>
        /// Constructs a new GraphicsMode with sensible default parameters.
        /// </summary>
        public GraphicsMode()
            : this(Default)
        {
        }

        /// <summary>
        /// Constructs a new GraphicsMode with the specified parameters.
        /// </summary>
        /// <param name="color">The ColorFormat of the color buffer.</param>
        public GraphicsMode(ColorFormat color)
            : this(color, Default.Depth, Default.Stencil, Default.Samples, Default.AccumulatorFormat, Default.Buffers,
                Default.Stereo)
        {
        }

        /// <summary>
        /// Constructs a new GraphicsMode with the specified parameters.
        /// </summary>
        /// <param name="color">The ColorFormat of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        public GraphicsMode(ColorFormat color, int depth)
            : this(color, depth, Default.Stencil, Default.Samples, Default.AccumulatorFormat, Default.Buffers,
                Default.Stereo)
        {
        }

        /// <summary>
        /// Constructs a new GraphicsMode with the specified parameters.
        /// </summary>
        /// <param name="color">The ColorFormat of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        public GraphicsMode(ColorFormat color, int depth, int stencil)
            : this(color, depth, stencil, Default.Samples, Default.AccumulatorFormat, Default.Buffers, Default.Stereo)
        {
        }

        /// <summary>
        /// Constructs a new GraphicsMode with the specified parameters.
        /// </summary>
        /// <param name="color">The ColorFormat of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        /// <param name="samples">The number of samples for FSAA.</param>
        public GraphicsMode(ColorFormat color, int depth, int stencil, int samples)
            : this(color, depth, stencil, samples, Default.AccumulatorFormat, Default.Buffers, Default.Stereo)
        {
        }

        /// <summary>
        /// Constructs a new GraphicsMode with the specified parameters.
        /// </summary>
        /// <param name="color">The ColorFormat of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        /// <param name="samples">The number of samples for FSAA.</param>
        /// <param name="accum">The ColorFormat of the accumilliary buffer.</param>
        public GraphicsMode(ColorFormat color, int depth, int stencil, int samples, ColorFormat accum)
            : this(color, depth, stencil, samples, accum, Default.Buffers, Default.Stereo)
        {
        }

        /// <summary>
        /// Constructs a new GraphicsMode with the specified parameters.
        /// </summary>
        /// <param name="color">The ColorFormat of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        /// <param name="samples">The number of samples for FSAA.</param>
        /// <param name="accum">The ColorFormat of the accumilliary buffer.</param>
        /// <param name="buffers">
        /// The number of render buffers. Typical values include one (single-), two (double-) or three
        /// (triple-buffering).
        /// </param>
        public GraphicsMode(ColorFormat color, int depth, int stencil, int samples, ColorFormat accum, int buffers)
            : this(color, depth, stencil, samples, accum, buffers, Default.Stereo)
        {
        }

        /// <summary>
        /// Constructs a new GraphicsMode with the specified parameters.
        /// </summary>
        /// <param name="color">The ColorFormat of the color buffer.</param>
        /// <param name="depth">The number of bits in the depth buffer.</param>
        /// <param name="stencil">The number of bits in the stencil buffer.</param>
        /// <param name="samples">The number of samples for FSAA.</param>
        /// <param name="accum">The ColorFormat of the accumilliary buffer.</param>
        /// <param name="stereo">Set to true for a GraphicsMode with stereographic capabilities.</param>
        /// <param name="buffers">
        /// The number of render buffers. Typical values include one (single-), two (double-) or three
        /// (triple-buffering).
        /// </param>
        public GraphicsMode(ColorFormat color, int depth, int stencil, int samples, ColorFormat accum, int buffers,
            bool stereo)
            : this(null, color, depth, stencil, samples, accum, buffers, stereo)
        {
        }

        /// <summary>
        /// Gets a nullable <see cref="System.IntPtr" /> value, indicating the platform-specific index for this GraphicsMode.
        /// </summary>
        public IntPtr? Index { get; set; }

        /// <summary>
        /// Gets an OpenTK.Graphics.ColorFormat that describes the color format for this GraphicsFormat.
        /// </summary>
        public ColorFormat ColorFormat { get; }

        /// <summary>
        /// Gets an OpenTK.Graphics.ColorFormat that describes the accumulator format for this GraphicsFormat.
        /// </summary>
        public ColorFormat AccumulatorFormat { get; }

        /// <summary>
        /// Gets a System.Int32 that contains the bits per pixel for the depth buffer
        /// for this GraphicsFormat.
        /// </summary>
        public int Depth { get; }

        /// <summary>
        /// Gets a System.Int32 that contains the bits per pixel for the stencil buffer
        /// of this GraphicsFormat.
        /// </summary>
        public int Stencil { get; }

        /// <summary>
        /// Gets a System.Int32 that contains the number of FSAA samples per pixel for this GraphicsFormat.
        /// </summary>
        public int Samples
        {
            get => samples;
            private set => samples = MathHelper.Clamp(value, 0, 64);
        }

        /// <summary>
        /// Gets a System.Boolean indicating whether this DisplayMode is stereoscopic.
        /// </summary>
        public bool Stereo { get; }

        /// <summary>
        /// Gets a System.Int32 containing the number of buffers associated with this
        /// DisplayMode.
        /// </summary>
        public int Buffers { get; }

        /// <summary>
        /// Returns an OpenTK.GraphicsFormat compatible with the underlying platform.
        /// </summary>
        public static GraphicsMode Default
        {
            get
            {
                lock (SyncRoot)
                {
                    if (defaultMode == null)
                    {
                        defaultMode = new GraphicsMode(null, 32, 16, 0, 0, 0, 2, false);
                        Debug.Print("GraphicsMode.Default = {0}", defaultMode);
                    }

                    return defaultMode;
                }
            }
        }

        /// <summary>
        /// Indicates whether other represents the same mode as this instance.
        /// </summary>
        /// <param name="other">The GraphicsMode to compare to.</param>
        /// <returns>True, if other is equal to this instance; false otherwise.</returns>
        public bool Equals(GraphicsMode other)
        {
            return Index.HasValue && Index == other.Index;
        }

        /// <summary>
        /// Returns a System.String describing the current GraphicsFormat.
        /// </summary>
        /// <returns>! System.String describing the current GraphicsFormat.</returns>
        public override string ToString()
        {
            return
                $"Index: {Index}, Color: {ColorFormat}, Depth: {Depth}, Stencil: {Stencil}, Samples: {Samples}, Accum: {AccumulatorFormat}, Buffers: {Buffers}, Stereo: {Stereo}";
        }

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A <see cref="System.Int32" /> hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            return Index.GetHashCode();
        }

        /// <summary>
        /// Indicates whether obj is equal to this instance.
        /// </summary>
        /// <param name="obj">An object instance to compare for equality.</param>
        /// <returns>True, if obj equals this instance; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj is GraphicsMode)
            {
                return Equals((GraphicsMode)obj);
            }

            return false;
        }
    }
}
