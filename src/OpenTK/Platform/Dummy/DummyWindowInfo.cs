using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.Dummy
{
    class DummyWindowInfo : IWindowInfo
    {
        #region IDisposable Members

        public void Dispose()
        {
        }

        #endregion

        public IntPtr Handle
        {
            get { return IntPtr.Zero; }
        }
    }
}
