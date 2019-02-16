//
// IWindowProperties.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Drawing;

namespace OpenToolkit.Windowing.Common
{
    public interface INativeWindowProperties
    {
        /// <summary>
        /// Gets or sets the <see cref="System.Drawing.Icon" /> of the window.
        /// </summary>
        //Icon Icon { get; set; } // HIGH: Either an assembly is missing or this isn't defined for .NET Standard 2.0's Drawing assembly
        
        /// <summary>
        /// Gets or sets the clipboard string.
        /// </summary>
        string ClipboardString { get; set; }

        /// <summary>
        /// Gets or sets the title of the window.
        /// </summary>
        string Title { get; set; }
        
        /// <summary>
        /// Gets or sets a System.Boolean that indicates whether this window is fullscreen.
        /// </summary>
        bool IsFullscreen { get; set; }

        /// <summary>
        /// Gets or sets a System.Boolean that indicates whether this window has input focus.
        /// </summary>
        /// <remarks>
        /// A window cannot be manually unfocused by setting this to false.
        /// </remarks>
        bool Focused { get; set; }

        /// <summary>
        /// Gets or sets a System.Boolean that indicates whether the window is visible.
        /// </summary>
        bool Visible { get; set; }

        /// <summary>
        /// Gets a System.Boolean that indicates whether the window has been created and has not been destroyed.
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
        /// Gets or sets a <see cref="System.Drawing.Rectangle" /> structure the contains the external bounds of this window,
        /// in screen coordinates.
        /// External bounds include the title bar, borders and drawing area of the window.
        /// </summary>
        Rectangle Bounds { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Point" /> structure that contains the location of this window on the
        /// desktop.
        /// </summary>
        Point Location { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Size" /> structure that contains the external size of this window.
        /// </summary>
        Size Size { get; set; }

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
        /// Gets or sets a <see cref="System.Drawing.Rectangle" /> structure that contains the internal bounds of this window,
        /// in client coordinates.
        /// The internal bounds include the drawing area of the window, but exclude the titlebar and window borders.
        /// </summary>
        Rectangle ClientRectangle { get; set; }

        /// <summary>
        /// Gets a <see cref="System.Drawing.Size" /> structure that contains the internal size this window.
        /// </summary>
        Size ClientSize { get; }
    }
}
