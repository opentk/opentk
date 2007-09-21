#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Describes a Windows.Form.Control, Windows.Forms.NativeWindow or OpenTK.GameWindow on the Windows platform.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    public sealed class WindowInfo : IMutableWindowInfo
    {
        private IntPtr handle;
        private WindowInfo parent;

        public WindowInfo()
        {
        }

        public WindowInfo(IWindowInfo info)
        {
            /*
            if (info == null)
                throw new ArgumentException("WindowInfo cannot be null.");

            this.Handle = info.Handle;
            this.Parent = info.Parent;
            */
            this.CopyInfoFrom(info);
        }

        public WindowInfo(Control control)
        {
            if (control == null)
                throw new ArgumentException("Control cannot be null.");

            this.Handle = control.Handle;
            this.Parent = control.Parent != null ? new WindowInfo(control.Parent) : this.Parent;
        }

        public WindowInfo(NativeWindow window)
        {
            if (window == null)
                throw new ArgumentException("NativeWindow cannot be null.");

            this.Handle = window.Handle;
            this.Parent = null;
        }

        public WindowInfo(GameWindow window)
        {
            if (window == null)
                throw new ArgumentException("GameWindow cannot be null.");
            /*
            this.Handle = window.WindowInfo.Handle;
            this.Parent = window.WindowInfo.Parent;
            */
            this.CopyInfoFrom(window.WindowInfo);
        }

        #region --- IWindowInfo Members ---

        public IntPtr Handle
        {
            get { return handle; }
            internal set { handle = value; }
        }

        public IWindowInfo Parent
        {
            get { return parent; }
            internal set
            {
                parent = value as WindowInfo;
            }
        }

        public IWindowInfo GetInfoFrom(Control control)
        {
            if (control == null)
                throw new ArgumentException("Control cannot be null.");

            return new WindowInfo(control);
        }

        public IWindowInfo GetInfoFrom(NativeWindow window)
        {
            if (window == null)
                throw new ArgumentException("NativeWindow cannot be null.");

            return new WindowInfo(window);
        }

        public IWindowInfo GetInfoFrom(GameWindow window)
        {
            if (window == null)
                throw new ArgumentException("GameWindow cannot be null.");

            return GetInfoFrom(window.WindowInfo as Windows.WindowInfo);
        }

        public IWindowInfo GetInfoFrom(IWindowInfo info)
        {
            if (info == null)
                throw new ArgumentException("IWindowInfo cannot be null.");

            return info;
        }

        #endregion

        #region --- IMutableWindowInfo Members ---

        public void CopyInfoFrom(IWindowInfo info)
        {
            this.Handle = info.Handle;
            this.Parent = info.Parent;
        }

        #endregion

        public override string ToString()
        {
            return String.Format("Windows.WindowInfo: Handle {0}, Parent ({1})",
                this.Handle, this.Parent != null ? this.Parent.ToString() : "null");
        }
    }
}
