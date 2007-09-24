#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Drives Mouse devices on X11.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class X11Mouse : IMouseDriver
    {
        WindowInfo window;
        List<Mouse> mice = new List<Mouse>();

        #region Constructor

        public X11Mouse(WindowInfo window)
        {
            this.window = window;
        }

        #endregion

        #region --- IMouseDriver Members ---

        public IList<Mouse> Mouse
        {
            get {  }
        }

        public int RegisterDevices()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
