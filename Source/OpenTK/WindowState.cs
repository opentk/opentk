// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
n.
 * See license.txt for licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    /// <summary>
    /// Enumerates available window states.
    /// </summary>
    public enum WindowState
    {
        /// <summary>
        /// The window is in its normal state.
        /// </summary>
        Normal = 0,
        /// <summary>
        /// The window is minimized to the taskbar (also known as 'iconified').
        /// </summary>
        Minimized,
        /// <summary>
        /// The window covers the whole working area, which includes the desktop but not the taskbar and/or panels.
        /// </summary>
        Maximized,
        /// <summary>
        /// The window covers the whole screen, including all taskbars and/or panels.
        /// </summary>
        Fullscreen
    }
}
