//
// MouseWheelEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the event data for <see cref="IWindowEvents.MouseWheel" /> events.
    /// </summary>
    public readonly struct MouseWheelEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MouseWheelEventArgs"/> struct.
        /// </summary>
        /// <param name="offsetX">The offset on the X axis.</param>
        /// <param name="offsetY">The offset on the Y axis.</param>
        public MouseWheelEventArgs(double offsetX, double offsetY)
        {
            OffsetX = offsetX;
            OffsetY = offsetY;
        }

        /// <summary>
        /// Gets the offset on the X axis. Not many mice have this.
        /// </summary>
        public double OffsetX { get; }

        /// <summary>
        /// Gets the offset on the Y axis. Most mice only have this.
        /// </summary>
        public double OffsetY { get; }
    }
}
