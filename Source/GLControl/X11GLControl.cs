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
using System.Runtime.InteropServices;

using OpenTK.Graphics;
using OpenTK.Platform;

namespace OpenTK
{
    class X11GLControl : IGLControl
    {
        #region P/Invokes

        [DllImport("libX11")]
        public extern static int XPending(IntPtr diplay);

        #endregion

        #region Fields

        GraphicsMode mode;
        IWindowInfo window_info;

        #endregion

        internal X11GLControl(GraphicsMode mode, Control control)
        {
            if (mode == null)
                throw new ArgumentNullException("mode");
            if (control == null)
                throw new ArgumentNullException("control");
            
            this.mode = mode;

            window_info = Utilities.CreateWindowInfo(mode, control.Handle, true);
        }

        #region IGLControl Members

        public IGraphicsContext CreateContext(int major, int minor, GraphicsContextFlags flags)
        {
            return new GraphicsContext(mode, this.WindowInfo, major, minor, flags);
        }

        public bool IsIdle
        {
            get { return XPending(((Platform.X11.X11WindowInfo)window_info).Display) == 0; }
        }

        public IWindowInfo WindowInfo
        {
            get
            {
                return window_info;
            }
        }

        #endregion
    }
}
