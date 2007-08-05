using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    /// <summary>
    /// Drives the Keyboard devices on X11.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal class X11Keyboard : IKeyboardDriver
    {
        internal X11Keyboard(WindowInfo windowHandle)
        {
        }

        #region --- IKeyboardDriver Members ---

        public IList<Keyboard> Keyboard
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion
    }
}
