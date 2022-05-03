using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Windowing.Common
{
    /// <summary>
    /// Cursor states.
    /// </summary>
    public enum CursorState
    {
        /// <summary>
        /// The cursor visible and cursor motion is not limited.
        /// </summary>
        Normal,

        /// <summary>
        /// Hides the cursor when over a window.
        /// </summary>
        Hidden,

        /// <summary>
        /// Hides the cursor and locks it to the specified window.
        /// </summary>
        Grabbed,
    }
}
