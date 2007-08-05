using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    public class X11Keyboard : IKeyboardDriver
    {
        #region --- IKeyboardDriver Members ---

        public IList<Keyboard> Keyboard
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion
    }
}
