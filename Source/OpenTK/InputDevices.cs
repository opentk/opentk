using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Input;

namespace OpenTK
{
    public class InputDevices : IInputDriver
    {
        IInputDriver inputDriver;

        public InputDevices(IntPtr parentHandle)
        {
            if (Environment.OSVersion.Version.Major > 5 ||
                (Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1))
            {
                inputDriver = new OpenTK.Platform.Windows.WinRawInput(parentHandle);
            }
            else
            {
                throw new PlatformNotSupportedException("Input is not implemented for platforms prior to Windows XP, yet.");
            }
        }

        #region --- IInputDriver Members ---

        IList<IInputDevice> IInputDriver.InputDevices
        {
            get { return inputDriver.InputDevices; }
        }

        public IList<Keyboard> Keyboards
        {
            get { return inputDriver.Keyboards; }
        }

        #endregion
    }
}
