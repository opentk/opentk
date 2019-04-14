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
    ///  <see cref="MouseWheelEventArgs(MouseWheelEventArgs)" /> constructor.
    ///  </para>
    /// </remarks>
    public class MouseWheelEventArgs : MouseEventArgs
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
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <param name="value">The value of the wheel.</param>
        /// <param name="delta">The change in value of the wheel for this event.</param>
        public MouseWheelEventArgs(double x, double y, int value, int delta)
            : base(x, y)
        {
            Mouse.SetScrollAbsolute(Mouse.Scroll.X, value);
            DeltaPrecise = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseWheelEventArgs"/> class.
        /// </summary>
        /// <param name="args">The <see cref="MouseWheelEventArgs" /> instance to clone.</param>
        public MouseWheelEventArgs(MouseWheelEventArgs args)
            : this(args.X, args.Y, args.Value, args.Delta)
        {
        }

        /// <summary>
        /// Gets the value of the wheel in integer units.
        /// To support high-precision mice, it is recommended to use <see cref="ValuePrecise" /> instead.
        /// </summary>
        public int Value => (int)Math.Round(Mouse.Scroll.Y, MidpointRounding.AwayFromZero);

        /// <summary>
        /// Gets the change in value of the wheel for this event in integer units.
        /// To support high-precision mice, it is recommended to use <see cref="DeltaPrecise" /> instead.
        /// </summary>
        public int Delta => (int)Math.Round(DeltaPrecise, MidpointRounding.AwayFromZero);

        /// <summary>
        /// Gets the precise value of the wheel in floating-point units.
        /// </summary>
        public float ValuePrecise => Mouse.Scroll.Y;

        /// <summary>
        /// Gets the precise change in value of the wheel for this event in floating-point units.
        /// </summary>
        public float DeltaPrecise { get; internal set; }
    }
}
