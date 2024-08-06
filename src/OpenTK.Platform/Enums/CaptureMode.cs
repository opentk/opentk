using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// Cursor capture modes.
    /// </summary>
    public enum CursorCaptureMode
    {
        /// <summary>
        /// The cursor is not captured.
        /// </summary>
        Normal,

        /// <summary>
        /// The cursor is confined to the bounds of the window.
        /// </summary>
        Confined,

        /// <summary>
        /// <para>
        /// The cursor is locked to the center of the window. Useful for e.g. FPS games.
        /// </para>
        /// <para>
        /// In this mode the cursor has a virtual position that can go to arbitrary coordinates, this allows the mouse delta to always grow.
        /// Checking the mouse cursor position while capturing the cursor will not return a coordinate that corresponds to the screen.
        /// </para>
        /// </summary>
        Locked,
    }
}
