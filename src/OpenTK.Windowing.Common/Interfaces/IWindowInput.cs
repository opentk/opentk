//
// IWindowInput.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using OpenToolkit.Windowing.Common.Input;

namespace OpenToolkit.Windowing.Common
{
    public interface IWindowInput
    {

        /// <summary>
        /// Gets or sets the <see cref="OpenToolkit.Windowing.Common.Input.MouseCursor" /> for this window.
        /// </summary>
        /// <value>The cursor.</value>
        MouseCursor Cursor { get; set; }

        /// <summary>
        /// Gets or sets a value, indicating whether the mouse cursor is visible.
        /// </summary>
        bool CursorVisible { get; set; }

        /// <summary>
        /// Gets or sets a value, indicating whether the mouse cursor is confined inside the window size.
        /// </summary>
        bool CursorGrabbed { get; set; }
    }
}
