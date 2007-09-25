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
        private IInputDriver inputDriver;

        #region --- Constructors ---
        
        public InputDriver(IWindowInfo parent)
        {
            if (parent == null)
                throw new ArgumentException("A valid window (IWindowInfo) must be specified to construct an InputDriver");

            if (Environment.OSVersion.Version.Major > 5 ||
                (Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1))
            {
                inputDriver = new OpenTK.Platform.Windows.WinRawInput(parent);
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                inputDriver = new OpenTK.Platform.X11.X11Input(
                    parent is OpenTK.Platform.X11.WindowInfo ? (OpenTK.Platform.X11.WindowInfo)parent :
                    parent is OpenTK.Platform.WindowInfo ? (OpenTK.Platform.X11.WindowInfo)(parent as OpenTK.Platform.WindowInfo) : null);
            }
            else
            {
                throw new PlatformNotSupportedException(
                    "Input handling is not supported on the current platform. Please report the problem to http://opentk.sourceforge.net");
            }
        }
        
        #endregion

        #region --- IInputDriver Members ---

        public IList<Keyboard> Keyboard
        {
            get { return inputDriver.Keyboard; }
        }

        public IList<Mouse> Mouse
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
