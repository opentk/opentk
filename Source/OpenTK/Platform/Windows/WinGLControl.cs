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

        internal WinGLControl(GraphicsMode mode, Control control)
        {
            this.mode = mode;
            this.control = control;
        }

        #region --- IGLControl Members ---

        public GraphicsContext CreateContext()
        {
            WinWindowInfo window = new WinWindowInfo(control.Handle, null);
            return new GraphicsContext(mode, window);
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
                return new WinWindowInfo(control.Handle, null);
            }
        }

        #endregion
    }
}
