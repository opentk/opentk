using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Describes a Windows window.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal class WindowInfo : IWindowInfo
    {
        private IntPtr handle;
        private WindowInfo parent;

        #region --- IWindowInfo Members ---

        public IntPtr Handle
        {
            get { return handle; }
            internal set { handle = value; }
        }

        public IWindowInfo Parent
        {
            get { return parent; }
            internal set { parent = value as WindowInfo; }
        }

        #endregion

        public override string ToString()
        {
            return String.Format("Windows.WindowInfo: Handle {0}, Parent ({1})",
                this.Handle, this.Parent != null ? this.Parent.ToString() : "null");
        }

    }
}
