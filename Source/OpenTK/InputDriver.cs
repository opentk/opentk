#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Input;
using OpenTK.Platform;

namespace OpenTK
{
    public class InputDriver : IInputDriver
    {
        IInputDriver inputDriver;

        public InputDriver(IWindowInfo parent)
        {
            if (Environment.OSVersion.Version.Major > 5 ||
                (Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1))
            {
                inputDriver = new OpenTK.Platform.Windows.WinRawInput(parent as OpenTK.Platform.Windows.WindowInfo);
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                inputDriver = 
                    new OpenTK.Platform.X11.X11Input(parent as OpenTK.Platform.X11.WindowInfo);
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

        public IList<OpenTK.Input.Mouse> Mouse
        {
            get { return inputDriver.Mouse; }
        }

        public void ProcessEvents()
        {
            inputDriver.ProcessEvents();
        }

        #endregion
    }
}
