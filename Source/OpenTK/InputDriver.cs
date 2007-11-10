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
    internal class InputDriver : IInputDriver
    {
        private IInputDriver inputDriver;

        #region --- Constructors ---
        
        public InputDriver(GameWindow parent)
        {
            if (parent == null)
                throw new ArgumentException("A valid window (IWindowInfo) must be specified to construct an InputDriver");

            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32Windows:
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.WinCE:
                    if (Environment.OSVersion.Version.Major > 5 ||
                        (Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1))
                    {
                        inputDriver = new OpenTK.Platform.Windows.WinRawInput(parent.WindowInfo);
                    }
                    else
                    {
                        // Legacy or unknown windows version:
                        inputDriver = new OpenTK.Platform.Windows.WMInput(parent.WindowInfo);
                    }
                    break;

                case PlatformID.Unix:
                    // TODO: Input is currently handled asychronously by the driver in X11GLNative.
                    //inputDriver = new OpenTK.Platform.X11.X11Input(parent.WindowInfo);
                    
                    break;

                default:
                    throw new PlatformNotSupportedException(
    "Input handling is not supported on the current platform. Please report the problem to http://opentk.sourceforge.net");

            }
        }
        
        #endregion

        #region --- IInputDriver Members ---

        public IList<KeyboardDevice> Keyboard
        {
            get { return inputDriver.Keyboard; }
        }

        public IList<MouseDevice> Mouse
        {
            get { return inputDriver.Mouse; }
        }

        public void Poll()
        {
            inputDriver.Poll();
        }
        /*
        int IMouseDriver.RegisterDevices()
        {
            return inputDriver.RegisterDevices();
        }
        */
        #endregion

        #region --- IDisposable Members ---

        private bool disposed;

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    inputDriver.Dispose();
                }

                disposed = true;
            }
        }

        ~InputDriver()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
