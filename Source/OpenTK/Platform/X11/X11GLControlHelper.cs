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

namespace OpenTK.Platform.X11
{
    /// <internal />
    /// <summary>Utility to obtain IWindowInfo from a System.Windows.Forms.Control on Mono/X11.</summary>
    internal sealed class X11GLControlHelper : IGLControlHelper
    {
        Control control;
        IntPtr display;

        public X11GLControlHelper(Control c)
        {
        }

        #region IGLControlHelper Members

        public IWindowInfo WindowInfo
        {
            get
            {
                X11WindowInfo window = new X11WindowInfo();
                Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
                if (xplatui == null)
                    throw new ApplicationException("Could not get System.Windows.Forms.XplatUIX11 through reflection. Unsupported platform or Mono runtime version, aborting.");

                display = 
                window.Display = (IntPtr)xplatui.GetField("DisplayHandle",
                    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
                window.RootWindow = (IntPtr)xplatui.GetField("RootWindow",
                    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
                window.Screen = (int)xplatui.GetField("ScreenNo",
                    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);

                return (IWindowInfo)window;
            }
        }

        public bool IsIdle
        {
            get
            {
                lock (Functions.Lock)
                {
                    return Functions.XPending(display) == 0;
                }
            }
        }

        #endregion
    }
}
