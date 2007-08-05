using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Input;

namespace OpenTK
{
    public class InputDriver : IInputDriver
    {
        IInputDriver inputDriver;

        public InputDriver(IntPtr parentHandle)
        {
            if (Environment.OSVersion.Version.Major > 5 ||
                (Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1))
            {
                inputDriver = new OpenTK.Platform.Windows.WinRawInput(parentHandle);
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                inputDriver = new OpenTK.Platform.X11.X11Input(parentHandle);
            }
            else
            {
                throw new PlatformNotSupportedException(
                    "Input handling is not supported on the current platform. Please report the problem to http://opentk.sourceforge.net");
            }
        }

        #region --- IInputDriver Members ---

        public IList<IInputDevice> InputDevices
        {
            get { return inputDriver.InputDevices; }
        }

        public IList<Keyboard> Keyboard
        {
            get { return inputDriver.Keyboard; }
        }

        public IList<Mouse> Mouse
        {
            get { return inputDriver.Mouse; }
        }

        #endregion
    }
}
