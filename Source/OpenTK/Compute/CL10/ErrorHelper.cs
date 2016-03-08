// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
#if EXPERIMENTAL

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Compute.CL10
{
    struct ErrorHelper : IDisposable
    {
        #region Constructors

        public ErrorHelper(IntPtr context)
        {
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

#endif