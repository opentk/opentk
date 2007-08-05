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
    }
}
