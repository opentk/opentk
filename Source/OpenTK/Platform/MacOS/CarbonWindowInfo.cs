using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OpenTK.Platform.MacOS
{
    sealed class CarbonWindowInfo : IWindowInfo 
    {
        IntPtr windowRef;
        bool ownHandle = false;
        bool disposed = false;
        bool isControl = false;

        internal CarbonWindowInfo(IntPtr windowRef, bool ownHandle, bool isControl)
        {
            this.windowRef = windowRef;
            this.ownHandle = ownHandle;
            this.isControl = isControl;
        }
        ~CarbonWindowInfo()
        {
            Dispose(false);
        }

        internal IntPtr WindowRef
        {
            get { return this.windowRef; }
        }

        public bool IsControl
        {
            get { return isControl; }
        }

        /// <summary>Returns a System.String that represents the current window.</summary>
        /// <returns>A System.String that represents the current window.</returns>
        public override string ToString()
        {
            return String.Format("MacOS.CarbonWindowInfo: Handle {0}",
                this.WindowRef);
        }

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
        }

        void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {

            }

            if (ownHandle)
            {
            	Debug.Print("Disposing window {0}.", windowRef);
                Carbon.API.DisposeWindow(this.windowRef);
                windowRef = IntPtr.Zero;
            }

            disposed = true;
        }

        #endregion
    }
}
