using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    public class X11Input : IInputDriver
    {
        public X11Input(IntPtr windowHandle)
        {
        }

        #region --- IInputDriver Members ---

        #region public IList<IInputDevice> InputDevices

        public IList<IInputDevice> InputDevices
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion

        #region public IList<Keyboard> Keyboard

        public IList<Keyboard> Keyboard
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion

        #region public IList<Mouse> Mouse

        public IList<Mouse> Mouse
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion

        #endregion
    }
}
