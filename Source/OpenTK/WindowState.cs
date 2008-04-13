#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    /// <summary>
    /// Defines the available states for the GameWindow.
    /// </summary>
    public enum WindowState
    {
        /// <summary>
        /// The GameWindow is minimized to the taskbar (also known as 'iconified').
        /// </summary>
        Minimized,
        /// <summary>
        /// The GameWindow is in its normal state.
        /// </summary>
        Normal,
        /// <summary>
        /// The GameWindow covers the whole working area, which includes the desktop but not the taskbar and/or panels.
        /// </summary>
        Maximized,
        /// <summary>
        /// The GameWindow covers the whole screen, including all taskbars and/or panels.
        /// </summary>
        Fullscreen
    }
}
