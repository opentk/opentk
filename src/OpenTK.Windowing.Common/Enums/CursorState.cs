﻿namespace OpenTK.Windowing.Common.Enums
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
