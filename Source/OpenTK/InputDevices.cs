using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Input;

namespace OpenTK
{
    public class InputDevices : IInputDriver
    {
        IInputDriver inputDriver;

        public InputDevices()
        {
            if (Environment.OSVersion.Version.Major > 5 ||
                (Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1))
            {
                inputDriver = new OpenTK.Platform.Windows.WinRawInput();
            }
            else
            {
                throw new PlatformNotSupportedException("Input is not implemented for platforms prior to Windows XP, yet.");
            }
        }

        #region --- IInputDriver Members ---

        IList<OpenTK.Input.IInputDevice> OpenTK.Input.IInputDriver.InputDevices
        {
            get { return inputDriver.InputDevices; }
        }

        public IList<OpenTK.Input.IKeyboard> Keyboards
        {
            get { return inputDriver.Keyboards; }
        }

        #endregion
    }
}
