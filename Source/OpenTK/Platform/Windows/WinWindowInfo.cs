using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Windows
{
    /// <summary>Describes a win32 window.</summary>
    public sealed class WinWindowInfo : IWindowInfo
    {
        IntPtr handle, dc;
        WinWindowInfo parent;
        bool disposed;

        #region --- Constructors ---

        internal WinWindowInfo()
        {
        }

        internal WinWindowInfo(IntPtr handle, WinWindowInfo parent)
        {
            this.handle = handle;
            this.parent = parent;
        }

        #endregion

        #region --- Public Methods ---

        public IntPtr WindowHandle { get { return handle; } set { handle = value; } }
        public WinWindowInfo Parent { get { return parent; } set { parent = value; } }
        public IntPtr DeviceContext
        {
            get
            {
                if (dc == IntPtr.Zero)
                    dc = Functions.GetDC(this.WindowHandle);
                return dc;
            }
            //set { dc = value; }
        }

        #region public override string ToString()

        /// <summary>Returns a System.String that represents the current window.</summary>
        /// <returns>A System.String that represents the current window.</returns>
        public override string ToString()
        {
            return String.Format("Windows.WindowInfo: Handle {0}, Parent ({1})",
                this.WindowHandle, this.Parent != null ? this.Parent.ToString() : "null");
        }

        /// <summary>Checks if <c>this</c> and <c>obj</c> reference the same win32 window.</summary>
        /// <param name="obj">The object to check against.</param>
        /// <returns>True if <c>this</c> and <c>obj</c> reference the same win32 window; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;
            WinWindowInfo info = (WinWindowInfo)obj; 

            if (info == null) return false;
            // TODO: Assumes windows will always have unique handles.
            return handle.Equals(info.handle);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A hash code for the current <c>WinWindowInfo</c>.</returns>
        public override int GetHashCode()
        {
            return handle.GetHashCode();
        }

        #endregion

        #endregion

        #region --- IDisposable ---

        #region public void Dispose()

        /// <summary>Releases the unmanaged resources consumed by this instance.</summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region void Dispose(bool manual)

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (this.dc != IntPtr.Zero)
                    if (!Functions.ReleaseDC(this.handle, this.dc))
                        Debug.Print("[Warning] Failed to release device context {0}. Windows error: {1}.", this.dc, Marshal.GetLastWin32Error());

                if (manual)
                {
                    if (parent != null)
                        parent.Dispose();
                }

                disposed = true;
            }
        }

        #endregion

        #region ~WinWindowInfo()

        ~WinWindowInfo()
        {
            this.Dispose(false);
        }

        #endregion

        #endregion
    }
}
