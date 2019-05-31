//
// INativeWindowProperties.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.Common.Input;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Describes window related properties.
    /// </summary>
    public interface INativeWindowProperties
    {
        /// <summary>
        /// Gets or sets the current <see cref="WindowIcon" /> for this window.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This does nothing on macOS; on that platform, the icon is determined by the application bundle.
        /// </para>
        /// </remarks>
        WindowIcon Icon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not this window is event-driven.
        /// An event-driven window will wait for events before updating/rendering. It is useful for non-game applications,
        /// where the program only needs to do any processing after the user inputs something.
        /// </summary>
        bool IsEventDriven { get; set; }

        /// <summary>
        /// Gets or sets the current monitor.
        /// </summary>
        Monitor CurrentMonitor { get; set; }

        /// <summary>
        /// Gets a value representing the current graphics API.
        /// </summary>
        ContextAPI API { get; }

        /// <summary>
        /// Gets a value representing the current graphics API profile.
        /// </summary>
        ContextProfile Profile { get; }

        /// <summary>
        /// Gets a value representing the current graphics profile flags.
        /// </summary>
        ContextFlags Flags { get; }

        /// <summary>
        /// Gets a value representing the current version of the graphics API.
        /// </summary>
        Version APIVersion { get; }

        /// <summary>
        /// Gets or sets the clipboard string.
        /// </summary>
        string ClipboardString { get; set; }

        /// <summary>
        /// Gets or sets the title of the window.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this window has input focus.
        /// </summary>
        /// <remarks>
        /// A window cannot be manually unfocused by setting this to false.
        /// </remarks>
        bool IsFocused { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the window is visible.
        /// </summary>
        bool IsVisible { get; set; }

        /// <summary>
        /// Gets a value indicating whether the window has been created and has not been destroyed.
        /// </summary>
        bool Exists { get; }

        /// <summary>
        /// Gets or sets the <see cref="WindowState" /> for this window.
        /// </summary>
        WindowState WindowState { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="WindowBorder" /> for this window.
        /// </summary>
        WindowBorder WindowBorder { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="OpenToolkit.Mathematics.Box2i" /> structure the contains the external bounds of this window,
        /// in screen coordinates.
        /// External bounds include the title bar, borders and drawing area of the window.
        /// </summary>
        Box2i Bounds { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="OpenToolkit.Mathematics.Vector2i" /> structure that contains the location of this window on the
        /// desktop.
        /// </summary>
        Vector2i Location { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="OpenToolkit.Mathematics.Vector2i" /> structure that contains the external size of this window.
        /// </summary>
        Vector2i Size { get; set; }

        /// <summary>
        /// Gets or sets the horizontal location of this window on the desktop.
        /// </summary>
        int X { get; set; }

        /// <summary>
        /// Gets or sets the vertical location of this window on the desktop.
        /// </summary>
        int Y { get; set; }

        /// <summary>
        /// Gets or sets the external width of this window.
        /// </summary>
        int Width { get; set; }

        /// <summary>
        /// Gets or sets the external height of this window.
        /// </summary>
        int Height { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="OpenToolkit.Mathematics.Box2i" /> structure that contains the internal bounds of this window,
        /// in client coordinates.
        /// The internal bounds include the drawing area of the window, but exclude the titlebar and window borders.
        /// </summary>
        Box2i ClientRectangle { get; set; }

        /// <summary>
        /// Gets a <see cref="OpenToolkit.Mathematics.Vector2i" /> structure that contains the internal size this window.
        /// </summary>
        Vector2i ClientSize { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the window is fullscreen or not.
        /// </summary>
        bool IsFullscreen { get; set; }
    }
}
