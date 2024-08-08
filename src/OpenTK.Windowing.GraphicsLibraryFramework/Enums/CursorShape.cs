//
// CursorShape.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Standard cursor shapes.
    /// </summary>
    public enum CursorShape
    {
        /// <summary>
        /// The standard arrow shape. Used in almost all situations.
        /// </summary>
        Arrow = 0x00036001,

        /// <summary>
        /// The I-Beam shape. Used when mousing over a place where text can be entered.
        /// </summary>
        IBeam = 0x00036002,

        /// <summary>
        /// The crosshair shape. Used when dragging and dropping.
        /// </summary>
        Crosshair = 0x00036003,

        /// <summary>
        /// The pointing hand shape. Used when mousing over something that can be dragged around.
        /// </summary>
        PointingHand = 0x00036004,

        /// <summary>
        /// The horizontal resize/move arrow shape.  This is usually a horizontal double-headed arrow.
        /// </summary>
        ResizeEW = 0x00036005,

        /// <summary>
        /// The vertical resize/move shape.  This is usually a vertical double-headed arrow.
        /// </summary>
        ResizeNS = 0x00036006,

        /// <summary>
        /// The top-left to bottom-right diagonal resize/move shape.  This is usually
        /// a diagonal double-headed arrow.
        ///
        /// <para>
        /// macOS: This shape is provided by a private system API and may fail
        /// with <see cref="ErrorCode.CursorUnavailable"/> in the future.
        /// </para>
        /// <para>
        /// Wayland: This shape is provided by a newer standard not supported by
        /// all cursor themes.
        /// </para>
        /// <para>
        /// X11: This shape is provided by a newer standard not supported by all
        /// cursor themes.
        /// </para>
        /// </summary>
        ResizeNWSE = 0x00036007,

        /// <summary>
        /// The top-right to bottom-left diagonal resize/move shape.  This is usually
        /// a diagonal double-headed arrow.
        ///
        /// <para>
        /// macOS: This shape is provided by a private system API and may fail
        /// with <see cref="ErrorCode.CursorUnavailable"/> in the future.
        /// </para>
        /// <para>
        /// Wayland: This shape is provided by a newer standard not supported by
        /// all cursor themes.
        /// </para>
        /// <para>
        /// X11: This shape is provided by a newer standard not supported by all
        /// cursor themes.
        /// </para>
        /// </summary>
        ResizeNESW = 0x00036008,

        /// <summary>
        /// The omni-directional resize cursor/move shape.  This is usually either
        /// a combined horizontal and vertical double-headed arrow or a grabbing hand.
        /// </summary>
        ResizeAll = 0x00036009,

        /// <summary>
        /// The operation-not-allowed shape.  This is usually a circle with a diagonal
        /// line through it.
        ///
        /// <para>
        /// Wayland: This shape is provided by a newer standard not supported by
        /// all cursor themes.
        /// </para>
        /// <para>
        /// X11: This shape is provided by a newer standard not supported by all
        /// cursor themes.
        /// </para>
        /// </summary>
        NotAllowed = 0x0003600A,

        /// <summary>
        /// The horizontal resize shape. Used when mousing over something that can be horizontally resized.
        /// This is an alias for compatibility with earlier versions.
        /// </summary>
        [Obsolete("Use " + nameof(ResizeEW) + " instead.")]
        HResize = ResizeEW,

        /// <summary>
        /// The vertical resize shape. Used when mousing over something that can be vertically resized.
        /// This is an alias for compatibility with earlier versions.
        /// </summary>
        [Obsolete("Use " + nameof(ResizeNS) + " instead.")]
        VResize = ResizeNS,

        /// <summary>
        /// This is an alias for compatibility with earlier versions.
        /// </summary>
        [Obsolete("Use " + nameof(PointingHand) + " instead.")]
        Hand = PointingHand,
    }
}
