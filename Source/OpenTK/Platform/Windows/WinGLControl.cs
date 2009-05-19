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

using OpenTK.Graphics;

namespace OpenTK.Platform.Windows
{
    class WinGLControl : IGLControl
    {
        MSG msg = new MSG();
        GraphicsMode mode;
        Control control;
        WinWindowInfo window_info;

        internal WinGLControl(GraphicsMode mode, Control control)
        {
            this.mode = mode;
            this.control = control;
            this.control.HandleCreated += delegate(object sender, EventArgs e)
            {
                if (window_info != null)
                    window_info.Dispose();
                window_info = new WinWindowInfo(this.control.Handle, null);
            };
            this.control.HandleDestroyed += delegate(object sender, EventArgs e)
            {
                if (window_info != null)
                {
                    window_info.Dispose();
                    window_info = null;
                }
            };
        }

        #region --- IGLControl Members ---

        public GraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags)
        {
            // Make sure the Control exists before creating the context.
            if (window_info == null)
                window_info = new WinWindowInfo(control.Handle, null);

            return new GraphicsContext(mode, window_info, major, minor, flags);
        }

        public bool IsIdle
        {
            get { return !OpenTK.Platform.Windows.Functions.PeekMessage(ref msg, IntPtr.Zero, 0, 0, 0); }
        }

        public IWindowInfo WindowInfo
        {
            get
            {
                // This method forces the creation of the control. Beware of this side-effect!
                return window_info;
            }
        }

        #endregion
    }
}
