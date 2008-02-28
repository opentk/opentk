#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OpenTK.Platform.Windows
{
    /// <internal />
    /// <summary>OpenGL capable Windows.Forms control implementation on win32.</summary>
    internal sealed class WinGLControlHelper : IGLControlHelper
    {
        MSG msg = new MSG();
        WinWindowInfo windowInfo;

        #region --- Constructors ---

        internal WinGLControlHelper(Control c)
        {
            windowInfo = new WinWindowInfo(c.Handle, null);
        }

        #endregion

        #region --- IGLControlHelper Members ---

        /// <summary>Returns an OpenTK.Platform.IWindowInfo describing this control.</summary>
        public IWindowInfo WindowInfo { get { return windowInfo; } }

        /// <summary>Returns true if no messages are pending in the event loop.</summary>
        public bool IsIdle
        {
            get { return !OpenTK.Platform.Windows.Functions.PeekMessage(ref msg, IntPtr.Zero, 0, 0, 0); }
        }

        #endregion
    }
}
