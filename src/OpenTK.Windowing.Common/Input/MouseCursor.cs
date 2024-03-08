//
// MouseCursor.cs
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
    /// Represents a predefined or custom mouse cursor.
    /// </summary>
    public sealed class MouseCursor : Image
    {
        /// <summary>
        /// Gets the default mouse cursor for this platform.
        /// </summary>
        public static MouseCursor Default { get; } = new MouseCursor(StandardShape.Arrow);

        /// <summary>
        /// Gets the default I beam cursor for this platform.
        /// </summary>
        public static MouseCursor IBeam { get; } = new MouseCursor(StandardShape.IBeam);

        /// <summary>
        /// Gets the default crosshair cursor for this platform.
        /// </summary>
        public static MouseCursor Crosshair { get; } = new MouseCursor(StandardShape.Crosshair);

        /// <summary>
        /// Gets the default pointing hand cursor for this platform.
        /// </summary>
        public static MouseCursor PointingHand { get; } = new MouseCursor(StandardShape.PointingHand);

        /// <summary>
        /// Gets the default pointing hand cursor for this platform.
        /// </summary>
        public static MouseCursor ResizeEW { get; } = new MouseCursor(StandardShape.ResizeEW);

        /// <summary>
        /// Gets the default pointing hand cursor for this platform.
        /// </summary>
        public static MouseCursor ResizeNS { get; } = new MouseCursor(StandardShape.ResizeNS);

        /// <summary>
        /// Gets the default northwest southeast diagonal resize cursor for this platform.
        /// </summary>
        public static MouseCursor ResizeNWSE { get; } = new MouseCursor(StandardShape.ResizeNWSE);

        /// <summary>
        /// Gets the default notheast southwest diagonal resize cursor for this platform.
        /// </summary>
        public static MouseCursor ResizeNESW { get; } = new MouseCursor(StandardShape.ResizeNESW);

        /// <summary>
        /// Gets the default omni-directional diagonal resize cursor for this platform.
        /// </summary>
        public static MouseCursor ResizeAll { get; } = new MouseCursor(StandardShape.ResizeNESW);

        /// <summary>
        /// Gets the default operation-not-allowed cursor for this platform.
        /// </summary>
        public static MouseCursor NotAllowed { get; } = new MouseCursor(StandardShape.NotAllowed);

        /// <summary>
        /// Gets the default hand cursor for this platform.
        /// </summary>
        [Obsolete("Use " + nameof(PointingHand) + " instead.")]
        public static MouseCursor Hand { get; } = new MouseCursor(StandardShape.Hand);

        /// <summary>
        /// Gets the default vertical resize cursor for this platform.
        /// </summary>
        [Obsolete("Use " + nameof(PointingHand) + " instead.")]
        public static MouseCursor VResize { get; } = new MouseCursor(StandardShape.VResize);

        /// <summary>
        /// Gets the default horizontal cursor for this platform.
        /// </summary>
        [Obsolete("Use " + nameof(PointingHand) + " instead.")]
        public static MouseCursor HResize { get; } = new MouseCursor(StandardShape.HResize);

        /// <summary>
        /// Gets an empty (invisible) mouse cursor.
        /// </summary>
        public static MouseCursor Empty { get; } = new MouseCursor(
            0, 0, 16, 16, new byte[16 * 16 * 4]);

        private MouseCursor(StandardShape shape)
        {
            Shape = shape;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseCursor" /> class from a
        /// contiguous array of RGBA pixels.
        /// Each pixel is composed of 4 bytes, representing R, G, B and A values,
        /// respectively. On some backends, the R, G, and B components should be premultiplied with the A component
        /// for correct antialiasing of translucent cursors:
        /// <code>
        /// B = (byte)((B * A) / 255)
        /// G = (byte)((G * A) / 255)
        /// R = (byte)((R * A) / 255)
        /// </code>
        /// </summary>
        /// <param name="hotX">The x-coordinate of the cursor hotspot, in the range [0, width].</param>
        /// <param name="hotY">The y-coordinate of the cursor hotspot, in the range [0, height].</param>
        /// <param name="width">The width of the cursor data, in pixels.</param>
        /// <param name="height">The height of the cursor data, in pixels.</param>
        /// <param name="data">
        /// A byte array representing the cursor image,
        /// laid out as a contiguous array of RGBA pixels.
        /// </param>
        public MouseCursor(int hotX, int hotY, int width, int height, byte[] data)
            : base(width, height, data)
        {
            if (hotX < 0 || hotX >= Width || hotY < 0 || hotY >= Height)
            {
                throw new ArgumentOutOfRangeException();
            }

            X = hotX;
            Y = hotY;
        }

        /// <summary>
        /// Gets the shape for standard preset cursors.
        /// </summary>
        public StandardShape Shape { get; }

        /// <summary>
        /// Gets the x-coordinate of the cursor hotspot.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Gets the y-coordinate of the cursor hotspot.
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// Standard cursor shapes.
        /// </summary>
        public enum StandardShape
        {
            /// <summary>
            /// Default standard shape for user-created cursors.
            /// </summary>
            CustomShape = 0,

            /// <summary>
            /// A normal arrow cursor.
            /// </summary>
            Arrow,

            /// <summary>
            /// An I-beam text editing cursor.
            /// </summary>
            IBeam,

            /// <summary>
            /// A crosshair cursor.
            /// </summary>
            Crosshair,

            /// <summary>
            /// A pointing hand cursor.
            /// </summary>
            PointingHand,

            /// <summary>
            /// A horizontal resize cursor.
            /// </summary>
            ResizeEW,

            /// <summary>
            /// A vertical resize cursor.
            /// </summary>
            ResizeNS,

            /// <summary>
            /// A diagonal northwest southeast resize cursor.
            /// </summary>
            ResizeNWSE,

            /// <summary>
            /// A diagonal northeast southwest resize cursor.
            /// </summary>
            ResizeNESW,

            /// <summary>
            /// An omni-directional resize cursor.
            /// </summary>
            ResizeAll,

            /// <summary>
            /// An operation-not-allowed cursor.
            /// </summary>
            NotAllowed,

            /// <summary>
            /// A hand cursor.
            /// </summary>
            [Obsolete("Use " + nameof(PointingHand) + " instead.")]
            Hand = PointingHand,

            /// <summary>
            /// A horizontal resize cursor.
            /// </summary>
            [Obsolete("Use " + nameof(ResizeEW) + " instead.")]
            HResize = ResizeEW,

            /// <summary>
            /// A vertical resize cursor.
            /// </summary>
            [Obsolete("Use " + nameof(ResizeNS) + " instead.")]
            VResize = ResizeNS,
        }
    }
}
