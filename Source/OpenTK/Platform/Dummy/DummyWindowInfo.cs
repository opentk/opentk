// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

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
