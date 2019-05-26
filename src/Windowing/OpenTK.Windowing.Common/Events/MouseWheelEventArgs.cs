//
// MouseWheelEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Windowing.Common;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the event data for <see cref="IWindowEvents.MouseWheel" /> events.
    /// </summary>
    /// <remarks>
    ///  <para>
    /// Do not cache instances of this type outside their event handler.
    /// If necessary, you can clone an instance using the
    ///  <see cref="MouseWheelEventArgs" /> constructor.
    ///  </para>
    /// </remarks>
    public class MouseWheelEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MouseWheelEventArgs"/> class.
        /// </summary>
        public MouseWheelEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseWheelEventArgs"/> class.
        /// </summary>
        /// <param name="offsetX">The offset on the X axis.</param>
        /// <param name="offsetY">The offset on the Y axis.</param>
        public MouseWheelEventArgs(double offsetX, double offsetY)
        {
            OffsetX = offsetX;
            OffsetY = offsetY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseWheelEventArgs"/> class.
        /// </summary>
        /// <param name="args">The <see cref="MouseWheelEventArgs" /> instance to clone.</param>
        public MouseWheelEventArgs(MouseWheelEventArgs args)
            : this(args.OffsetX, args.OffsetY)
        {
        }

        /// <summary>
        /// Gets the offset on the X axis. Not many mice have this.
        /// </summary>
        public double OffsetX { get; internal set; }

        /// <summary>
        /// Gets the offset on the Y axis. Most mice only have this.
        /// </summary>
        public double OffsetY { get; internal set; }
    }
}
