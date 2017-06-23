using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.Dummy
{
    class DummyWindowInfo : IWindowInfo
    {
        public void Dispose()
        {
        }

        public IntPtr Handle
        {
            get { return IntPtr.Zero; }
        }
    }
}
