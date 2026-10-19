using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    /// <summary>
    /// The window type.
    /// </summary>
    public enum WindowType
    {
        /// <summary>
        /// A normal window, visible in the taskbar and window switcher.
        /// </summary>
        Normal,

        /// <summary>
        /// A tool window.
        /// A tool window is a window does not appear in the taskbar and does not appear in the window swticher (ALT+TAB).
        /// </summary>
        ToolBox,
    }
}
